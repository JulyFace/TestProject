using OpenQA.Selenium;
using TestProject.Core;

namespace TestProject.Pages.HomePage
{
    public partial class HomePage : BasePage
    {



        public WebElement HomePageSectionsButton(string sectionName) =>
            Driver.FindElement(By.XPath($"//*[normalize-space(text())='{sectionName}']/ancestor::div[contains(@class, 'top-card')]"));




    }
}
