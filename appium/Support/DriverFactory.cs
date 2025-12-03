using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using Reqnroll;

namespace appium.Support
{
    public static class DriverFactory
    {
        public static AndroidDriver CreateCloudAppiumDriver(string scenarioName)
        {
            string userName = Environment.GetEnvironmentVariable("LT_USERNAME") == null ? 
                            "LT_USERNAME" : Environment.GetEnvironmentVariable("LT_USERNAME");

            string accessKey = Environment.GetEnvironmentVariable("LT_ACCESS_KEY") == null ?
                            "LT_ACCESS_KEY" : Environment.GetEnvironmentVariable("LT_ACCESS_KEY");

            var gridUrl = new Uri($"https://{userName}:{accessKey}@mobile-hub.lambdatest.com/wd/hub");

            var ltOptions = new Dictionary<string, object>()
            {
                { "build", "[Appium 2.x] ReqnRoll demo on LambdaTest" },
                { "project", "Reqnroll_Appium2_Demo" },
                { "w3c", true },
                {"app", "proverbial-android"},
                { "platformName", "android" },
                { "deviceName", "Galaxy.*" },
                { "platformVersion", "14" },
                { "isRealMobile", true },
                { "autoAcceptAlerts", true },
                { "autoGrantPermissions", true },
                { "sessionName", scenarioName },
            };

            /* This can be further optimized to take different device options */
            var AppiumOptions = new AppiumOptions();
            AppiumOptions.AddAdditionalAppiumOption("LT:Options", ltOptions);

            var driver = new AndroidDriver(gridUrl, AppiumOptions);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return driver;
        }
    }
}