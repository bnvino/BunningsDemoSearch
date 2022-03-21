using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using TestSeleniumWebDriver.BaseClasses;
using TestSeleniumWebDriver.Settings;
using TestSeleniumWebDriver.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSeleniumWebDriver.PageObject
{
    public class ResultsPage : BaseClass
    {
        #region WebElement
        private IWebDriver driver;

        #endregion



        public ResultsPage(IWebDriver _driver)
        {
            this.driver = _driver;
            PageFactory.InitElements(ObjectRepository.Driver, this);
        }


          #region Actions

        public void verifyMessageValid(string message,string item)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//p[contains(text(),'" + message + "')]"))); 
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//span[contains(text(),'" + item + "')]")));

        }

        public void verifyMessageInValid(string message, string item)
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//p[contains(text(),'" + message + "')]")));
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//p[contains(text()[2],'" + item + "')]")));

        }


        #endregion


        #region Navigation

        #endregion
    }
}
