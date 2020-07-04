using OpenQA.Selenium;
using TestProject.Core;

namespace TestProject.Extentions
{
    public static class DriverExtentions
    {

        public static void ScrollTo(this WebDriver driver, WebElement element)
        {

            ((IJavaScriptExecutor)driver.WrappedDriver).ExecuteScript("arguments[0].scrollIntoView(true);", element.WrappedElement);


        }


    }
}
