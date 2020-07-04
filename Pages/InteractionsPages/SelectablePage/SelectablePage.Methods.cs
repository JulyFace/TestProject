using TestProject.Core;
using TestProject.Pages;

namespace DemoQA.Pages.InteractionsPages.SelectablePage
{
    public partial class SelectablePage : BasePage
    {
        public SelectablePage(WebDriver driver): base(driver)
        {
                
        }

        public override string PageUrl => "http://www.demoqa.com/selectable";
    }
}
