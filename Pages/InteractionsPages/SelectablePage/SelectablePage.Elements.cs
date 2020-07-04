using OpenQA.Selenium;
using TestProject.Core;
using TestProject.Pages;

namespace DemoQA.Pages.InteractionsPages.SelectablePage
{
    public partial class SelectablePage : BasePage
    {
        public WebElement FirstRow => Driver.FindElement(By.XPath("//li[contains(text(),'Cras justo odio')]"));

        public WebElement Header => Driver.FindElement(By.XPath("//div[@class='main-header']"));

    }
}



