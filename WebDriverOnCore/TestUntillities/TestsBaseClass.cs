using NUnit.Framework;
using WebDriverOnCore.WebDriver;
using WebDriverOnCore.WebSiteNavigation;

namespace WebDriverOnCore.TestUntillities
{
    public class TestsBaseClass
    {
        protected NavigationSteps navigation;

        [OneTimeSetUp]
        public virtual void TestFixtureSetUp()
        {
            DriverInitialize.Start();
            navigation = new NavigationSteps();
        }

        [OneTimeTearDown]
        public virtual void TestFixtureTearDown()
        {
            DriverInitialize.Browser.Quit();
        }
    }
}
