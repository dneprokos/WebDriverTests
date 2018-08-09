using FluentAssertions;
using NUnit.Framework;
using WebDriverOnCore.PageObjects;
using WebDriverOnCore.TestsData;
using WebDriverOnCore.TestsInit;
using WebDriverOnCore.TestUntillities;
using WebDriverOnCore.WebDriver;

namespace WebDriverOnCore
{
    public class SmokeTests: TestsBaseClass
    {
        [Test]
        [Category("Smoke")]
        [Description("Test asserts Football.ua site is available")]
        public void FootballUa_AssertWebSiteIsAvailable()
        {
            navigation.OpenWebSiteOnMainPage();
            TestSettings.BaseUrl.Should().Be(DriverInitialize.Browser.Url);
            ExpectedValues.MainPageHeadTitle.Should().Be(DriverInitialize.Browser.Title);
        }

        [Test]
        [Category("Smoke")]
        [Description("Test asserts Football.ua site is available")]
        public void FootballUa_AssertFooterElementsPresent()
        {
            navigation.OpenWebSiteOnMainPage();
            var commonSteps = new CommonPagesElementsSteps();
            commonSteps.HeaderMenu.HeaderMain.Should().NotBeNull();
            commonSteps.HeaderMenu.HeaderTopBanner.Should().NotBeNull();
        }
    }
}