using GoogleSearchTest.Drivers;
using GoogleSearchTest.Pages;
using NUnit.Framework;

namespace GoogleSearchTest.Steps;

[Binding]
public sealed class GoogleSearchStepDefinitions
{
    private readonly BrowserDriver _browserDriver;
    private readonly MainPage _mainPage;

    public GoogleSearchStepDefinitions(BrowserDriver browserDriver)
    {
        _browserDriver = browserDriver;
        _mainPage = new MainPage(_browserDriver.Driver);
    }

    [When(@"I open (.*)")]
    public void WhenIOpen(string url)
    {
        _browserDriver.Driver.Navigate().GoToUrl(url);
    }

    [When(@"I click I Agree button")]
    public void WhenIClickIAgreeButton()
    {
        _mainPage.ClickIAgreeButton();
    }

    [When(@"I click in Search field")]
    public void WhenIClickInSearchField()
    {
        _mainPage.ClickInSearchField();
    }

    [When(@"I type (.*) into Search field")]
    public void WhenITypeIntoSearchField(string text)
    {
        _mainPage.EnterSearchText(text);
    }

    [When(@"I click Search button")]
    public void WhenIClickSearchButton()
    {
        _mainPage.ClickOnSearchButton();
    }

    [Then(@"I see About N results panel is displayed")]
    public void ThenISeeAboutNResultsPanelIsDisplayed()
    {
        Assert.That(_mainPage.IsResultsPanelDisplayed, Is.True, _mainPage.GetResultsPanelText);
        StringAssert.IsMatch(@"About \d+,\d+ results \(\d+\.\d+ seconds\)", _mainPage.GetResultsPanelText());
    }
}