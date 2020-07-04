using NUnit.Framework;
using TestProject.Pages;

namespace DemoQA.Pages.InteractionsPages.DraggablePage
{
    public partial class DraggablePage : BasePage
    {
        
        public void AssertLocations(double maxValue , double actualValue,double delta ) 
        {
            Assert.AreEqual(maxValue, actualValue, delta);
        
        
        
        
        }



    }
}
