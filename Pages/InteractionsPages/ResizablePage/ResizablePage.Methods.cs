using TestProject.Core;
using TestProject.Pages;

namespace DemoQA.Pages.InteractionsPages.ResizablePage
{
    public partial class ResizablePage : BasePage
    {

        public ResizablePage(WebDriver driver):base(driver)
        {


        }

        public override string PageUrl => "http://www.demoqa.com/resizable";

    }
}
