using NUnit.Framework;
using TestProject.Pages;

namespace DemoQA.Pages.InteractionsPages.SortablePage
{
    public partial class SortablePage : BasePage
    { 

        public void AssertBoxesLocations(string expected ,string actual) 
        {
            Assert.AreEqual(expected, actual);

        }

        public void AssertRowsLocations(double expected, double actual)
        {
            Assert.AreEqual(expected, actual);

        }

       
    }
}
