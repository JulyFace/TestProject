using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using TestProject.Core;
using TestProject.Pages;

namespace DemoQA.Pages.InteractionsPages.SortablePage
{
    public partial class SortablePage : BasePage
    {
        //GRID

        public WebElement SelectGrid => Driver.FindElement(By.XPath("//*[@id='demo-tab-grid']"));

        public WebElement PositionONE => Driver.FindElement(By.CssSelector("#demo-tabpane-grid>div>div>div:nth-child(1)"));

        public WebElement PositionTWO => Driver.FindElement(By.CssSelector("#demo-tabpane-grid>div>div>div:nth-child(3)"));


        public WebElement PositionTHREE => Driver.FindElement(By.CssSelector("#demo-tabpane-grid>div>div>div:nth-child(3)"));






        public List<WebElement> ListOfOptions => Driver.FindElements(By.XPath("//div[@id='demo-tabpane-list']//div[contains(@class, 'list-group-item')]")).ToList();



    }
}
