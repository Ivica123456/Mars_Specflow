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
            jsonFileDataModelLoaderObj.passwordChangeIncorrect_data();
        }

        [Then(@"\[User can't change password Verification Failed ]")]
        public void ThenUserCantChangePasswordVerificationFailed()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User can't change password Verification Failed");
            changePasswordMessageHelperObj.faildMessage();
        }

        [When(@"\[User enter a password that does not meet the requirements \(e\.g\. less than (.*) characters, contains only letters\) and confirm the password]")]
        public void WhenUserEnterAPasswordThatDoesNotMeetTheRequirementsE_G_LessThanCharactersContainsOnlyLettersAndConfirmThePassword(int p0)
        {
            // Create a test instance for this step
            test = extent.CreateTest("User enter a password that does not meet the requirements");
            profilePageTabsComponentsObj.clickWelcomeTab();
            changePasswordComponentObj.clickPasswordButton();
            jsonFileDataModelLoaderObj.passwordNotMeetTheRequirements();
                    
        }
        [Then(@"\[User can't change password ]")]
        public void ThenUserCantChangePassword()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User can't change password");
            changePasswordMessageHelperObj.faildMessage();
        }
        [When(@"User entered  same new password as Current Password")]
        public void WhenUserEnteredSameNewPasswordAsCurrentPassword()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User eentered same new password as current password");
            profilePageTabsComponentsObj.clickWelcomeTab();
            changePasswordComponentObj.clickPasswordButton();
            jsonFileDataModelLoaderObj.passwordNewAscorrect_data();
        }
                
        [Then(@"The user should receive an error message indicating that the new password cannot be the same as the current password")]
        public void ThenTheUserShouldReceiveAnErrorMessageIndicatingThatTheNewPasswordCannotBeTheSameAsTheCurrentPassword()
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
            jsonFileDataModelLoaderObj.newPassword_dataJsonDataModel();           
            profilePageTabsComponentsObj.clickSignOut();
        }

        [Then(@"\[User should login with new password successfully]")]
        public void ThenUserShouldLoginWithNewPasswordSuccessfully()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User should login with new password successfully");
            splashPageObj.clickSignInButton();
            jsonFileDataModelLoaderObj.loginDataNewPassword();
            
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
