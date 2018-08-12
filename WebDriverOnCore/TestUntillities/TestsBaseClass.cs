using NUnit.Framework;
using WebDriverOnCore.WebDriver;
using WebDriverOnCore.WebSiteNavigation;

namespace WebDriverOnCore.TestUntillities
{
    public class TestsBaseClass
    {
        protected NavigationSteps navigation;

        [OneTimeSetUp]
        protected virtual void TestFixtureSetUp()
        {
            DriverInitialize.Start();
            navigation = new NavigationSteps();
        }

        [SetUp]
        protected virtual void TestSetup()
        {

        }

        [TearDown]
        protected virtual void TestTearDown()
        {

        }

        [OneTimeTearDown]
        protected virtual void TestFixtureTearDown()
        {
            DriverInitialize.Browser.Quit();
        }
    }
}
