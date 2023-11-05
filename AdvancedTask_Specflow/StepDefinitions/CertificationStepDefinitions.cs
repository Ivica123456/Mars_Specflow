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
    public class CertificationStepDefinitions:CommonDriver
    {

     
        [When(@"\[User add new certification]")]
        public void WhenUserAddNewCertification()
        {
            // Create a test instance for this step
            test = extent.CreateTest("When user add a new certification");
            profilePageTabsComponentsObj.clickCertificationTab();
            addEditDeleteCertificationComponentObj.clearTable();
            certificationComponentsObj.AddNewButton();
            load_JsonFileDataModelObj.addCertificationJsonDataModel();
            
        }

        [Then(@"\[Certification should be added successfully]")]
        public void ThenCertificationShouldBeAddedSuccessfully()
        {
            // Create a test instance for this step
            test = extent.CreateTest("Then Certification Should Be Added Successfully");
            certificationAssertHelperObj.assertAddCertification();
          
        }
        [When(@"\[User edit existing certification]")]
        public void WhenUserEditExistingCertification()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User edit existing certification");
            profilePageTabsComponentsObj.clickCertificationTab();
            certificationComponentsObj.EditButton();
            load_JsonFileDataModelObj.EditCertificationJsonDataModel();
           
        }
        [Then(@"\[Certification should be edited successfully]")]
        public void ThenCertificationShouldBeEditedSuccessfully()
        {
            // Create a test instance for this step
            test = extent.CreateTest("Certification should be edited successfully");
            profilePageTabsComponentsObj.clickCertificationTab();
            certificationAssertHelperObj.assertEditCertification();
        }
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
