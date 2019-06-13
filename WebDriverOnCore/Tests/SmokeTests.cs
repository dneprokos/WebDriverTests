using FluentAssertions;
using NUnit.Framework;
using System.Linq;
using WebDriverOnCore.LoggerManager;
using WebDriverOnCore.PageObjects;
using WebDriverOnCore.TestsData;
using WebDriverOnCore.TestsInit;
using WebDriverOnCore.TestUntillities;
using WebDriverOnCore.WebDriver;

namespace WebDriverOnCore
{
    public class SmokeTests: TestsBaseClass
    {
        #region Test fields

        private CommonPageSteps _commonSteps;

        #endregion

        #region Tests setup and tear down

        protected override void TestSetup()
        {
            base.TestSetup();

            NLogManager.LogMessage.Info("Smoke tests setup was started");
            _commonSteps = new CommonPageSteps();            
            navigation.OpenWebSiteOnMainPage();
            NLogManager.LogMessage.Info("Smoke tests setup was finished");
        }

        #endregion

        #region Tests

        [Test]
        [Category("Smoke")]
        [Description("Test asserts Football.ua site is available")]
        public void AssertWebSiteIsAvailable()
        {           
            Driver.CurrentBrowser.Url.Should().Be(TestSettings.BaseUrl);
            Driver.CurrentBrowser.Title.Should().Be(ExpectedValues.MainPageHeadTitle);
        }

        [Test]
        [Category("Smoke")]
        [Description("Test asserts football football banner is present")]
        public void AssertFooterElementsPresent()
        {
            _commonSteps.HeaderMenu.HeaderMain.Should().NotBeNull();
            _commonSteps.HeaderMenu.HeaderTopBanner.Should().NotBeNull();
        }

        [Test]
        [Category("Smoke")]
        [Description("Test asserts Football.ua site is available")]
        public void AssertAllCarouselMenuPresent()
        {
            _commonSteps.GetHeaderNavigationMenuNames().Should().BeEquivalentTo(ExpectedValues.HeaderMenuItemsList.Select(s =>s.ToLower()));
        }

        [Test]
        [Category("Smoke")]
        [TestCase("Новости")]
        [TestCase("Матчи и турниры")]
        [TestCase("Видео")]
        [TestCase("Фотогалереи")]
        [TestCase("Футбол на ТВ")]
        [TestCase("Конференции")]
        [Description("Test asserts Football.ua site is available")]
        public void UserSwitchesToCarouselMenu_UserShouldBeRedirectedToCorrespondingPage(string menuName)
        {
            _commonSteps.GetHeaderNavigationMenuWithName(menuName).Click();
            Driver.CurrentBrowser.Url.Should().Be(ExpectedValues.PageNameUrlDictionary[menuName]);
        }

        #endregion
    }
}