using GoogleSearchTest.Drivers;
using OpenQA.Selenium.Chrome;

namespace GoogleSearchTest.Hooks
{
    [Binding]
    public class Hooks
    {
        private const int ImplicitWaitTimeout = 3;

        private readonly BrowserDriver _browserDriver;

        public Hooks(BrowserDriver browserDriver) => _browserDriver = browserDriver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _browserDriver.Driver = new ChromeDriver();
            _browserDriver.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ImplicitWaitTimeout);
            _browserDriver.Driver.Manage().Cookies.DeleteAllCookies();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _browserDriver.Driver.Quit();
        }
    }
}