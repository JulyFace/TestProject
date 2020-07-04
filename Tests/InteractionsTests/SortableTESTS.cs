using DemoQA.Pages.InteractionsPages.SortablePage;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TestProject.Tests;

namespace InteractionsTests
{
    [TestFixture]
    public class SortableTESTS : BaseTest
    {
        SortablePage _sortablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _sortablePage = new SortablePage(Driver);
           // Driver.Manage().Window.Maximize();
            _sortablePage.NavigateTo();


        }


        [TearDown]
        public void TearDown()
        {
            Driver.Quit();

        }

        [Test]
        public void SortBoxex_whenDropBoxOnOtherBox()
        {
            _sortablePage.SelectGrid.Click();


            Builder.ClickAndHold(_sortablePage.PositionONE.WrappedElement)
                .MoveToElement(_sortablePage.PositionTHREE.WrappedElement).Release().Perform();

            _sortablePage.AssertBoxesLocations("Two", _sortablePage.PositionONE.Text);
            _sortablePage.AssertBoxesLocations("One", _sortablePage.PositionTHREE.Text);

        }



        [Test]
        public void ChecksRowsIsOnRightPositionI_when_ChangeTwoRowsPositions()
        {
            var firstRowBefore = _sortablePage.ListOfOptions[0].Text;
            var lastRowBefore = _sortablePage.ListOfOptions[5].Text;


            Builder.ClickAndHold(_sortablePage.ListOfOptions[0].WrappedElement)
                    .MoveToElement(_sortablePage.ListOfOptions[5].WrappedElement)
                    .Release()
                    .ClickAndHold(_sortablePage.ListOfOptions[0].WrappedElement)
                    .MoveToElement(_sortablePage.ListOfOptions[5].WrappedElement)
                    .Release()
                    .Perform();


            _sortablePage.AssertBoxesLocations(firstRowBefore, _sortablePage.ListOfOptions[4].Text);
            _sortablePage.AssertBoxesLocations(lastRowBefore, _sortablePage.ListOfOptions[3].Text);

        }





    }
}



