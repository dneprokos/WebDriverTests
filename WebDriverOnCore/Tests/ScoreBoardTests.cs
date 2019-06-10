using FluentAssertions;
using NUnit.Framework;
using System.Threading;
using WebDriverOnCore.PageObjects;
using WebDriverOnCore.PageSteps;
using WebDriverOnCore.TestsData;
using WebDriverOnCore.TestUntillities;
using WebDriverOnCore.WebDriver;

namespace WebDriverOnCore.Tests
{
    public class ScoreBoardTests : TestsBaseClass
    {
        #region Class fields

        private CommonPagesElementsSteps _commonSteps;
        private ScoreboardPageSteps _scoreboardPageSteps;

        #endregion

        #region Test setup and TearDown

        protected override void TestSetup()
        {
            base.TestSetup();
            _commonSteps = new CommonPagesElementsSteps();
            _scoreboardPageSteps = new ScoreboardPageSteps();
            navigation.OpenWebSiteOnMainPage();
        }

        #endregion

        #region Tests

        [Test]
        [Category("LongRunning")]
        [TestCase("Матчи и турниры", "Англия. Премьер-лига")]
        [Ignore("Drop-down list investigation")]
        public void UserChoicesAPLmatches_OnlyAplFixturesAndResultsShown(string menuName, string tornament)
        {
            _commonSteps.GetHeaderNavigationMenuWithName(menuName).Click();
            DriverInitialize.Browser.Url.Should().Be(ExpectedValues.PageNameUrlDictionary[menuName]);

            Thread.Sleep(5000);

            _scoreboardPageSteps.SelectTornamentFromTornamentsDropDownList(tornament);

            Thread.Sleep(5000);
        }

        #endregion
    }
}
