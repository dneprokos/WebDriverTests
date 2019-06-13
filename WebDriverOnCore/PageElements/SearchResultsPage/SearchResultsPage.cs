using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using WebDriverOnCore.WebDriver;

namespace WebDriverOnCore.PageElements.SearchResultsPage
{
    public class SearchResultsPage
    {
        public static string SearchAreaId = "searchFullTerm";

        public IWebElement SearchField => Driver.CurrentBrowser.FindElement(By.Id("searchFull"));

        public IWebElement SearchAreasFilter = Driver.CurrentBrowser.FindElement(By.Id(SearchAreaId));

        public IWebElement NewsSection = Driver.CurrentBrowser.FindElements(By.CssSelector("div.news")).FirstOrDefault();

        public List<IWebElement> SearchResultElements => Driver.CurrentBrowser.FindElements(By.XPath("//article[contains(@class, \"search-results\")]/div")).ToList();
    }
}
