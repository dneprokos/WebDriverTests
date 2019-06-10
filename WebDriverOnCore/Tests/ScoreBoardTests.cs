using FluentAssertions;
using NUnit.Framework;
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
        public void UserChoicesAPLmatches_OnlyAplFixturesAndResultsShown(string menuName, string tornament)
        {
            //Arrange
            _commonSteps.GetHeaderNavigationMenuWithName(menuName).Click();
            DriverInitialize.Browser.Url.Should().Be(ExpectedValues.PageNameUrlDictionary[menuName]);

            //Act
            _scoreboardPageSteps.SelectTornamentFromTornamentsDropDownList(tornament);

            //Assert
            Assert.AreEqual(tornament, _scoreboardPageSteps.GetSelectedTornamentText());
        }

        #endregion
    }
}
