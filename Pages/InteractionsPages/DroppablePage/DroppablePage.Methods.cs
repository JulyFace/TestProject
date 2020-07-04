using TestProject.Core;
using TestProject.Pages;

namespace DemoQA.Pages.InteractionsPages.DroppablePage
{
    public partial class DroppablePage : BasePage
    {

        public DroppablePage(WebDriver driver)
         : base(driver)
        {

        }

       public override string PageUrl => "http://demoqa.com/droppable";


    }
}
