using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace GoogleSearchTest.Pages;

public class MainPage
{
    private const int ExplicitWaitTimeout = 5;

    private readonly IWebDriver _driver;

    public MainPage(IWebDriver driver)
    {
        _driver = driver;
    }

    private IWebElement AgreeButton => _driver.FindElement(By.XPath("//button/div[text()='I agree']"));

    // Will do the same, but less readable and understandable
    // private IWebElement AgreeButton => _driver.FindElement(By.CssSelector("div.VDity>button:last-child>div"));

    private IWebElement SearchField => _driver.FindElement(By.Name("q"));
    private IWebElement ResultsPanel => _driver.FindElement(By.Id("result-stats"));
    private IWebElement SearchButton => _driver.FindElement(By.Name("btnK"));

    public void ClickIAgreeButton() => AgreeButton.Click();

    public void ClickInSearchField() => SearchField.Click();

    public void EnterSearchText(string searchText)
    {
        SearchField.SendKeys(searchText);
    }

    public void ClickOnSearchButton()
    {
        WaitElementBeClickable(_driver, SearchButton);
        SearchButton.Click();
    }

    public bool IsResultsPanelDisplayed()
    {
        return ResultsPanel.Displayed;
    }

    public string GetResultsPanelText()
    {
        return ResultsPanel.Text;
    }

    private static void WaitElementBeClickable(IWebDriver webDriver, IWebElement webElement)
    {
        new WebDriverWait(webDriver, TimeSpan.FromSeconds(ExplicitWaitTimeout))
            .Until(ExpectedConditions.ElementToBeClickable(webElement));
    }
}