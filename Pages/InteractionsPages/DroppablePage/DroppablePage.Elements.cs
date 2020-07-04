using OpenQA.Selenium;
using TestProject.Core;
using TestProject.Pages;

namespace DemoQA.Pages.InteractionsPages.DroppablePage
{
    public partial class DroppablePage : BasePage
    {


        //Simple
        public WebElement DragMeBox => Driver.FindElement(By.Id("draggable"));

        public WebElement DropMeBox => Driver.FindElement(By.Id("droppable"));


        // Accept
        public WebElement AcceptDroppable => Driver.FindElement(By.XPath("//*[@id='droppableExample-tab-accept']"));

        public WebElement NotAcceptableBox => Driver.FindElement(By.XPath("//*[@id='notAcceptable']"));

        public WebElement TargetBox => Driver.FindElement(By.XPath("//div[@id='acceptDropContainer']//div[@id='droppable']"));



        // Revert 
        public WebElement RevertDroppable => Driver.FindElement(By.XPath("//*[@id='droppableExample-tab-revertable']"));

        public WebElement NotRevertBox => Driver.FindElement(By.XPath("//*[@id='notRevertable']"));

        public WebElement TargetBoxREVERT => Driver.FindElement(By.XPath("//div[@id='revertableDropContainer']//div[@id='droppable']"));





    }
}
