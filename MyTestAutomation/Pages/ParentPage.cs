using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MyTestAutomation.Pages
{
    abstract public class ParentPage
    {
        public IWebDriver driver;

        public ParentPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
            PageFactory.InitElements(webDriver, this);

        }
    }
}
