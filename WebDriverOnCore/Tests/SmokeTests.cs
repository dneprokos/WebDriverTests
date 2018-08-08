using NUnit.Framework;
using System;
using System.Diagnostics;
using WebDriverOnCore.TestUntillities;

namespace WebDriverOnCore
{
    public class SmokeTests: TestsBaseClass
    {
        private readonly string tempBaseUrl = "http://football.ua/";

        [Test]
        [Category("Smoke")]
        [Description("Test asserts Football.ua site is available")]
        public void FootballUa_AssertWebSiteIsAvailable()
        {           
            WebDriver.Navigate().GoToUrl(tempBaseUrl);
            Assert.AreEqual(tempBaseUrl, WebDriver.Url);
        }
    }
}