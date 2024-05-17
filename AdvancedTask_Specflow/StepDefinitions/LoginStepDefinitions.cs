using AdvancedTask_Specflow.Model;
using AdvancedTask_Specflow.Pages;
using AdvancedTask_Specflow.Utilities;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Newtonsoft.Json;
using OpenQA.Selenium;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using TechTalk.SpecFlow;

namespace AdvancedTask_Specflow.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions : CommonDriver
    {

        // User can successfully login to Mars Portal with valid credentials
        [Given(@"User is on Mars Portal login page")]
        public void GivenUserIsOnMarsPortalLoginPage()
        {
            
            homePageObj.GoToLoginPage();
            splashPageObj.clickSignInButton();
        }
        [When(@"\[User enters valid email and password and click on login button]")]
        public void WhenUserEntersValidEmailAndPasswordAndClickOnLoginButton()
        {

            test = extent.CreateTest("User is on the Mars Portal login page");
            loginPageObj.signIn();
        }
        [Then(@"\[User is successfully logged in to Mars Portal]")]
        public void ThenUserIsSuccessfullyLoggedInToMarsPortal()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User is successfully logged in to Mars Portal");
            loginAssertHelperObj.successMessage();

        }
        //User cannot successfully login to Mars Portal with invalid credentials
        [When(@"User enters invalid '([^']*)' and '([^']*)' and click on login button")]
        public void WhenUserEntersInvalidAndAndClickOnLoginButton(string email, string password)
        {
            //Create a test instance for this step

            test = extent.CreateTest("When User Enters Invalid  And Click On Login Button");
            loginPageObj.doSignIn(email, password);
            loginPageObj.sendVerification();

        }
        [Then(@"User should see an error message indicating that the login credentials are invalid")]
        public void ThenUserShouldSeeAnErrorMessageIndicatingThatTheLoginCredentialsAreInvalid()
        {
            //Create a test instance for this step
            test = extent.CreateTest("Then User Should See An Error Message Indicating That The Login Credentials Are Invalid");
            loginAssertHelperObj.failureMessage();
        }

        //User cannot successfully login to Mars Portal with Json data negative credentials
        [When(@"User enters Json data nagative credentials and click on login button")]
        public void WhenUserEntersJsonDataNagativeCredentialsAndClickOnLoginButton()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User enters Json data nagative credentials and click on login button");
            jsonFileDataModelLoaderObj.loginDataNewPassword();
        }
        [Then(@"User should see an error message indicating that the valid login credentials are required")]
        public void ThenUserShouldSeeAnErrorMessageIndicatingThatTheValidLoginCredentialsAreRequired()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User should see an error message indicating that the valid login credentials are required");
            loginAssertHelperObj.failureMessage();
        }

        //User can successfully login to Mars Portal with valid Json data credentials
        [When(@"User enters valid Json data credentials and click on login button")]
        public void WhenUserEntersValidJsonDataCredentialsAndClickOnLoginButton()
        {
            //Create a test instance for this step

            test = extent.CreateTest("User enters valid Json data credentials and click on login button");
            jsonFileDataModelLoaderObj.loginData();
        }
        [Then(@"User should see an success message that is logged in to Mars Portal")]
        public void ThenUserShouldSeeAnSuccessMessageThatIsLoggedInToMarsPortal()
        {
            //Create a test instance for this step

            test = extent.CreateTest("User should see an success message that is logged in to Mars Portal");
            loginAssertHelperObj.successMessage();
        }


    }
}
