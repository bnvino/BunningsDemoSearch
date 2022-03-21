using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using TestSeleniumWebDriver.BaseClasses;
using TestSeleniumWebDriver.Settings;
using TestSeleniumWebDriver.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSeleniumWebDriver.PageObject
{
    public class BunningsHomePage : BaseClass
    {
        #region WebElement
        private IWebDriver driver;

        private By searchBox = By.Id("custom-css-outlined-input");
        private By searchButton = By.Id("crossIcon");

        #endregion

        public BunningsHomePage(IWebDriver _driver)
        {
            this.driver = _driver;
            PageFactory.InitElements(ObjectRepository.Driver, this);
        }


        #region Actions

        public void ConfirmHomePageTitle()
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            Assert.AreEqual("Australia DIY, Garden & Hardware Store - Bunnings Australia", ObjectRepository.Driver.Title );
            //Assert.IsTrue(GenericHelper.IsElementPresent(DashBoard));
        }

        public void enterItemForSearch(string item)
        {
            TextBoxHelper.TypeInTextBox(searchBox, item);

        }

        public void clickSearchButton()
        {
            ButtonHelper.ClickButton(searchButton);

        }

        public void verifyMessageOnSearch(string message)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//p[contains(text(),'" + message + "')]")));

        }

        #endregion


        #region Navigation
        #endregion
    }
}
