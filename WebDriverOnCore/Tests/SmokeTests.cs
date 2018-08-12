using FluentAssertions;
using NUnit.Framework;
using System.Linq;
using WebDriverOnCore.PageObjects;
using WebDriverOnCore.TestsData;
using WebDriverOnCore.TestsInit;
using WebDriverOnCore.TestUntillities;
using WebDriverOnCore.WebDriver;

namespace WebDriverOnCore
{
    public class SmokeTests: TestsBaseClass
    {
        CommonPagesElementsSteps commonSteps;

        protected override void TestSetup()
        {
            base.TestSetup();
            commonSteps = new CommonPagesElementsSteps();
            navigation.OpenWebSiteOnMainPage();
        } 

        [Test]
        [Category("Smoke")]
        [Description("Test asserts Football.ua site is available")]
        public void FootballUa_AssertWebSiteIsAvailable()
        {           
            DriverInitialize.Browser.Url.Should().Be(TestSettings.BaseUrl);
            DriverInitialize.Browser.Title.Should().Be(ExpectedValues.MainPageHeadTitle);
        }

        [Test]
        [Category("Smoke")]
        [Description("Test asserts football football banner is present")]
        public void FootballUa_AssertFooterElementsPresent()
        {
            commonSteps.HeaderMenu.HeaderMain.Should().NotBeNull();
            commonSteps.HeaderMenu.HeaderTopBanner.Should().NotBeNull();
        }

        [Test]
        [Category("Smoke")]
        [Description("Test asserts Football.ua site is available")]
        public void FootballUa_AssertAllCarouselMenuPresent()
        {
            commonSteps.GetHeaderNavigationMenuNames().Should().BeEquivalentTo(ExpectedValues.HeaderMenuItemsList.Select(s =>s.ToLower()));
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
        public void FootballUa_SwitchToAnotherMenu(string menuName)
        {
            commonSteps.GetHeaderNavigationMenuWithName(menuName).Click();
            DriverInitialize.Browser.Url.Should().Be(ExpectedValues.PageNameUrlDictionary[menuName]);
        }
    }
}