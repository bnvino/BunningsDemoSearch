using System;

namespace TestSeleniumWebDriver.CustomException
{
    public class NoSuitableFound : Exception
    {
        public NoSuitableFound(string msg) : base(msg)
        {

        }
    }
}
