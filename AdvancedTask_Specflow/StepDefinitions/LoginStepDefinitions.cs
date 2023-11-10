using AdvancedTask_Specflow.Model;
using AdvancedTask_Specflow.Utilities;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Newtonsoft.Json;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AdvancedTask_Specflow.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions: CommonDriver
    {
       

        [Given(@"\[ User is on the Mars Portal login page]")]
        public void GivenUserIsOnTheMarsPortalLoginPage()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User is on the Mars Portal login page");
            homePageObj.GoToLoginPage();
            splashPageObj.clickSignInButton();
                        
        }
        [When(@"\[User enters valid '([^']*)' and '([^']*)' and click on login button]")]
        public void WhenUserEntersValidAndAndClickOnLoginButton(string email, string password)
        {
            // Create a test instance for this step
            test = extent.CreateTest("User is on the Mars Portal login page");
            loginPageObj.doSignIn(email, password);
        }
        [Then(@"\[User is successfully logged in to Mars Portal]")]
        public void ThenUserIsSuccessfullyLoggedInToMarsPortal()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User is successfully logged in to Mars Portal");
            loginAssertHelperObj.successMessage();
           
        }
        [When(@"\[User enters invalid '([^']*)' and '([^']*)' and click on login button]")]
        public void WhenUserEntersInvalidAndAndClickOnLoginButton(string email, string password)
        {
            // Create a test instance for this step
            test = extent.CreateTest("When User Enters Invalid  And Click On Login Button");
            loginPageObj.doSignIn(email,password);
        }
        [Then(@"\[User should see an error message indicating that the login credentials are invalid]")]
        public void ThenUserShouldSeeAnErrorMessageIndicatingThatTheLoginCredentialsAreInvalid()
        {
            // Create a test instance for this step
            test = extent.CreateTest("Then User Should See An Error Message Indicating That The Login Credentials Are Invalid");
            loginAssertHelperObj.failureMessage();
        }
        [When(@"\[User enters empty '([^']*)' and '([^']*)' and click on login button]")]
        public void WhenUserEntersEmptyAndAndClickOnLoginButton(string email, string password)
        {
            // Create a test instance for this step
            test = extent.CreateTest("When User Enters Empty And Click On Login Button");
            loginPageObj.doSignIn(email,password);
        }
        [Then(@"\[User should see an error message indicating that the login credentials are required]")]
        public void ThenUserShouldSeeAnErrorMessageIndicatingThatTheLoginCredentialsAreRequired()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User should see an error message indicating that the login credentials are required");
            loginAssertHelperObj.failureMessage();
        }
        [When(@"\[User enters Json data nagative credentials and click on login button]")]
        public void WhenUserEntersJsonDataNagativeCredentialsAndClickOnLoginButton()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User enters Json data nagative credentials and click on login button");
            jsonFileDataModelLoaderObj.loginDataNewPassword();
        }
        [Then(@"\[User should see an error message indicating that the valid login credentials are required]")]
        public void ThenUserShouldSeeAnErrorMessageIndicatingThatTheValidLoginCredentialsAreRequired()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User should see an error message indicating that the valid login credentials are required");
            loginAssertHelperObj.failureMessage();
        }
        [When(@"\[User enters valid Json data credentials and click on login button]")]
        public void WhenUserEntersValidJsonDataCredentialsAndClickOnLoginButton()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User enters valid Json data credentials and click on login button");
            jsonFileDataModelLoaderObj.EmailAndPassword();
        }
        [Then(@"\[User should see an success message that is logged in to Mars Portal]")]
        public void ThenUserShouldSeeAnSuccessMessageThatIsLoggedInToMarsPortal()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User should see an success message that is logged in to Mars Portal");
            loginAssertHelperObj.successMessage();
        }


    }
}
