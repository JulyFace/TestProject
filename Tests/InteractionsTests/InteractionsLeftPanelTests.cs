using NUnit.Framework;
using OpenQA.Selenium;
using TestProject.Extentions;
using TestProject.Pages.HomePage;
using TestProject.Pages.LeftPanel;
using TestProject.Tests;

namespace InteractionsTests
{
    public class InteractionsLeftPanelTests : BaseTest
    {

        private HomePage _homePage;
        private LeftPanel _leftPanelPage;



        [SetUp]
        public void SetUp()
        {

            Initialize();
            _homePage = new HomePage(Driver);
            _leftPanelPage = new LeftPanel(Driver);
            _homePage.NavigateTo();
            _homePage.HomePageSectionsButton("Interactions").Click();

        }

        [Test]
        [TestCase("Sortable")]
        [TestCase("Selectable")]
        [TestCase("Resizable")]
        [TestCase("Droppable")]
        [TestCase("Dragabble")]
        public void InteractionsSectionsTest_when_ClickOn(string subName)
        {

            var dropDownNavigation = Driver.FindElement(By.XPath($"//*[normalize-space(text())='{subName}']"));

            Driver.ScrollTo(dropDownNavigation);
            _leftPanelPage.SubMenu(subName).Click();


            _leftPanelPage.AssertPageTitle(subName);


        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }



    }
}
