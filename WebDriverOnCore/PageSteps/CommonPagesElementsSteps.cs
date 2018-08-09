using WebDriverOnCore.PageSections.MainPageSections;
using WebDriverOnCore.WebDriver;

namespace WebDriverOnCore.PageObjects
{
    public class CommonPagesElementsSteps
    {
        public HeaderSection HeaderMenu => new HeaderSection();
        public FooterSection FooterMenu => new FooterSection();

        

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public string GetCurrentPageHeaderTitle()
        {
            return DriverInitialize.Browser.Title;
        }
    }
}
