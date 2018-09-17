using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using WebDriverOnCore.WebDriver;

namespace WebDriverOnCore.PageElements.CommonPageSections
{
    public class CommonPagesElements
    {
        public List<IWebElement> SubmitButtons => DriverInitialize.Browser.FindElements(By.CssSelector(".submit")).ToList();

          
    }
}
