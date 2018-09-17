using FluentAssertions;
using WebDriverOnCore.PageElements.CommonPageSections;

namespace WebDriverOnCore.PageSteps
{
    public class LoginPopupSteps
    {
        public LoginPopup LoginPopup => new LoginPopup();
        public CommonPagesElements CommonPagesElements => new CommonPagesElements();

        public void EnterUserNameAndPasswordToLoginFormAndPressEnterButton(string email, string password)
        {
            LoginPopup.LoginEmail.SendKeys(email);
            LoginPopup.LoginPassword.SendKeys(password);
            LoginPopup.LoginButton.Click();       
        }

        public void AssertExpectedErrorMessageIsShown(string expectedErrorMessage)
        {
            LoginPopup.ErrorMessage.Text.Should().BeEquivalentTo(expectedErrorMessage);
        }
    }
}
