
using TestProject.Core;

namespace TestProject.Pages.HomePage
{
    public partial class HomePage : BasePage

    {


        public HomePage(WebDriver driver) : base(driver)
        {

        }

        public override string PageUrl => "http://demoqa.com";




    }
}
