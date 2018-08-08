using NUnit.Framework;
using OpenQA.Selenium;
using WebDriverOnCore.WebDriver;

namespace WebDriverOnCore.TestUntillities
{
    public class TestsBaseClass
    {
        protected IWebDriver WebDriver { get; set; }

        [OneTimeSetUp]
        public virtual void SetUp()
        {
            WebDriver = DriverInitialize.GetWebDriver();
        }

        [OneTimeTearDown]
        public virtual void TearDown()
        {
            WebDriver.Quit();
        }
    }
}
