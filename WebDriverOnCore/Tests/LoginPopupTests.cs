using NUnit.Framework;
using WebDriverOnCore.LoggerManager;
using WebDriverOnCore.PageObjects;
using WebDriverOnCore.PageSteps;
using WebDriverOnCore.TestUntillities;

namespace WebDriverOnCore.Tests
{
    public class LoginPopupTests: TestsBaseClass
    {
        #region Test fields
        private CommonPageSteps _commonSteps;
        private LoginPopupSteps _loginPopupSteps;

        #endregion

        #region Test setup and tear down

        protected override void TestSetup()
        {
            base.TestSetup();

            NLogManager.LogMessage.Info("Login tests setup was started");
            _commonSteps = new CommonPageSteps();
            _loginPopupSteps = new LoginPopupSteps();
            navigation.OpenWebSiteOnMainPage();
            NLogManager.LogMessage.Info("Smoke tests setup was finished");
        }

        #endregion

        #region Tests

        [Test]
        [Category("LongRunning")]
        public void UserTrysToLoginWithEmptyCredentials_WarningMessageShouldBeShownInPopup()
        {
            _commonSteps.ClickEnterMenu();
            _loginPopupSteps.EnterUserNameAndPasswordToLoginFormAndPressEnterButton("test@test.com", "test");
            _loginPopupSteps.AssertExpectedErrorMessageIsShown("Неверный логин или пароль");
        }


        #endregion

    }
}
