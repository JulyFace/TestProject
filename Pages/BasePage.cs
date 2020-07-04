using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TestProject.Core;

namespace TestProject.Pages
{
    public abstract class BasePage
    {
        public BasePage(WebDriver driver)
        {
            Driver = driver;
            Driver.WrappedDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        public virtual string PageUrl { get; }

        public WebDriver Driver { get; }

        public WebDriverWait Wait { get; }

        public void NavigateTo()
        {
            Driver.Navigate(PageUrl);
        }

        

        public void WaitForLoad(int timeoutSec = 15)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            WebDriverWait wait = new WebDriverWait(Driver.WrappedDriver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }
    }
}
