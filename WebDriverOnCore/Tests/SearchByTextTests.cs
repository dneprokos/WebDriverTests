using NUnit.Framework;
using WebDriverOnCore.PageObjects;
using WebDriverOnCore.PageSteps;
using WebDriverOnCore.TestUntillities;

namespace WebDriverOnCore.Tests
{
    public class SearchByTextTests : TestsBaseClass
    {
        private CommonPageSteps _commonSteps;
        private SearchResultsPageSteps _searchResultsPage;

        protected override void TestSetup()
        {
            base.TestSetup();
            _commonSteps = new CommonPageSteps();
            _searchResultsPage = new SearchResultsPageSteps();
            navigation.OpenWebSiteOnMainPage();
        }

        [Test]
        [Category("LongRunning")]
        [TestCase("APL")]
        public void UserSearchesByCriteria_SiteShouldNavigateUserToResultsPage(string searchCriteria)
        {
            //Arrange


            //Act
            _commonSteps.StartSearchBy(searchCriteria);

            //Assert
            _searchResultsPage.SearchPageShouldBeOpened(searchCriteria);
            _searchResultsPage.ShouldContainAllExpectedElements(searchCriteria);
            _searchResultsPage.SearchFieldShouldContainValue(searchCriteria);         
        }

        [Test]
        [Category("LongRunning")]
        [TestCase("testtesttesttest", "Ничего не найдено.")]
        public void UserSearchesByCriteria_NoResultsFound(string searchCriteria, string expectedText)
        {
            //Arrange

            //Act
            _commonSteps.StartSearchBy(searchCriteria);

            //Assert
            _searchResultsPage.NoResultsTextShouldBeShown(expectedText);
        }
    }
}
