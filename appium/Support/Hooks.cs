using OpenQA.Selenium.Appium;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using Reqnroll;

namespace appium.Support
{
    [Binding]
    public sealed class Hooks
    {
        private readonly ScenarioContext _scenarioContext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void setUp()
        {
            /* This is to update the Test Name as the Scenario Title */
            string scenarioName = _scenarioContext.ScenarioInfo.Title;
            var driver = DriverFactory.CreateCloudAppiumDriver(scenarioName);
            _scenarioContext["driver"] = driver;
        }

        [AfterScenario]
        public void tearDown()
        {
            bool status = TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed;
            if (_scenarioContext.TryGetValue("driver", out AndroidDriver driver))
            {
                /* The test suite has passed */
                ((IJavaScriptExecutor)driver).ExecuteScript
                        ("lambda-status=" + (status ? "passed" : "failed"));
                driver.Quit();
            }
        }
    }
}

