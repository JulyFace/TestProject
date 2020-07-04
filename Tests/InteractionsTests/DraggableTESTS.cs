using DemoQA.Pages.InteractionsPages.DraggablePage;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TestProject.Tests;

namespace InteractionsTests
{
    [TestFixture]
    public class DraggableTESTS : BaseTest
    {
        private DraggablePage _draggablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _draggablePage = new DraggablePage(Driver);

            _draggablePage.NavigateTo();
            System.Drawing.Size windowSize = new System.Drawing.Size(1280, 768);   
            Driver.WrappedDriver.Manage().Window.Size = windowSize;

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();

        }

        [Test]
        public void PossitionIsChanged_when_BoxIsMoved_SIMPLE()
        {
            var boxPositionBefore = _draggablePage.DraggBox.Location;

            Builder.DragAndDropToOffset(_draggablePage.DraggBox.WrappedElement, 100, 100).Perform();

            Assert.AreNotEqual(boxPositionBefore, _draggablePage.DraggBox.Location);

        }

        [Test]
        public void Y_RestrictedMovement_when_DownMoveIsSet_AXISrestricted()
        {
            _draggablePage.AxisRestricted.Click();

            var YpositionBefore = _draggablePage.OnlyX_Box.Location.Y;

            Builder.DragAndDropToOffset(_draggablePage.OnlyX_Box.WrappedElement, 100, 100).Perform();

            Assert.AreEqual(YpositionBefore, _draggablePage.OnlyX_Box.Location.Y);


        }


        [Test]
        public void TextRestrictedByContainer_when_MovemenToPointOutsideTheContainerIsSet()
        {
            _draggablePage.ContainerRestrictedButton.Click();
            

            Builder.DragAndDropToOffset(_draggablePage.TextInBox.WrappedElement, 25, 25).Perform();


            _draggablePage.AssertLocations(373d, _draggablePage.TextInBox.Location.X, 3);
            _draggablePage.AssertLocations(560d, _draggablePage.TextInBox.Location.Y, 3);


             




        }

    }
}
