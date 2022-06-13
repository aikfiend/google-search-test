## QA Automation Lead Technical Assessment

Company: [andagon](https://www.andagon.com)

Products: [aqua](https://aqua-cloud.io), [DrivT](https://drivt.net)

### Stack and Tools

<a href="https://docs.microsoft.com/dotnet/csharp" title="C#">
   <img src="https://raw.githubusercontent.com/aikfiend/aikfiend.github.io/master/icons/CSharp.svg" alt="C#" height="35"/>
</a>

<a href="https://nunit.org" title="NUnit">
   <img src="https://raw.githubusercontent.com/aikfiend/aikfiend.github.io/master/icons/NUnit.svg" alt="NUnit" height="35"/>
</a>

<a href="https://selenium.dev" title="Selenium WebDriver">
   <img src="https://raw.githubusercontent.com/aikfiend/aikfiend.github.io/master/icons/Selenium.svg" alt="Selenium WebDriver" height="35"/>
</a>

<a href="https://dotnet.microsoft.com" title=".NET Core">
   <img src="https://raw.githubusercontent.com/aikfiend/aikfiend.github.io/master/icons/NETCore.svg" alt=".NET Core" height="35"/>
</a>

<a href="https://specflow.org" title="Specflow">
   <img src="https://raw.githubusercontent.com/aikfiend/aikfiend.github.io/master/icons/Specflow.svg" alt="Specflow" height="35"/>
</a>

<a href="https://www.jetbrains.com/rider" title="JetBrains Rider">
   <img src="https://raw.githubusercontent.com/aikfiend/aikfiend.github.io/master/icons/Rider.svg" alt="JetBrains Rider" height="35"/>
</a>

<a href="https://visualstudio.microsoft.com" title="Microsoft Visual Studio">
   <img src="https://raw.githubusercontent.com/aikfiend/aikfiend.github.io/master/icons/VisualStudio.svg" alt="Microsoft Visual Studio" height="35"/>
</a>

### Coding Task

Create an automated e2e test for the Google Search. The test should have the following steps:

1. Open https://www.google.com

2. Type any text in the search text box

3. Click “Google Search” button

4. Verify that `About NNN results` panel is displayed

   ![About NNN results panel](https://github.com/aikfiend/github.io/raw/master/google-search-test/screenshots/AboutNResults.png "About NNN results panel")

Requirements:

- The test steps should be written in a Gherkin file ([example](https://app.specflow.org/gherkin-editor/feature/SFSIDlp8zV_ZKMEyqUREmzAT60dbPyDvbY6FBgA9-6g8W82A))

- Use [.NET Core](https://dotnet.microsoft.com) with [SpecFlow](https://specflow.org/tools/specflow) to execute the Gherkin file

- Use Selenium WebDriver ([Selenium C# Webdriver Tutorial: NUnit Example](https://www.guru99.com/selenium-csharp-tutorial.html))

- Keep code clean and try to follow [SOLID](https://simple.wikipedia.org/wiki/SOLID_(object-oriented_design)), [DRY](https://en.wikipedia.org/wiki/Don%27t_repeat_yourself), and [KISS](https://en.wikipedia.org/wiki/KISS_principle) principles where it has sense

IDE:

- [JetBrains Rider](https://www.jetbrains.com/rider)

- [Visual Studio](https://visualstudio.microsoft.com)