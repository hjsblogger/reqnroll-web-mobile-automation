using OpenQA.Selenium;
using Reqnroll;

namespace selenium_4.Support
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
            var driver = DriverFactory.CreateDriver(scenarioName);
            _scenarioContext["driver"] = driver;

            /* This can be further optimized to fetch page URL from a JSON or XML */
            driver.Navigate().GoToUrl("https://ecommerce-playground.lambdatest.io/");
        }

        [AfterScenario]
        public void tearDown()
        {
            var platform = Environment.GetEnvironmentVariable("EXEC_PLATFORM")?.ToLower()
                    ?? "local";

            if (_scenarioContext.TryGetValue("driver", out IWebDriver driver))
            {
                if (platform == "cloud")
                {
                    if (_scenarioContext.TestError == null)
                    {
                        ((IJavaScriptExecutor)driver).ExecuteScript(
                            "lambda-status=passed"
                        );
                    }
                    else
                    {
                        ((IJavaScriptExecutor)driver).ExecuteScript(
                            "lambda-status=failed"
                        );
                    }
                }
                driver.Quit();
            }
        }
    }
}

