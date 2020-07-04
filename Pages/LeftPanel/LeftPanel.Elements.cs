using OpenQA.Selenium;
using TestProject.Core;

namespace TestProject.Pages.LeftPanel
{
    public partial class LeftPanel
    {


        protected WebElement LeftPanelSection => Driver.FindElement
            (By.XPath("//*[@class='left-pannel']"));

        public WebElement InteractionsButton => LeftPanelSection.FindElement
            (By.XPath(".//*[normalize-space(text())='Interactions']"));

        public WebElement WidgetsButton => LeftPanelSection.FindElement
            (By.XPath(".//*[normalize-space(text())='Widgets']"));

        public WebElement AlertsFrameWindowsButton => LeftPanelSection.FindElement
            (By.XPath(".//*[normalize-space(text())='Alerts, Frame & Windows']"));

        public WebElement ElementsButton => LeftPanelSection.FindElement
            (By.XPath(".//*[normalize-space(text())='Elements']"));


        public WebElement SubMenu(string subName) => Driver.FindElement
            (By.XPath($"//span[contains(text(),'{subName}')]"));           

        public WebElement PageTitle => Driver.FindElement(By.ClassName("main-header"));




    }
}
