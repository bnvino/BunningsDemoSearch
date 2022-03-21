using TechTalk.SpecFlow;
using TestSeleniumWebDriver.ComponentHelper;
using TestSeleniumWebDriver.PageObject;
using TestSeleniumWebDriver.Settings;

namespace TestSeleniumWebDriver.StepDefinition
{
    [Binding]
    public sealed class BunningsFeature
    {
        private BunningsHomePage bHPage = new BunningsHomePage(ObjectRepository.Driver);
        private ResultsPage bRPage = new ResultsPage(ObjectRepository.Driver);

        [Given(@"user navigates to the url ""(.*)""")] 
        public void GivenUserIsAtHomePageWitUrl(string url)
        {
            NavigationHelper.NavigateToUrl(url);
        }

        [Then(@"the company title should be visible")]
        public void GivenTheCompanyTitleShouldBeVisible()
        {
            bHPage.ConfirmHomePageTitle();
        }

        [When(@"the user search for ""(.*)"" item")]
        public void WhenTheUserSearchForItem(string itemName)
        {
            bHPage.enterItemForSearch(itemName);
        }

        [When(@"verify the ""(.*)"" message is displayed in the search")]
        public void WhenVerifyTheCorrectMessageIsDisplayed(string message)
        {
            bHPage.verifyMessageOnSearch(message);
        }


        [When(@"click on search button")]
        public void WhenClickOnSearchButton()
        {
            bHPage.clickSearchButton();
        }

        [When(@"verify the invalid item message ""(.*)"" ""(.*)"" is displayed")]
        public void WhenVerifyTheInvalidItemMessageIsDisplayed(string message, string item)
        {
            bRPage.verifyMessageInValid(message, item);
        }

        [When(@"verify the valid item message ""(.*)"" ""(.*)"" displayed")]
        public void WhenVerifyTheValidItemMessageDisplayed(string message, string item)
        {
            bRPage.verifyMessageValid(message, item);
        }



    }
}
