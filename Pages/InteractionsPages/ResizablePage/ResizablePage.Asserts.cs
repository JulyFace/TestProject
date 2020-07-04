using NUnit.Framework;
using TestProject.Pages;

namespace DemoQA.Pages.InteractionsPages.ResizablePage
{
    public partial class ResizablePage : BasePage
    {
        public void AssertLocation(double expected, double actual)  
        {
            Assert.AreNotEqual(expected,  actual);


        }
    }
}
