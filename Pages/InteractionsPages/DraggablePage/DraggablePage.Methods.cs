using TestProject.Core;
using TestProject.Pages;

namespace DemoQA.Pages.InteractionsPages.DraggablePage
{
    public partial class DraggablePage : BasePage
    {
        public DraggablePage(WebDriver driver) : base(driver)
        {
        }


        public override string PageUrl => "http://www.demoqa.com/dragabble";

    }
}
