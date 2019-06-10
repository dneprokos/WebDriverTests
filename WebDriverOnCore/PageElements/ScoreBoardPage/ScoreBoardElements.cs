using OpenQA.Selenium;
using System.Collections.Generic;
using WebDriverOnCore.TestUntillities;
using WebDriverOnCore.WebDriver;

namespace WebDriverOnCore.PageElements.ScoreBoardPage
{
    public class ScoreBoardElements
    {
        public IWebElement TornamentDropDown => 
            SeleniumExtension.WaitUntilElementExists(
                By.CssSelector("div.jselect"), 5);

        public IWebElement Tornaments => DriverInitialize.Browser.FindElement(By.Id("ctl00_mod966_ddlChamp"));        
    }
}
