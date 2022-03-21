using System;
using System.Linq;
using OpenQA.Selenium;
using TestSeleniumWebDriver.Settings;

namespace TestSeleniumWebDriver.ComponentHelper
{
    public class GenericHelper
    {
        private static Random random = new Random();
        private static Random randomNumber = new Random();

        public static bool IsElementPresent(By Locator)
        {
            try
            {
                return ObjectRepository.Driver.FindElements(Locator).Count == 1;
            }
            catch(Exception)
            {
                return false;
            }
            
        }
        public static IWebElement GetElement(By Locator)
        {
            if (IsElementPresent(Locator))
                return ObjectRepository.Driver.FindElement(Locator);
            else
                throw new NoSuchElementException("Element Not Found : " + Locator.ToString());
        }
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZsbcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomNumber(int length)
        {
            const string chars = "1234567890";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[randomNumber.Next(s.Length)]).ToArray());
        }
    }
}
