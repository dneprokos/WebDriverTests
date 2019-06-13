using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using WebDriverOnCore.WebDriver;

namespace WebDriverOnCore.PageElements.CommonPageSections
{
    public class CommonPagesElements
    {
        public List<IWebElement> SubmitButtons => Driver.CurrentBrowser.FindElements(By.CssSelector(".submit")).ToList();

          
    }
}
