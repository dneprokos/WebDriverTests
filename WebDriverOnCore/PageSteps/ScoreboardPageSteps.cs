using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebDriverOnCore.PageElements.ScoreBoardPage;
using WebDriverOnCore.WebDriver;

namespace WebDriverOnCore.PageSteps
{
    public class ScoreboardPageSteps
    {
        ScoreBoardElements ScoreBoardElements => new ScoreBoardElements();

        public void SelectTornamentFromTornamentsDropDownList(string tornament)
        {
            //Makes option elements visible to webdriver
            IJavaScriptExecutor js = (IJavaScriptExecutor)DriverInitialize.Browser;
            js.ExecuteScript("jQuery('#ctl00_mod966_ddlChamp').css('display', 'block')");
            
            SelectElement selectElement = new SelectElement(ScoreBoardElements.Tornaments);            
            selectElement.SelectByText(tornament);         
        }

        public string GetSelectedTornamentText()
        {
            return ScoreBoardElements.SelectedTornamentTitle.Text;
        }
    }
}
