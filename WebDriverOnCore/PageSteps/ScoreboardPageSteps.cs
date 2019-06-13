using OpenQA.Selenium.Support.UI;
using WebDriverOnCore.PageElements.ScoreBoardPage;
using WebDriverOnCore.PageObjects;

namespace WebDriverOnCore.PageSteps
{
    public class ScoreboardPageSteps
    {
        ScoreBoardElements ScoreBoardElements => new ScoreBoardElements();

        public void SelectTornamentFromTornamentsDropDownList(string tornament)
        {
            CommonPageSteps.MakeElementOptionsVisible("#ctl00_mod966_ddlChamp");            
            SelectElement selectElement = new SelectElement(ScoreBoardElements.Tornaments);            
            selectElement.SelectByText(tornament);         
        }

        public string GetSelectedTornamentText()
        {
            return ScoreBoardElements.SelectedTornamentTitle.Text;
        }
    }
}
