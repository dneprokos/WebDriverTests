using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using WebDriverOnCore.PageElements.ScoreBoardPage;
using WebDriverOnCore.WebDriver;

namespace WebDriverOnCore.PageSteps
{
    public class ScoreboardPageSteps
    {
        ScoreBoardElements ScoreBoardElements => new ScoreBoardElements();



        public void SelectTornamentFromTornamentsDropDownList(string tornament)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)DriverInitialize.Browser;
            var jsScript = "document.getElementById(\"ctl00_mod966_ddlChamp\")";
            js.ExecuteScript(jsScript + ".click()");

            

            SelectElement selectElement = new SelectElement(ScoreBoardElements.Tornaments);            
            selectElement.SelectByText(tornament);
            
        }
    }
}
