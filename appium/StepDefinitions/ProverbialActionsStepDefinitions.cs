using NUnit.Framework;
using Reqnroll;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace ReqnrollAppium.StepDefinitions
{
    [Binding]
    public class ProverbialActionsStepDefinitions
    {
        private readonly AppiumDriver _driver;

        public ProverbialActionsStepDefinitions(ScenarioContext scenarioContext)
        {
            _driver = scenarioContext["driver"] as AppiumDriver;
        }

        private IWebElement WaitAndFind(By locator)
        {
            return new WebDriverWait(_driver, TimeSpan.FromSeconds(10))
                .Until(d => d.FindElement(locator));
        }

        private IWebElement WaitAndClick(By locator, int timeout = 20)
        {
            var localWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));
            var element = (IWebElement)localWait.Until(
                ExpectedConditions.ElementToBeClickable(locator));
            Thread.Sleep(800);
            element.Click();
            return element;
        }

        /* Step Definitions */
        [When(@"I toggle the text color")]
        public void WhenIToggleTheTextColor()
        {
            Console.WriteLine("1. Text Color Change");
            var colorButton = WaitAndClick(MobileBy.Id("color"));
            Thread.Sleep(600);
            colorButton.Click();
        }

        [When(@"I change the text using the text button")]
        public void WhenIChangeTheTextUsingTheTextButton()
        {
            Console.WriteLine("2. Text Change");
            WaitAndClick(MobileBy.Id("Text"));
        }

        [When(@"I trigger the toast message")]
        public void WhenITriggerTheToastMessage()
        {
            Console.WriteLine("3. Toast");
            WaitAndClick(MobileBy.Id("toast"));
        }

        [When(@"I tap the notification button")]
        public void WhenITapTheNotificationButton()
        {
            Console.WriteLine("4. Notification");
            WaitAndClick(MobileBy.Id("notification"));
            Thread.Sleep(1500);
        }

        [When(@"I open the geolocation screen")]
        public void WhenIOpenTheGeolocationScreen()
        {
            Console.WriteLine("5. Geolocation");
            WaitAndClick(MobileBy.Id("geoLocation"));
            Thread.Sleep(3000);
        }

        [When(@"I return back to the home screen")]
        public void WhenIReturnBackToTheHomeScreen()
        {
            /* _driver.PressKeyCode(AndroidKeyCode.Back); */
            /* Reference - https://developer.android.com/reference/
            android/view/KeyEvent#KEYCODE_BACK
            */
            var args = new Dictionary<string, object>
            {
                { "command", "keyevent" },
                { "keycode", 0x4 }   // KEYCODE_BACK
            };

            _driver.ExecuteScript("lambda-adb", args);
            Thread.Sleep(800);
        }

        [When(@"I open the speed test screen")]
        public void WhenIOpenTheSpeedTestScreen()
        {
            Console.WriteLine("6. Speed Test");
            WaitAndClick(MobileBy.Id("speedTest"));
            Thread.Sleep(4000);
        }

        [When(@"I open the in-app browser")]
        public void WhenIOpenTheInAppBrowser()
        {
            Console.WriteLine("7. Browser");
            WaitAndClick(
                MobileBy.XPath(
                    "//android.widget.FrameLayout[@content-desc='Browser']" +
                    "/android.widget.FrameLayout" +
                    "/android.widget.ImageView"
                ),
                timeout: 30
            );
        }

        [When(@"I enter the url ""(.*)""")]
        public void WhenIEnterTheUrl(string urlText)
        {
            var urlField = WaitAndClick(MobileBy.Id("url"));
            urlField.SendKeys(urlText);
            Thread.Sleep(800);
            /* _driver.PressKeyCode(AndroidKeyCode.Back); */
            /* Reference - https://developer.android.com/reference/
            android/view/KeyEvent#KEYCODE_ENTER
            */
            /*
            var args = new Dictionary<string, object>
            {
                { "command", "keyevent" },
                { "keycode", 0x42 }   // KEYCODE_ENTER
            };

            _driver.ExecuteScript("lambda-adb", args);
            */
            var buttonField = WaitAndClick(MobileBy.XPath
                        ("//*[@resource-id='com.lambdatest.proverbial:id/find']"));
            buttonField.Click();
            Thread.Sleep(10000);
        }

        [Then(@"the url should be entered successfully")]
        public void ThenTheUrlShouldBeEnteredSuccessfully()
        {
            Console.WriteLine("URL Entry Check Complete");
        }
    }
}