using OpenQA.Selenium;
using TestSeleniumWebDriver.Interfaces;

namespace TestSeleniumWebDriver.Settings
{
    public class ObjectRepository
    { 
        public static IConfig Config { get; set; }
        public static IWebDriver Driver { get; set; }

    }
}
