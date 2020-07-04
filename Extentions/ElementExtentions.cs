using TestProject.Core;

namespace TestProject.Extentions
{
    public static class ElementExtentions
    {
        public static string GetCssColor(this WebElement element)
        {
            return element.WrappedElement.GetCssValue("background-color");
        }

    }
}
