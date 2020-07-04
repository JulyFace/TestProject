using TestProject.Core;
using TestProject.Pages;

namespace DemoQA.Pages.InteractionsPages.SortablePage
{
    public partial class SortablePage : BasePage
    {
        public SortablePage(WebDriver driver) : base(driver)
        {

        }

        public override string PageUrl => "http://www.demoqa.com/sortable";


    }
}
