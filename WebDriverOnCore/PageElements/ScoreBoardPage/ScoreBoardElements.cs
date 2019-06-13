using OpenQA.Selenium;
using WebDriverOnCore.TestUntillities;
using WebDriverOnCore.WebDriver;

namespace WebDriverOnCore.PageElements.ScoreBoardPage
{
    public class ScoreBoardElements
    {
        public IWebElement TornamentDropDown => 
            SeleniumExtension.WaitUntilElementExists(
                By.CssSelector("div.jselect"), 5);

        public IWebElement Tornaments => Driver.CurrentBrowser.FindElement(By.Id("ctl00_mod966_ddlChamp"));

        public IWebElement SelectedTornamentTitle => Driver.CurrentBrowser.FindElement(By.CssSelector("div.select-block.tournament-select > div.jselect >div.jselect-title")); 

    }
}
