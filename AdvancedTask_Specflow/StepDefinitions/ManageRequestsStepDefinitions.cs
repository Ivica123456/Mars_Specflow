using AdvancedTask_Specflow.Model;
using AdvancedTask_Specflow.Utilities;
using Newtonsoft.Json;
using SharpCompress.Common;
using System;
using TechTalk.SpecFlow;

namespace AdvancedTask_Specflow.StepDefinitions
{
    [Binding]
    public class ManageRequestsStepDefinitions:CommonDriver
    {
        [Given(@"the user is on the Mars Portal login page")]
        public void GivenTheUserIsOnTheMarsPortalLoginPage()
        {
            //// Create a test instance for this step
            //test = extent.CreateTest("Given User is on the Mars Portal login page");
            homePageObj.GoToLoginPage();
            splashPageObj.clickSignInButton();
        }
              
        [When(@"the user enters valid credentials from the JSON file located at ""([^""]*)""")]
        public void WhenTheUserEntersValidCredentialsFromTheJSONFileLocatedAt(string p0)
        {
            // Create a test instance for this step
            test = extent.CreateTest("User enters valid credentials from JSON file");

            // Load the JSON file using the 'filePath' parameter.
            Login_JsonDataModel login_JsonDataModel = JsonConvert.DeserializeObject<Login_JsonDataModel>(File.ReadAllText(p0));

            // Pass the data model object to the `doSignIn` method.
            loginPage_JsonObj.doSignIn(login_JsonDataModel);
        }


        [When(@"the user clicks on the Manage Requests dropdown menu and selects the Sent Requests option")]
        public void WhenTheUserClicksOnTheManageRequestsDropdownMenuAndSelectsTheSentRequestsOption()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User clicks on the Manage Requests dropdown menu and selects the Sent Requests option");
            profilePageTabsComponentsObj.clickManageRequests();
            profilePageTabsComponentsObj.clickSentRequests();
        }


        [Then(@"the application navigates to the /Home/SentRequest page")]
        public void ThenTheApplicationNavigatesToTheHomeSentRequestPage()
        {
            // Create a test instance for this step
            test = extent.CreateTest("Then The Application Navigates To The Home SentRequest Page");
            manageRequestHelperObj.assertSentRequest();
        }
        [When(@"the user clicks on the Manage Requests dropdown menu and selects the ReceivedRequest option")]
        public void WhenTheUserClicksOnTheManageRequestsDropdownMenuAndSelectsTheReceivedRequestOption()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User clicks on the Manage Requests dropdown menu and selects the Received Request option");
            profilePageTabsComponentsObj.clickManageRequests();
            profilePageTabsComponentsObj.clickReceivedRequests();
        }
        [Then(@"the application navigates to the Home/ReceivedRequest page")]
        public void ThenTheApplicationNavigatesToTheHomeReceivedRequestPage()
        {
            // Create a test instance for this step
            test = extent.CreateTest("Then The Application Navigates To The Home Received Request Page");
            manageRequestHelperObj.assertReceivedRequest();
        }



    }
}
