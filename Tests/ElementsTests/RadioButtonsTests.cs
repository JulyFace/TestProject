using NUnit.Framework;
using TestProject.Pages.ElementsPage;
using TestProject.Tests;

namespace ElementsTests
{
    [TestFixture]
    public class RadioButtonsTests : BaseTest
    {
        private RadioButtons _radioButtons;


        [SetUp]
        public void SetUp()
        {
            Initialize();
            _radioButtons = new RadioButtons(Driver);
            _radioButtons.NavigateTo();



        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();

        }

        [Test]
        public void Yes_RadioButtonTest()
        {
            _radioButtons.YesRadioButton.WrappedElement.Click();

            Assert.IsTrue(_radioButtons.ChoiceIndicator.WrappedElement.Text.Contains("Yes"));


        }

        [Test]
        public void Immpresive_RadioButtonTest()
        {
            _radioButtons.ImpressiveRadioButton.WrappedElement.Click();

            Assert.IsTrue(_radioButtons.ChoiceIndicator.WrappedElement.Text.Contains("Impressive"));


        }

        [Test]
        public void No_RadioButtonTest_IfItsDisabled()
        {
            Assert.IsFalse(_radioButtons.No_RadioButton.WrappedElement.Enabled);

        }

    }   

}
