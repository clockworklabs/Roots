using System;
using System.Collections.Generic;
using RishUI;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public interface IFormSubmit
    {
        bool OnFormSubmit();
    }
    
    public partial class Form : RishElement<FormProps>, IMountingListener
    {
        private Form ParentForm { get; set; }
        private uint Index { get; set; }

        private List<IElement> Elements { get; } = new();
        private uint ElementsCount => (uint) Elements.Count;
        private uint FormsCount { get; set; }
        
        public Form()
        {
            RegisterCallback<KeyDownEvent>(OnKeyDown);
        }

        void IMountingListener.ElementDidMount()
        {
            ParentForm = GetFirstAncestorOfType<Form>();

            Index = ParentForm?.RegisterForm() ?? 0;
        }

        void IMountingListener.ElementWillUnmount()
        {
            ParentForm?.UnregisterForm();
            
            Index = 0;
            Elements.Clear();
            FormsCount = 0;
        }

        protected override Element Render()
        {
            return Props.content;
        }

        private void OnKeyDown(KeyDownEvent evt)
        {
            if (evt.keyCode != KeyCode.Return)
            {
                return;
            }
            
            evt.StopPropagation();
            
            Submit();
        }

        internal void Submit()
        {
            foreach (var element in Elements)
            {
                if (element is IFormSubmit submit && submit.OnFormSubmit())
                {
                    return;
                }
            }
            
            SubmitAction();
        }

        public uint RegisterElement(IElement element)
        {
            if (Elements.Contains(element))
            {
                throw new UnityException("Element already registered into the form");
            }
            
            Elements.Add(element);
            
            return Index + ElementsCount;
        }

        public void UnregisterElement(IElement element)
        {
            var index = Elements.IndexOf(element);
            if (index < 0)
            {
                throw new UnityException("Element not registered into the form");
            }
            Elements.RemoveAtSwapBack(index);
        }

        private uint RegisterForm()
        {
            if (ParentForm != null)
            {
                return ParentForm.RegisterForm();
            }

            return ++FormsCount * 10000;
        }
        private void UnregisterForm()
        {
            if (ParentForm != null)
            {
                ParentForm.UnregisterForm();
                return;
            }

            FormsCount--;
        }
    }

    [RishValueType]
    public struct FormProps
    {
        public Element content;
        
        public Action submitAction;
    }
}