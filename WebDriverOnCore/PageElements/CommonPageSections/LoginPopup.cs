using OpenQA.Selenium;
using System.Linq;
using WebDriverOnCore.PageSections.MainPageSections;
using WebDriverOnCore.TestsInit;
using WebDriverOnCore.TestUntillities;
using WebDriverOnCore.WebDriver;

namespace WebDriverOnCore.PageElements.CommonPageSections
{
    public class LoginPopup
    {
        public HeaderSection HeaderMenu => new HeaderSection();

        public IWebElement GetUserManagementPopupByAriaDescribedBy(string area)
        {
            return HeaderMenu.UserManagementPopups.First(el => el.GetAttribute("aria-describedby").Equals(area));
        }

        public IWebElement LoginEmail => Driver.CurrentBrowser.FindElement(By.Id("loginemail"));

        public IWebElement LoginPassword => Driver.CurrentBrowser.FindElement(By.Id("loginpassword"));

        //Find LoginButton by Css selector
        public IWebElement LoginButton => Driver.CurrentBrowser.FindElement(By.CssSelector("#loginblock button.submit"));

        //Find LoginButton by XPath. Just for example
        //public IWebElement LoginButton = DriverInitialize.Browser.FindElement(By.XPath("//button[.='вход']"));

        //Find login popup error by css selector
        //public IWebElement ErrorMessage => DriverInitialize.Browser.FindElement(By.CssSelector("#logincontent .error"));

        //Wait for login popup error
        public IWebElement ErrorMessage => SeleniumExtension.WaitUntilElementExists(By.CssSelector("#logincontent .error"), TestSettings.WaitElementTimeOut); 
    }
}
