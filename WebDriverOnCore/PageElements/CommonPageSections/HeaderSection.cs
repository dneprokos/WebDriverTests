using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using WebDriverOnCore.WebDriver;

namespace WebDriverOnCore.PageSections.MainPageSections
{
    public class HeaderSection
    {
        public IWebElement SearchInputButton => Driver.CurrentBrowser.FindElement(By.Id("searchInputButton"));

        public IWebElement HeaderMain => Driver.CurrentBrowser.FindElement(By.ClassName("header-wrap"));

        public IWebElement HeaderTopBanner => Driver.CurrentBrowser.FindElement(By.Id("ctl00_topBanner"));

        public List<IWebElement> HeaderNavigationMenuItems => Driver.CurrentBrowser.FindElements(By.CssSelector(".header-nav > ul >li")).ToList();

        public IWebElement EnterLink => Driver.CurrentBrowser.FindElement(By.Id("enter-link"));

        public List<IWebElement> UserManagementPopups => Driver.CurrentBrowser.FindElements(By
            .CssSelector("div[class='ui-dialog ui-widget ui-widget-content ui-corner-all ui-front ui-draggable ui-resizable']"))
            .ToList();

        public IWebElement SearchField => Driver.CurrentBrowser.FindElement(By.Id("searchInput"));

        
    }
}


