using OpenQA.Selenium;
using TestProject.Core;
using TestProject.Pages;

namespace DemoQA.Pages.InteractionsPages.DraggablePage
{
    public partial class DraggablePage : BasePage
    {
        public WebElement DraggBox => Driver.FindElement(By.Id("dragBox"));


        public WebElement AxisRestricted => Driver.FindElement(By.XPath("//*[@id='draggableExample-tab-axisRestriction']"));


        public WebElement OnlyX_Box => Driver.FindElement(By.XPath("//*[@id='restrictedX']"));


        public WebElement ContainerRestrictedButton => Driver.FindElement(By.XPath("//a[@id='draggableExample-tab-containerRestriction']"));

        public WebElement TextInBox => Driver.FindElement(By.XPath("//span[@class='ui-widget-header ui-draggable ui-draggable-handle']"));
        public WebElement BoxRestrictingText => Driver.FindElement(By.XPath("//div[@id='draggableExample-tabpane-containerRestriction']//div[2]"));





    }
}
