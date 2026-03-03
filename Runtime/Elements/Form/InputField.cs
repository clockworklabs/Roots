using System;
using System.Linq;
using System.Reflection;
using RishUI;
using RishUI.Events;
using Sappy;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class InputField : RishElement<InputFieldProps>, IMountingListener, IPropsListener<InputFieldProps>
    {
        private const int IgnoreKeyMillis = 150;
        
        public enum Type { Text, Integer, Long, Float }
        
        private Form Form { get; set; }
        private bool JustMounted { get; set; }

        private uint FormIndex { get; set; }
        private long FocusTimestamp { get; set; }

        public InputField()
        {
            RegisterCallback<VisualChangeEvent>(OnVisualChange);
            RegisterCallback<FocusEvent>(OnFocus);
            RegisterCallback<KeyDownEvent>(OnKeyDown);
        }
        
        void IMountingListener.ElementDidMount()
        {
            Form = GetFirstAncestorOfType<Form>();
            FormIndex = Form?.RegisterElement(this) ?? 0;
            
            JustMounted = true;
        }
        void IMountingListener.ElementWillUnmount()
        {
            Form?.UnregisterElement(this);
            NotFocusable();
        }

        void IPropsListener<InputFieldProps>.PropsDidChange(InputFieldProps? prev)
        {
            if (prev.HasValue && prev.Value.readOnly == Props.readOnly) return;
            
            if (Props.readOnly)
            {
                NotFocusable();
            }
            else
            {
                Focusable(FormIndex);
            }
        }
        void IPropsListener<InputFieldProps>.PropsWillChange() { }

        protected override Element Render()
        {
            var descriptor = Props.multiline
                ? Props.descriptor
                : Props.descriptor + new Style
                {
                    whiteSpace = WhiteSpace.NoWrap
                };

            return RishTextField.Create(
                key: 0,
                name: descriptor.name,
                className: descriptor.className,
                style: descriptor.style,
                value: Props.value,
                updateOnEveryKeystroke: Props.updateOnEveryKeystroke,
                multiline: Props.multiline,
                isPassword: Props.isPassword,
                richTextEnabled: Props.richTextEnabled,
                parseEscapeSequences: Props.parseEscapeSequences,
                readOnly: Props.readOnly,
                maxLength: Props.maxLength,
                multiClickInteraction: Props.multiClickInteraction,
                selectOnFocus: Props.selectOnFocus,
                textInputDescriptor: Props.textInputDescriptor,
                textElementDescriptor: Props.textElementDescriptor,
                cursorColor: Props.cursorColor,
                selectionColor: Props.selectionColor,
                onValidation: Sappy.OnValidation,
                onChange: Sappy.OnChange);
        }

        [SapTarget]
        private string OnValidation(string value)
        {
            string result;
            switch (Props.type)
            {
                case Type.Text:
                    result = value;
                    break;
                case Type.Integer:
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        result = "0";
                    } else if (int.TryParse(value, out _))
                    {
                        result = value;
                    }
                    else
                    {
                        result = value;
                        for (int i = 0, n = value.Length; i < n; i++)
                        {
                            var c = value[i];
                            if (char.IsDigit(c) || (i == 0 && c == '-'))
                            {
                                if (result.Length < n)
                                {
                                    result += c;
                                }
                            }
                            else
                            {
                                if (result.Length == n)
                                {
                                    result = value[..i];
                                }
                            }
                        }
                        
                        if (!int.TryParse(result, out _))
                        {
                            return Props.value;
                        }
                    }
                    break;
                case Type.Long:
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        result = "0";
                    } else if (long.TryParse(value, out _))
                    {
                        result = value;
                    }
                    else
                    {
                        result = value;
                        for (int i = 0, n = value.Length; i < n; i++)
                        {
                            var c = value[i];
                            if (char.IsDigit(c) || (i == 0 && c == '-'))
                            {
                                if (result.Length < n)
                                {
                                    result += c;
                                }
                            }
                            else
                            {
                                if (result.Length == n)
                                {
                                    result = value[..i];
                                }
                            }
                        }
                        
                        if (!long.TryParse(result, out _))
                        {
                            return Props.value;
                        }
                    }
                    break;
                case Type.Float:
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        result = "0";
                    } else if (float.TryParse(value, out _))
                    {
                        result = value;
                    }
                    else
                    {
                        result = value;

                        var isInteger = true;
                        for (int i = 0, n = value.Length; i < n; i++)
                        {
                            var c = value[i];
                            var isPoint = c is '.' or ',';
                            if (char.IsDigit(c) || (i == 0 && c == '-') || (isInteger && isPoint))
                            {
                                if (isPoint)
                                {
                                    c = '.';
                                    isInteger = false;
                                }
                                
                                if (result.Length < n)
                                {
                                    result += c;
                                }
                            }
                            else
                            {
                                if (result.Length == n)
                                {
                                    result = value[..i];
                                }
                            }
                        }
                        
                        if (!float.TryParse(result, out _))
                        {
                            return Props.value;
                        }
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return result;
        }

        [SapTarget]
        private void OnChange(string value)
        {
            if (value == Props.value) return;
            
            var result = OnValidation(value);
            
            RishOnChange(result);
        }

        private void OnVisualChange(VisualChangeEvent evt)
        {
            if (!JustMounted)
            {
                return;
            }
            
            JustMounted = false;
            
            if (Props.autoFocus)
            {
                Focus();
            }
        }
        
        private void OnFocus(FocusEvent evt) => FocusTimestamp = evt.timestamp;

        private void OnKeyDown(KeyDownEvent evt)
        {
            if (evt.timestamp <= FocusTimestamp + IgnoreKeyMillis) return;
                
            switch (evt.keyCode)
            {
                case KeyCode.Escape:
                    Blur();
                    break;
                case KeyCode.Return:
                    if (!Props.multiline)
                    {
                        Form?.Submit();
                        Blur();
                    }
                    break;
            }
        }

        private partial class RishTextField : TextField, IVisualElement<RishTextFieldProps>, IStyledProps<RishTextFieldProps>, IManualState
        {
            private Bridge<RishTextFieldProps> Bridge { get; }
            Bridge<RishTextFieldProps> IVisualElement<RishTextFieldProps>.Bridge => Bridge;
            
            private PickingManager PickingManager { get; }
            PickingManager ICustomPicking.Manager => PickingManager;
            
            private string[] TextInputClasses { get; }
            private string[] TextElementClasses { get; }
            
            private static readonly CustomStyleProperty<int> MaxLengthProp = new("--props-max-length"); 
            private static readonly CustomStyleProperty<bool> MultiClickInteractionProp = new("--props-multi-click-interaction");
            private static readonly CustomStyleProperty<bool> SelectOnFocusProp = new("--props-select-on-focus");
            private static readonly CustomStyleProperty<Color> CursorColorProp = new("--props-cursor-color"); 
            private static readonly CustomStyleProperty<Color> SelectionColorProp = new("--props-selection-color");

            private RishTextFieldProps? Props { get; set; }
            
            private delegate void SetSize(VisualElement textInputBase, Vector2 size);
            private static SetSize SetSizeMethod { get; set; }
            
            private delegate void ManualLayoutSetter(VisualElement textInputBase, bool value);
            private static ManualLayoutSetter ManualLayoutSetMethod { get; set; }
            
            private delegate TextElement TextElementGetter(TextInputBase textInputBase);
            private static TextElementGetter TextElementGetMethod { get; set; }
            
            private TextElement TextElement { get; }

            // private delegate void UpdateScrollOffset(TextInputBase textInputBase, bool isBackspace, bool widthChanged);
            // private static UpdateScrollOffset UpdateScrollOffsetMethod { get; set; }
            
            private long FocusTimestamp { get;set; }
            private long BlurTimestamp { get;set; }

            void IManualState.Restart()
            {
                Props = null;
                SetSizeMethod(TextElement, Vector2.zero);
                TextElement.MarkDirtyRepaint();
                cursorIndex = 0;
                value = null;
            }
            
            public RishTextField()
            {
                Bridge = new Bridge<RishTextFieldProps>(this, true);
                
                RegisterCallback<FocusEvent>(OnFocus);
                RegisterCallback<BlurEvent>(OnBlur);
                this.RegisterValueChangedCallback(OnNewValue);
                
                PickingManager = new RectPickingManager(Bridge);
                
                textInputBase.name = null;
                TextInputClasses = textInputBase.GetClasses().ToArray();
                
                if (SetSizeMethod == null)
                {
                    var methodInfo = typeof(VisualElement).GetMethod("SetSize", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    SetSizeMethod = (SetSize) Delegate.CreateDelegate(typeof(SetSize), methodInfo);
                }
                
                if (ManualLayoutSetMethod == null)
                {
                    var propertyInfo = typeof(VisualElement).GetProperty("isLayoutManual", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    ManualLayoutSetMethod = (ManualLayoutSetter) Delegate.CreateDelegate(typeof(ManualLayoutSetter), propertyInfo.GetSetMethod(true));
                }

                if (TextElementGetMethod == null)
                {
                    var propertyInfo = textInputBase.GetType().GetProperty("textElement", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    TextElementGetMethod = (TextElementGetter) Delegate.CreateDelegate(typeof(TextElementGetter), propertyInfo.GetGetMethod(true));
                }

                TextElement = TextElementGetMethod(textInputBase);

                TextElement.name = null;
                TextElementClasses = TextElement.GetClasses().ToArray();
            }

            void IVisualElement<RishTextFieldProps>.Setup(RishTextFieldProps props)
            {
                var firstSetup = !Props.HasValue;
                
                if (firstSetup)
                {
                    SetSizeMethod(TextElement, textInputBase.contentRect.size);
                    ManualLayoutSetMethod(TextElement, false);
                    TextElement.MarkDirtyRepaint();
                }
                
                if (firstSetup || value != props.value)
                {
                    value = props.value;
                }
                
                if (firstSetup || multiline != props.multiline)
                {
                    multiline = props.multiline;
                }
                if (firstSetup || isPasswordField != props.isPassword)
                {
                    isPasswordField = props.isPassword;
                }

                if (firstSetup || isReadOnly != props.readOnly)
                {
                    isReadOnly = props.readOnly;
                    focusable = !props.readOnly;
                }
                
                textInputBase.focusable = false;

                var targetMaxLength = props.maxLength.Value;
                if (firstSetup || maxLength != targetMaxLength)
                {
                    maxLength = targetMaxLength;
                }
                var targetMultiClickInteraction = props.multiClickInteraction.Value;
                if (firstSetup || doubleClickSelectsWord != targetMultiClickInteraction)
                {
                    doubleClickSelectsWord = targetMultiClickInteraction;
                }
                if (firstSetup || tripleClickSelectsLine != targetMultiClickInteraction)
                {
                    tripleClickSelectsLine = targetMultiClickInteraction;
                }

                var selectOnFocus = props.selectOnFocus.Value;
                if (firstSetup || selectAllOnFocus != selectOnFocus)
                {
                    selectAllOnFocus = selectOnFocus;
                }

                var targetCursorColor = props.cursorColor.Value;
                if (firstSetup || textInputBase.cursorColor != targetCursorColor)
                {
                    textInputBase.cursorColor = targetCursorColor;
                }
                var targetSelectionColor = props.selectionColor.Value;
                if (firstSetup || textInputBase.selectionColor != targetSelectionColor)
                {
                    textInputBase.selectionColor = targetSelectionColor;
                }

                var textInputDescriptor = props.textInputDescriptor;
                if (firstSetup || textInputBase.name != textInputDescriptor.name)
                {
                    textInputBase.name = textInputDescriptor.name;
                }
                if (firstSetup || !RishUtils.Compare(Props.Value.textInputDescriptor.className, textInputDescriptor.className))
                {
                    textInputBase.SetClassName(textInputDescriptor.className);
                    foreach (var className in TextInputClasses)
                    {
                        textInputBase.AddToClassList(className);
                    }
                }
                if (firstSetup || !RishUtils.MemCmp(Props.Value.textInputDescriptor.style, textInputDescriptor.style))
                {
                    textInputBase.ForceStyle(textInputDescriptor.style);
                }

                var textElementDescriptor = props.textElementDescriptor;
                if (firstSetup || TextElement.name != textElementDescriptor.name)
                {
                    TextElement.name = textElementDescriptor.name;
                }
                if (firstSetup || !RishUtils.Compare(Props.Value.textElementDescriptor.className, textElementDescriptor.className))
                {
                    TextElement.SetClassName(textElementDescriptor.className);
                    foreach (var className in TextElementClasses)
                    {
                        TextElement.AddToClassList(className);
                    }
                }
                if (firstSetup || !RishUtils.MemCmp(Props.Value.textElementDescriptor.style, textElementDescriptor.style))
                {
                    TextElement.ForceStyle(textElementDescriptor.style);
                }

                if (firstSetup || TextElement.enableRichText != props.richTextEnabled)
                {
                    TextElement.enableRichText = props.richTextEnabled;
                }

                if (firstSetup || TextElement.parseEscapeSequences != props.parseEscapeSequences)
                {
                    TextElement.parseEscapeSequences = props.parseEscapeSequences;
                }
                
                Props = props;
            }

            void IStyledProps<RishTextFieldProps>.OnCustomStyle(IStyler styler, ref RishTextFieldProps props)
            {
                styler.SetValue(MaxLengthProp, ref props.maxLength, -1);
                styler.SetValue(MultiClickInteractionProp, ref props.multiClickInteraction, true);
                styler.SetValue(SelectOnFocusProp, ref props.selectOnFocus, false);
                styler.SetValue(CursorColorProp, ref props.cursorColor, Color.black);
                styler.SetValue(SelectionColorProp, ref props.selectionColor, new Color(0.39f, 0.58f, 0.93f, 0.4f));
            }
            
            public override bool ContainsPoint(Vector2 localPoint) => PickingManager.ContainsPoint(localPoint);

            private void OnFocus(FocusEvent evt)
            {
                if (evt.timestamp < BlurTimestamp + IgnoreKeyMillis)
                {
                    Blur();
                    return;
                }
                FocusTimestamp = evt.timestamp;
                TextElement.Focus();
            }
            private void OnBlur(BlurEvent evt)
            {
                if (!Props.HasValue || evt.target != this || evt.timestamp < FocusTimestamp + IgnoreKeyMillis) return;
                
                BlurTimestamp = evt.timestamp;
                
                var props = Props.Value;
                if (!props.updateOnEveryKeystroke)
                {
                    props.onChange?.Invoke(value);
                }
            }

            private void OnNewValue(ChangeEvent<string> value)
            {
                if (!Props.HasValue) return;
                var props = Props.Value;
                var result = props.onValidation?.Invoke(value.newValue);
                if (props.updateOnEveryKeystroke)
                {
                    props.onChange?.Invoke(result);
                } else if (value.newValue != result)
                {
                    this.value = result;
                }
            }
        }
        [RishValueType]
        public struct RishTextFieldProps
        {
            public RishString value;
            public bool updateOnEveryKeystroke;
            public bool multiline;
            public bool isPassword;
            public bool readOnly;
            public bool richTextEnabled;
            public bool parseEscapeSequences;

            /// <summary>
            /// Styled Prop as --props-max-length
            /// </summary>
            public int? maxLength;

            /// <summary>
            /// Styled Prop as --props-multi-click-interaction
            /// </summary>
            public bool? multiClickInteraction;

            /// <summary>
            /// Styled Prop as --props-select-on-focus
            /// </summary>
            public bool? selectOnFocus;
            
            public VisualAttributes textInputDescriptor;
            public VisualAttributes textElementDescriptor;

            /// <summary>
            /// Styled Prop as --props-cursor-color
            /// </summary>
            public Color? cursorColor;

            /// <summary>
            /// Styled Prop as --props-selection-color
            /// </summary>
            public Color? selectionColor;

            public Func<string, string> onValidation;
            public Action<string> onChange;
        }
    }

    [RishValueType]
    public struct InputFieldProps
    {
        public InputField.Type type;
        
        [Expand]
        public VisualAttributes descriptor;
        [Expand]
        public VisualAttributes textInputDescriptor;
        [Expand]
        public VisualAttributes textElementDescriptor;
        public RishString value;
        public bool updateOnEveryKeystroke;
        public bool multiline;
        public bool isPassword;
        public bool readOnly;
        public int? maxLength;
        public bool? multiClickInteraction;
        public bool? selectOnFocus;
        public bool autoFocus;
        public bool richTextEnabled;
        public bool parseEscapeSequences;
        public Color? cursorColor;
        public Color? selectionColor;
        
        public Action<string> onChange;
    }
}