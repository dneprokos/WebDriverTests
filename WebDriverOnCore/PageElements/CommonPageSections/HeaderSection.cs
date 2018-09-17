using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using WebDriverOnCore.WebDriver;

namespace WebDriverOnCore.PageSections.MainPageSections
{
    public class HeaderSection
    {
        public IWebElement HeaderMain => DriverInitialize.Browser.FindElement(By.ClassName("header-wrap"));

        public IWebElement HeaderTopBanner => DriverInitialize.Browser.FindElement(By.Id("ctl00_topBanner"));

        public List<IWebElement> HeaderNavigationMenuItems => DriverInitialize.Browser.FindElements(By.CssSelector(".header-nav > ul >li")).ToList();

        public IWebElement EnterLink => DriverInitialize.Browser.FindElement(By.Id("enter-link"));

        public List<IWebElement> UserManagementPopups => DriverInitialize.Browser.FindElements(By
            .CssSelector("div[class='ui-dialog ui-widget ui-widget-content ui-corner-all ui-front ui-draggable ui-resizable']"))
            .ToList();

        
    }
}


