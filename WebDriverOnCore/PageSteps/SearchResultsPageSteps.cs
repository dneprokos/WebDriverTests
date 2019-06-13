using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using WebDriverOnCore.PageElements.SearchResultsPage;
using WebDriverOnCore.PageObjects;
using WebDriverOnCore.TestsInit;
using WebDriverOnCore.WebDriver;

namespace WebDriverOnCore.PageSteps
{
    public class SearchResultsPageSteps
    {
        private SearchResultsPage SearchResultsPage => new SearchResultsPage();

        public enum filterOptionKeys { AllAreas, Players, Teams, Tornaments, News };

        public static Dictionary<filterOptionKeys, string> FilterOptions = new Dictionary<filterOptionKeys, string>()
        {
            { filterOptionKeys.AllAreas, "Во всех разделах" },
            { filterOptionKeys.Players, "Игроки" },
            { filterOptionKeys.Teams, "Команды" },
            { filterOptionKeys.Tornaments, "Чемпионаты" },
            { filterOptionKeys.News, "Новости" }
        };


        public void SearchPageShouldBeOpened(string searchCriteria)
        {
            Assert.AreEqual(TestSettings.SearchResultsUrl + searchCriteria, Driver.CurrentBrowser.Url);
        }

        public void SearchFieldShouldContainValue(string searchCriteria)
        {
            var actualValue = SearchResultsPage.SearchField.GetAttribute("value").ToString();
            actualValue.Should().BeEquivalentTo(searchCriteria);
        }

        public void ShouldContainAllExpectedElements(string searchCriteria)
        {
            Assert.IsNotNull(SearchResultsPage.SearchField);
            Assert.IsNotNull(SearchResultsPage.SearchAreasFilter);
            Assert.IsNotNull(SearchResultsPage.NewsSection);

            SearchAreaFilterShouldContainExpectedOptions();
        }

        public void NoResultsTextShouldBeShown(string expectedText)
        {
            SearchResultsPage.SearchResultElements.Any(el => el.Text.Equals(expectedText)).Should().BeTrue();
        }

        private void SearchAreaFilterShouldContainExpectedOptions()
        {
            SelectElement selectElement = new SelectElement(SearchResultsPage.SearchAreasFilter);
            CommonPageSteps.MakeElementOptionsVisible("#" + SearchResultsPage.SearchAreaId);

            List<string> availableOptions = selectElement.Options.Select(o => o.Text).ToList();
            List<string> expectedOptions = FilterOptions.Select(o => o.Value).ToList();

            availableOptions.Should().BeEquivalentTo(expectedOptions);
        }
    }
}
