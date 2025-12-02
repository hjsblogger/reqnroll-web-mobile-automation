using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;
/* Removal of mentions of SpecFlow */
/*
using SpecFlow.Actions.Selenium;
using TechTalk.SpecFlow;
*/
using FluentAssertions;
using Reqnroll.Actions.Selenium;

/* No changes in the Step Definitions */
[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(4)]
namespace Reqnroll.StepDefinitions
{
    [Binding]
    public class AddItemsToCartStepDefinitions
    {
        private readonly IBrowserInteractions _browserInteractions;
        public AddItemsToCartStepDefinitions(IBrowserInteractions browserInteractions)
        {
            _browserInteractions = browserInteractions;
        }

        [BeforeScenario]
        public void SetUp()
        {
            _browserInteractions.GoToUrl("https://ecommerce-playground.lambdatest.io/");
        }

        [Given(@"I select the (.*) category")]
        public void GivenISelectTheCategory(string category)
        {
            _browserInteractions.WaitAndReturnElement(
                By.XPath("(//div[@class='dropdown search-category']/button[@type='button'])[1]")).Click();
            _browserInteractions.WaitAndReturnElement(
                By.XPath($"(//a[text()='{category}'])[1]")).Click();
        }

        [When(@"I search for (.*)")]
        public void WhenISearchForProduct(string product)
        {
            _browserInteractions.WaitAndReturnElement(
                By.XPath("(//input[@name='search'])[1]")).SendKeys(product);
            _browserInteractions.WaitAndReturnElement(
                By.XPath("(//button[normalize-space()='Search'])[1]")).Click();
        }

        [Then(@"I should get (.*) results for (.*)")]
        public void ThenIShouldGetResults(int itemsCount, 
                    string product)
        {
            int actualCount = _browserInteractions.WaitAndReturnElements(
                By.XPath($"//div[@class='row']//div[@class='carousel-item active']/img[@alt='{product}']")).Count();

            /* NUnit 3 */
            /* Assert.AreEqual(itemsCount, actualCount); */

            /* NUnit 4 */
            Assert.That(actualCount, Is.EqualTo(itemsCount));
        }
    }
}