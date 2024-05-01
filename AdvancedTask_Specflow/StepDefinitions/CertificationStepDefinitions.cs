using AdvancedTask_Specflow.Model;
using Newtonsoft.Json;
using NUnit.Framework.Internal;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using AdvancedTask_Specflow.Pages.Components.ProfilePageTabComponents;
using AdvancedTask_Specflow.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using AventStack.ExtentReports;
using NUnit.Framework.Interfaces;

namespace AdvancedTask_Specflow.StepDefinitions
{
    [Binding]
    public class CertificationStepDefinitions : CommonDriver
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            homePageObj.GoToLoginPage();
            splashPageObj.clickSignInButton();
            loginPageObj.signIn();
        }

        //[1Add certification]
        [When(@"User add new certification from the JSON file located at ""([^""]*)""")]
        public void WhenUserAddNewCertificationFromTheJSONFileLocatedAt(string p0)
        {
            // Create a test instance for this step
            test = extent.CreateTest("When user add a new certification");
            profilePageTabsComponentsObj.clickCertificationTab();
            addEditDeleteCertificationComponentObj.clearTable();
            certificationComponentsObj.AddNewButton();

            // Load the JSON file using the 'filePath' parameter.
            CertificationDataModel certificationDataModel = JsonConvert.DeserializeObject<CertificationDataModel>(File.ReadAllText(p0));
            // Pass the data model object to the `AddCertification()` method.
            addEditDeleteCertificationComponentObj.AddCertification(certificationDataModel);


        }
        [Then(@"\[Certification should be added successfully]")]
        public void ThenCertificationShouldBeAddedSuccessfully()
        {
            // Create a test instance for this step
            test = extent.CreateTest("Then Certification Should Be Added Successfully");
            certificationAssertHelperObj.assertAddCertification();
        }
        //[2Edit certification]
        [When(@"User edit existing certification from the JSON file located at ""([^""]*)""")]
        public void WhenUserEditExistingCertificationFromTheJSONFileLocatedAt(string p0)
        {
            // Create a test instance for this step
            test = extent.CreateTest("User edit existing certification from the JSON file");
            profilePageTabsComponentsObj.clickCertificationTab();
            certificationComponentsObj.EditButton();

            // Load the JSON file using the 'filePath' parameter.
            CertificationDataModel certificationDataModel = JsonConvert.DeserializeObject<CertificationDataModel>(File.ReadAllText(p0));
            // Pass the data model object to the `EditCertification` method.
            addEditDeleteCertificationComponentObj.EditCertification(certificationDataModel);

        }
        [Then(@"\[Certification should be edited successfully]")]
        public void ThenCertificationShouldBeEditedSuccessfully()
        {
            // Create a test instance for this step
            test = extent.CreateTest("Certification should be edited successfully");
            profilePageTabsComponentsObj.clickCertificationTab();
            certificationAssertHelperObj.assertEditCertification();
        }
        //[3Delete certification]
        [When(@"\[User delete existing certification]")]
        public void WhenUserDeleteExistingCertification()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User delete existing certification");
            profilePageTabsComponentsObj.clickCertificationTab();
            certificationComponentsObj.DeleteButton();
        }
        [Then(@"\[Certification should be deleted successfully]")]
        public void ThenCertificationShouldBeDeletedSuccessfully()
        {
            // Create a test instance for this step
            test = extent.CreateTest("Certification should be deleted successfully");
            certificationAssertHelperObj.assertTableRowDelete();
        }










    }
}
