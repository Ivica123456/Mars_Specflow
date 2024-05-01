using AdvancedTask_Specflow.Model;
using AdvancedTask_Specflow.Utilities;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace AdvancedTask_Specflow.StepDefinitions
{

    [Binding]
    public class EducationStepDefinitions : CommonDriver
    {

        WebDriverWait wait;

        public EducationStepDefinitions()
        {

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

        }
        

        [When(@"User add education including '([^']*)', '([^']*)', '([^']*)', '([^']*)','([^']*)'")]
        public void WhenUserAddEducationIncluding(string University, string Country, string Title, string Degree, string Graduation)
        {
            // Create a test instance for this step
            test = extent.CreateTest("When User Add Education");
            profilePageTabsComponentsObj.clickEducationTab();
            educationAssertHelperObj.clearTable();
            educationComponentObj.AddNewButton();
            addEditDeleteEducationComponentObj.addEducation(University, Country, Title, Degree, Graduation);


        }

        [Then(@"User able to see added education details")]
        public void ThenUserAbleToSeeAddedEducationDetails()
        {
            // Create a test instance for this step
            test = extent.CreateTest("Then User Able To See Added Education Details");
            educationAssertHelperObj.tableRowCountry();
        }
        [When(@"User edit education including '([^']*)', '([^']*)', '([^']*)', '([^']*)','([^']*)'")]
        public void WhenUserEditEducationIncluding(string University, string Country, string Title, string Degree, string Graduation)
        {
            // Create a test instance for this step
            test = extent.CreateTest("When User Edit Education Including");
            profilePageTabsComponentsObj.clickEducationTab();
            educationComponentObj.editButton();
            addEditDeleteEducationComponentObj.editEducation(University, Country, Title, Degree, Graduation);

        }
        [Then(@"User able to see edited education details")]
        public void ThenUserAbleToSeeEditedEducationDetails()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User able to see edited education details");
            educationAssertHelperObj.assertTableRowEdit();

        }
        [When(@"User delete education")]
        public void WhenUserDeleteEducation()
        {
            // Create a test instance for this step
            test = extent.CreateTest("User delete education");
            profilePageTabsComponentsObj.clickEducationTab();
            educationComponentObj.delete();
        }
        [Then(@"Education should be deleted")]
        public void ThenEducationShouldBeDeleted()
        {
            // Create a test instance for this step
            test = extent.CreateTest("Education should be deleted");
            educationAssertHelperObj.assertTableRowDelete();
        }





    }
}
