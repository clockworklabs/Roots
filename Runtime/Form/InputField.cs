using System;
using System.Linq;
using System.Reflection;
using RishUI;
using RishUI.Events;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public partial class InputField : RishElement<InputFieldProps>, IMountingListener
    {
        public enum Type { Text, Integer, Long, Float }
        
        private Form Form { get; set; }
        private bool JustMounted { get; set; }

        public InputField()
        {
            RegisterCallback<VisualChangeEvent>(OnVisualChange);
            RegisterCallback<KeyDownEvent>(OnKeyDown);
        }
        
        void IMountingListener.ComponentDidMount()
        {
            Form = GetFirstAncestorOfType<Form>();
            var index = Form?.RegisterElement(this) ?? 0;
            Focusable(index);
            
            JustMounted = true;
        }
        void IMountingListener.ComponentWillUnmount()
        {
            Form?.UnregisterElement(this);
            NotFocusable();
        }

        protected override Element Render()
        {
            var descriptor = new DOMDescriptor(Props.descriptor);
            if (!Props.multiline)
            {
                descriptor.style = new Style(Props.descriptor.style)
                {
                    whiteSpace = WhiteSpace.NoWrap
                };
            }

            return Rish.Create<RishTextField, RishTextFieldProps>(
                key: 0,
                descriptor: descriptor,
                new RishTextFieldProps
                {
                    value = Props.value,
                    updateOnEveryKeystroke = Props.updateOnEveryKeystroke,
                    multiline = Props.multiline,
                    isPassword = Props.isPassword,
                    richTextEnabled = Props.richTextEnabled,
                    parseEscapeSequences = Props.parseEscapeSequences,
                    readOnly = Props.readOnly,
                    maxLength = Props.maxLength,
                    multiClickInteraction = Props.multiClickInteraction,
                    selectOnFocus = Props.selectOnFocus,
                    textInputDescriptor = Props.textInputDescriptor,
                    textElementDescriptor = Props.textElementDescriptor,
                    cursorColor = Props.cursorColor,
                    selectionColor = Props.selectionColor,
                    onValidation = OnValidation,
                    onChange = OnChange
                });
        }

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

        private void OnChange(string value)
        {
            var result = OnValidation(value);
            
            Props.onChange?.Invoke(result);
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

        private void OnKeyDown(KeyDownEvent evt)
        {
            if (!HasFocus || Props.multiline || evt.keyCode != KeyCode.Return)
            {
                return;
            }
            
            Form?.Submit();
        }

        [IgnoreWarnings]
        private class RishTextField : TextField, IVisualElement<RishTextFieldProps>, IStyledProps<RishTextField, RishTextFieldProps>
        {
            private Bridge<RishTextFieldProps> Bridge { get; }
            Bridge<RishTextFieldProps> IVisualElement<RishTextFieldProps>.Bridge => Bridge;
            
            VisualElement IElement.GetDOMChild() => this;
            
            private PickingManager PickingManager { get; }
            PickingManager ICustomPicking.Manager => PickingManager;
        
            private StyledPropsManager<RishTextField, RishTextFieldProps> PropsManager { get; }
            StyledPropsManager<RishTextField, RishTextFieldProps> IStyledProps<RishTextField, RishTextFieldProps>.Manager => PropsManager;
            
            private string[] TextInputClasses { get; }
            private string[] TextElementClasses { get; }
            
            private static readonly CustomStyleProperty<int> MaxLengthProp = new("--props-max-length"); 
            private static readonly CustomStyleProperty<bool> MultiClickInteractionProp = new("--props-multi-click-interaction");
            private static readonly CustomStyleProperty<bool> SelectOnFocusProp = new("--props-select-on-focus");
            private static readonly CustomStyleProperty<Color> CursorColorProp = new("--props-cursor-color"); 
            private static readonly CustomStyleProperty<Color> SelectionColorProp = new("--props-selection-color");

            private RishTextFieldProps _props;
            
            private delegate TextElement TextElementGetter(TextInputBase textInputBase);
            private static TextElementGetter TextElementGetMethod { get; set; }
            private TextElement TextElement { get; }
            
            private long FocusTimestamp { get; set; }
            
            public RishTextField()
            {
                Bridge = new Bridge<RishTextFieldProps>(this, true);
                
                RegisterCallback<FocusEvent>(OnFocus);
                RegisterCallback<BlurEvent>(OnBlur);
                RegisterCallback<KeyDownEvent>(OnKeyDown);
                this.RegisterValueChangedCallback(OnNewValue);
                
                PickingManager = new RectPickingManager(Bridge);
                PropsManager = new StyledPropsManager<RishTextField, RishTextFieldProps>(this);
                
                textInputBase.name = null;
                TextInputClasses = textInputBase.GetClasses().ToArray();

                if (TextElementGetMethod == null)
                {
                    var propertyInfo = textInputBase.GetType().GetProperty("textElement", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    TextElementGetMethod = (TextElementGetter) Delegate.CreateDelegate(typeof(TextElementGetter), propertyInfo.GetGetMethod(true));
                }

                TextElement = TextElementGetMethod(textInputBase);

                TextElement.name = null;
                TextElementClasses = TextElement.GetClasses().ToArray();
            }

            void IVisualElement<RishTextFieldProps>.Setup(RishTextFieldProps props) => PropsManager.Setup(props);
            void IStyledProps<RishTextField, RishTextFieldProps>.Setup(RishTextFieldProps props)
            {
                var targetValue = props.value;
                if (value != targetValue)
                {
                    value = targetValue;
                }
                
                if (multiline != props.multiline)
                {
                    multiline = props.multiline;
                }
                if (isPasswordField != props.isPassword)
                {
                    isPasswordField = props.isPassword;
                }

                if (isReadOnly != props.readOnly)
                {
                    isReadOnly = props.readOnly;
                }

                // focusable = !props.readOnly;
                // textInputBase.focusable = !props.readOnly;

                var targetMaxLength = props.maxLength.Value;
                if (maxLength != targetMaxLength)
                {
                    maxLength = targetMaxLength;
                }
                var targetMultiClickInteraction = props.multiClickInteraction.Value;
                if (doubleClickSelectsWord != targetMultiClickInteraction)
                {
                    doubleClickSelectsWord = targetMultiClickInteraction;
                }
                if (tripleClickSelectsLine != targetMultiClickInteraction)
                {
                    tripleClickSelectsLine = targetMultiClickInteraction;
                }

                var selectOnFocus = props.selectOnFocus.Value;
                if (selectAllOnFocus != selectOnFocus)
                {
                    selectAllOnFocus = selectOnFocus;
                }

                var targetCursorColor = props.cursorColor.Value;
                if (textInputBase.cursorColor != targetCursorColor)
                {
                    textInputBase.cursorColor = targetCursorColor;
                }
                var targetSelectionColor = props.selectionColor.Value;
                if (textInputBase.selectionColor != targetSelectionColor)
                {
                    textInputBase.selectionColor = targetSelectionColor;
                }

                var textInputDescriptor = props.textInputDescriptor;
                if (textInputBase.name != textInputDescriptor.name)
                {
                    textInputBase.name = textInputDescriptor.name;
                }
                if (!RishUtils.SmartCompare(_props.textInputDescriptor.className, textInputDescriptor.className))
                {
                    textInputBase.SetClassName(textInputDescriptor.className);
                    foreach (var className in TextInputClasses)
                    {
                        textInputBase.AddToClassList(className);
                    }
                }
                if (!RishUtils.SmartCompare(_props.textInputDescriptor.style, textInputDescriptor.style))
                {
                    textInputBase.SetStyle(textInputDescriptor.style);
                }

                var textElementDescriptor = props.textElementDescriptor;
                if (TextElement.name != textElementDescriptor.name)
                {
                    TextElement.name = textElementDescriptor.name;
                }
                if (!RishUtils.SmartCompare(_props.textElementDescriptor.className, textElementDescriptor.className))
                {
                    TextElement.SetClassName(textElementDescriptor.className);
                    foreach (var className in TextElementClasses)
                    {
                        TextElement.AddToClassList(className);
                    }
                }
                if (!RishUtils.SmartCompare(_props.textElementDescriptor.style, textElementDescriptor.style))
                {
                    TextElement.SetStyle(textElementDescriptor.style);
                }

                if (TextElement.enableRichText != props.richTextEnabled)
                {
                    TextElement.enableRichText = props.richTextEnabled;
                }

                if (TextElement.parseEscapeSequences != props.parseEscapeSequences)
                {
                    TextElement.parseEscapeSequences = props.parseEscapeSequences;
                }
                
                _props = props;
            }

            void IStyledProps<RishTextField, RishTextFieldProps>.OnCustomStyle(ref RishTextFieldProps props)
            {
                PropsManager.SetValue(MaxLengthProp, ref props.maxLength, -1);
                PropsManager.SetValue(MultiClickInteractionProp, ref props.multiClickInteraction, true);
                PropsManager.SetValue(SelectOnFocusProp, ref props.selectOnFocus, false);
                PropsManager.SetValue(CursorColorProp, ref props.cursorColor, Color.black);
                PropsManager.SetValue(SelectionColorProp, ref props.selectionColor, new Color(0.39f, 0.58f, 0.93f, 0.4f));
            }
            
            public override bool ContainsPoint(Vector2 localPoint) => PickingManager.ContainsPoint(localPoint);
            
            private void OnFocus(FocusEvent evt)
            {
                FocusTimestamp = evt.timestamp;
            }
            private void OnBlur(BlurEvent evt)
            {
                if (_props.updateOnEveryKeystroke || evt.target != this)
                {
                    return;
                }
                
                _props.onChange?.Invoke(value);
            }
            private void OnKeyDown(KeyDownEvent evt)
            {
                if (evt.timestamp <= FocusTimestamp + 1000) return;
                
                switch (evt.keyCode)
                {
                    case KeyCode.Escape:
                        value = _props.value;
                        Blur();
                        break;
                    case KeyCode.Return:
                        if (!_props.multiline)
                        {
                            Blur();
                        }
                        break;
                }
            }

            private void OnNewValue(ChangeEvent<string> value)
            {
                var result = _props.onValidation?.Invoke(value.newValue);
                if (_props.updateOnEveryKeystroke)
                {
                    _props.onChange?.Invoke(result);
                } else if (value.newValue != result)
                {
                    this.value = result;
                }
            }
        }
        [RishValueType]
        public struct RishTextFieldProps
        {
            public string value;
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
            
            public DOMDescriptor textInputDescriptor;
            public DOMDescriptor textElementDescriptor;

            /// <summary>
            /// Styled Prop as --props-cursor-color
            /// </summary>
            public Color? cursorColor;

            /// <summary>
            /// Styled Prop as --props-selection-color
            /// </summary>
            public Color? selectionColor;

            [IgnoreComparison]
            public Func<string, string> onValidation;
            [IgnoreComparison]
            public Action<string> onChange;
        }
    }

    [RishValueType]
    public struct InputFieldProps
    {
        public InputField.Type type;
        
        [DOMDescriptor]
        public DOMDescriptor descriptor;
        [DOMDescriptor]
        public DOMDescriptor textInputDescriptor;
        [DOMDescriptor]
        public DOMDescriptor textElementDescriptor;
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
        [IgnoreComparison]
        public Action<string> onChange;
    }
}