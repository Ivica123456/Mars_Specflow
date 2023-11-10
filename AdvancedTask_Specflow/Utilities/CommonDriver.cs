using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedTask_Specflow.Pages;
using NUnit.Framework;
using AdvancedTask_Specflow.AssertHelpers;
using AdvancedTask_Specflow.Pages.Components.SignIn;
using OpenQA.Selenium.Support.UI;
using AdvancedTask_Specflow.Pages.Components.ProfilePageTabComponents;
using AdvancedTask_Specflow.Model;
using NUnit.Framework.Interfaces;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AdvancedTask_Specflow.Json_DataModelHelper;


namespace AdvancedTask_Specflow.Utilities
{
    [Binding]
    public class CommonDriver
    {

        public static IWebDriver driver;
        public static LoginPage loginPageObj;
        public static HomePage homePageObj;
        public static SplashPage splashPageObj;
        public static LoginAssertHelper loginAssertHelperObj;
        public static ChangePasswordMessageHelper changePasswordMessageHelperObj;
        public static EducationAssertHelper educationAssertHelperObj;
        public static EducationComponent educationComponentObj;
        public static AddEditDeleteEducationComponent addEditDeleteEducationComponentObj;
        public static ProfilePageTabsComponents profilePageTabsComponentsObj;
        public static AddEditDeleteCertificationComponent addEditDeleteCertificationComponentObj;
        public static CertificationComponents certificationComponentsObj;
        public static CertificationDataModel certificationDataModel;
        public static CertificationAssertHelper certificationAssertHelperObj;
        public static ChangePasswordComponent changePasswordComponentObj;
        public static CurrentNewConfirmPasswordComponents currentNewConfirmPasswordComponentObj;
        public static PasswordChangeDataModel passwordChangeDataModelObj;
        public static JsonFileDataModelLoader jsonFileDataModelLoaderObj;
        public static LoginPage_Json loginPage_JsonObj;
        public static ManageRequestHelper manageRequestHelperObj;
        public static ExtentReports extent;
        public static ExtentTest test;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            //ChromeOptions chromeOptions = new ChromeOptions();
            //chromeOptions.AddArgument("--headless");
            //IWebDriver driver = new ChromeDriver(chromeOptions);
            driver = new ChromeDriver(/*chromeOptions*/);
            loginPageObj = new LoginPage();
            homePageObj = new HomePage();
            
            splashPageObj = new SplashPage();
            loginAssertHelperObj = new LoginAssertHelper();
            changePasswordMessageHelperObj = new ChangePasswordMessageHelper();
            educationAssertHelperObj = new EducationAssertHelper();
            educationComponentObj = new EducationComponent();
            addEditDeleteEducationComponentObj = new AddEditDeleteEducationComponent();
            profilePageTabsComponentsObj = new ProfilePageTabsComponents();
            addEditDeleteCertificationComponentObj = new AddEditDeleteCertificationComponent();
            certificationComponentsObj = new CertificationComponents();
            certificationDataModel = new CertificationDataModel();
            certificationAssertHelperObj = new CertificationAssertHelper();
            changePasswordComponentObj = new ChangePasswordComponent();
            currentNewConfirmPasswordComponentObj = new CurrentNewConfirmPasswordComponents();
            passwordChangeDataModelObj = new PasswordChangeDataModel();
            jsonFileDataModelLoaderObj = new JsonFileDataModelLoader();
            loginPage_JsonObj = new LoginPage_Json();
            manageRequestHelperObj = new ManageRequestHelper();

            var htmlReporter = new ExtentHtmlReporter("C:\\Users\\Ivica\\Desktop\\AdvancedTask-Specflow\\AdvancedTask_Specflow\\AdvancedTask_Specflow\\ExtentReport\\");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;

            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            // Create a test instance for the test run
            test = extent.CreateTest("Test Run Report");

        }
        [AfterScenario]
        public void AfterScenario(ScenarioContext scenarioContext)
        {
            TestStatus testStatus = scenarioContext.TestError == null ? TestStatus.Passed : TestStatus.Failed;
            

            // Log the scenario status
            if (testStatus == TestStatus.Passed)
            {
                test.Pass("Test passed");
            }
            else
            {
                test.Fail("Test failed");

                // Log the failure details
                if (scenarioContext.TestError != null)
                {
                    string failureMessage = scenarioContext.TestError.Message;
                    test.Log(Status.Fail, "Failure Details: " + failureMessage);
                }
            }

            // Log additional information if needed
            test.Log(Status.Info, "Additional info for the scenario");
        }


        [AfterTestRun]
        public static void AfterTestRun()
        {
            extent.Flush();
            driver.Dispose();
        }



    }

}




