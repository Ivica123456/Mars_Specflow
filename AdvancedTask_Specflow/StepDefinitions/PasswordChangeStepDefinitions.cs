using AdvancedTask_Specflow.Model;
using AdvancedTask_Specflow.Utilities;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AdvancedTask_Specflow.StepDefinitions
{
    [Binding]
    public class PasswordChangeStepDefinitions:CommonDriver
    {
        [When(@"\[User enter incorrect current password]")]
        public void WhenUserEnterIncorrectCurrentPassword()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User enter incorrect current password");
            profilePageTabsComponentsObj.clickWelcomeTab();
            changePasswordComponentObj.clickPasswordButton();
            load_JsonFileDataModelObj.passwordChangeIncorrect_data();
        }

        [Then(@"\[User can't change password Verification Failed ]")]
        public void ThenUserCantChangePasswordVerificationFailed()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User can't change password Verification Failed");
            changePasswordMessageHelperObj.faildMessage();
        }
        [When(@"\[\[User enters valid email and password and click on login button]")]
        public void WhenUserEntersValidEmailAndPasswordAndClickOnLoginButton()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User enters valid email and password and click on login button");
            load_JsonFileDataModelObj.EmailAndPassword();
           
        }
        [When(@"\[User enter a password that does not meet the requirements \(e\.g\. less than (.*) characters, contains only letters\) and confirm the password]")]
        public void WhenUserEnterAPasswordThatDoesNotMeetTheRequirementsE_G_LessThanCharactersContainsOnlyLettersAndConfirmThePassword(int p0)
        {
            // Create a test instance for this step
            test = extent.CreateTest("User enter a password that does not meet the requirements");
            profilePageTabsComponentsObj.clickWelcomeTab();
            changePasswordComponentObj.clickPasswordButton();
            load_JsonFileDataModelObj.passwordNotMeetTheRequirements();
                    
        }
        [Then(@"\[User can't change password ]")]
        public void ThenUserCantChangePassword()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User can't change password");
            changePasswordMessageHelperObj.faildMessage();
        }
        [When(@"\[User change to new password successfully]")]
        public void WhenUserChangeToNewPasswordSuccessfully()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User change to new password successfully");
            profilePageTabsComponentsObj.clickWelcomeTab();
            changePasswordComponentObj.clickPasswordButton();
            load_JsonFileDataModelObj.newPassword_dataJsonDataModel();           
            profilePageTabsComponentsObj.clickSignOut();
        }

        [Then(@"\[User should login with new password successfully]")]
        public void ThenUserShouldLoginWithNewPasswordSuccessfully()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User should login with new password successfully");
            splashPageObj.clickSignInButton();
            load_JsonFileDataModelObj.loginDataNewPassword();
            
        }
        [Then(@"\[User is logged in and landed to profile page]")]
        public void ThenUserIsLoggedInAndLandedToProfilePage()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User is logged in and landed to profile page");
            changePasswordMessageHelperObj.IsUserLoggedIn();
        }









    }
}
