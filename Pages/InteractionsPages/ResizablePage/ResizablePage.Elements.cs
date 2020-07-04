using OpenQA.Selenium;
using TestProject.Core;
using TestProject.Pages;

namespace DemoQA.Pages.InteractionsPages.ResizablePage
{
    public partial class ResizablePage : BasePage
    {
        public WebElement ResizableBoxHandle => Driver.FindElement(By.XPath("//div[@id='resizableBoxWithRestriction']//span[@class='react-resizable-handle react-resizable-handle-se']"));


        public WebElement SecondResizableBox => Driver.FindElement(By.XPath("//div[@id='resizable']//span[@class='react-resizable-handle react-resizable-handle-se']"));


        public WebElement FirstBoxSize => Driver.FindElement(By.XPath("//div[@id='resizableBoxWithRestriction']"));


    }
}
