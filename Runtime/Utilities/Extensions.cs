using UnityEngine.UIElements;

namespace Roots
{
    public static class Extensions
    {
        public static void AddClassNames(this VisualElement visualElement, Utilities utilities) =>
            utilities.AddClassNamesTo(visualElement);
        
        public static LanguageDirection GetComputedLanguageDirection(this VisualElement visualElement) {
            var direction = LanguageDirection.Inherit;
            while(direction == LanguageDirection.Inherit && visualElement != null)
            {
                direction = visualElement.languageDirection;
                visualElement = visualElement.parent;
            }
            if (direction == LanguageDirection.Inherit)
            {
                direction = LanguageDirection.LTR;
            }

            return direction;
        }
    }
}
