using TestSeleniumWebDriver.Settings;

namespace TestSeleniumWebDriver.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateToUrl(string Url)//string Url
        {
            ObjectRepository.Driver.Navigate().GoToUrl(Url);
            //NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite()); use this function when the url is given in the config file
        }
    }
}
