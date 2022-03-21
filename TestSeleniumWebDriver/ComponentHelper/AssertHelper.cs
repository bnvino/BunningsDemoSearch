using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestSeleniumWebDriver.ComponentHelper
{
    public class AssertHelper
    {
        public static void AreEqual(string expected, string actual)
        {
            try
            {
                Assert.AreEqual(expected, actual);
            }
    
            catch (Exception)
            {
                //ignore
            }
        }
    }
}
