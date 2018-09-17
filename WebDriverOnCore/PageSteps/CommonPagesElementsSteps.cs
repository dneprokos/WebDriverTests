using FluentAssertions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using WebDriverOnCore.PageElements.CommonPageSections;
using WebDriverOnCore.PageSections.MainPageSections;
using WebDriverOnCore.WebDriver;

namespace WebDriverOnCore.PageObjects
{
    public class CommonPagesElementsSteps
    {
        public HeaderSection HeaderMenu => new HeaderSection();
        public FooterSection FooterMenu => new FooterSection();
        public LoginPopup LoginPopup => new LoginPopup();

        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        public string GetCurrentPageHeaderTitle()
        {
            return DriverInitialize.Browser.Title;
        }

        public List<string> GetHeaderNavigationMenuNames()
        {
            return HeaderMenu.HeaderNavigationMenuItems.Select(el => el.Text.ToLower()).ToList();
        }

        public IWebElement GetHeaderNavigationMenuWithName(string navigationMenuName)
        {
            
            IWebElement webElement = HeaderMenu.HeaderNavigationMenuItems
                .FirstOrDefault(m => m.Text
                .Equals(navigationMenuName.ToUpperInvariant()));

            if (webElement != null)
            {
                return webElement;
            }
            else
            {
                throw new Exception("Navigation menu was not found");
            }
        }
        
        public void ClickEnterMenu()
        {
            HeaderMenu.EnterLink.Click();
            var popup = LoginPopup.GetUserManagementPopupByAriaDescribedBy("register");
            
            popup.GetAttribute("display").Should().Equals("block");
        }
    }
}
