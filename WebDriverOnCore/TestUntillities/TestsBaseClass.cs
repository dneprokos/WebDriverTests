using NUnit.Framework;
using WebDriverOnCore.LoggerManager;
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
            NLogManager.LogMessage.Info("Test fixture setup was started");
            Driver.Start();
            NLogManager.LogMessage.Info("Test fixture setup was finished");
        }

        [SetUp]
        protected virtual void TestSetup()
        {
            NLogManager.LogMessage.Info("Test setup was started");
            navigation = new NavigationSteps();
            NLogManager.LogMessage.Info("Test fixture setup was finished");
        }

        [TearDown]
        protected virtual void TestTearDown()
        {
            NLogManager.LogMessage.Info("Test tear down was started");

            NLogManager.LogMessage.Info("Test tear down was finished");
        }

        [OneTimeTearDown]
        protected virtual void TestFixtureTearDown()
        {
            NLogManager.LogMessage.Info("Test fixture tear down was started");
            Driver.CurrentBrowser.Quit();
            NLogManager.LogMessage.Info("Test fixture tear down was finished");
        }
    }
}
