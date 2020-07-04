
using TestProject.Core;

namespace TestProject.Pages.ElementsPage
{
    public partial class RadioButtons : BasePage
    {
        public  RadioButtons(WebDriver driver):base(driver)
        {
                
        }

        public override string PageUrl => "http://www.demoqa.com/radio-button";
    }




}
