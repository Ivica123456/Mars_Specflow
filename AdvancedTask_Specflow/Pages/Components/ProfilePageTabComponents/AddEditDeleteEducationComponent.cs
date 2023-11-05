using AdvancedTask_Specflow.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask_Specflow.Pages.Components.ProfilePageTabComponents
{
    public class AddEditDeleteEducationComponent:CommonDriver
    {

        private IWebElement universityName;
        private IWebElement countryOfCollege;
        private IWebElement titleDropdown;
        private IWebElement inputDegree;
        private IWebElement yearOfGraduation;
        private IWebElement addNewButton;
        private IWebElement editUniversityName;
        private IWebElement editCountryOfCollege;
        private IWebElement editTitleDropdown;
        private IWebElement editInputDegree;
        private IWebElement editYearOfGraduation;
        private IWebElement updateButton;
        

        public void renderAddComponents()
        {
            try
            {
                
                universityName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
                countryOfCollege = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
                titleDropdown = driver.FindElements(By.Name("title"))[0];
                inputDegree = driver.FindElements(By.Name("degree"))[0];
                yearOfGraduation = driver.FindElements(By.Name("yearOfGraduation"))[0];
                addNewButton = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"))[0];
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderComponentsEdit()
        {
            try
            {
                
                
                editUniversityName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input"));
                editCountryOfCollege = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select"));
                editTitleDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select"));
                editInputDegree = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input"));
                editYearOfGraduation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select"));
                updateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
       
        public void addEducation(string University, string Country, string Title, string Degree, string Graduation)
        {
            renderAddComponents();
                       
            universityName.Click();
            universityName.SendKeys(University);
            // Click to open the dropdown for selecting the country of the college
            countryOfCollege.Click();

            // Create a SelectElement to interact with the country dropdown
            SelectElement selectElementSelectCountryOfCollege = new SelectElement(countryOfCollege);

            // Select the specified country from the dropdown
            selectElementSelectCountryOfCollege.SelectByValue(Country);

            // Click to open the dropdown for selecting the title
            titleDropdown.Click();

            // Create a SelectElement to interact with the title dropdown
            SelectElement selectElementSelectTitle = new SelectElement(titleDropdown);

            // Select the specified title from the dropdown
            selectElementSelectTitle.SelectByValue(Title);

            // Input degree
            inputDegree.Clear();
            inputDegree.SendKeys(Degree);

            // Select Year of graduation dropdown
            yearOfGraduation.Click();

            // Choose the year in the dropdown list
            Wait.WaitToBeClickable(driver, "XPath", "//select[starts-with(@class,\"ui dropdown\") and contains(@name,\"yearOfGraduation\")]", 10);
            SelectElement selectElementSelectYear = new SelectElement(yearOfGraduation);
            selectElementSelectYear.SelectByValue(Graduation);

            

            addNewButton.Click();

            Wait.WaitToBeVisible(driver, "CssSelector", ".ns-box-inner", 5);

        }
        public void editEducation(string University,string Country, string Title, string Degree, string Graduation)
        {
            renderComponentsEdit();
            
            // Enter the university name into the appropriate field
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input", 5);

            editUniversityName.Click();
            editUniversityName.Clear();
            editUniversityName.SendKeys(University);

            editCountryOfCollege.Click();
            // Create a SelectElement to interact with the country dropdown
            SelectElement selectElementSelectCountryOfCollege = new SelectElement(editCountryOfCollege);

            // Select the specified country from the dropdown
            selectElementSelectCountryOfCollege.SelectByValue(Country);

            // Click to open the dropdown for selecting the title
            editTitleDropdown.Click();

            // Create a SelectElement to interact with the title dropdown
            SelectElement selectElementSelectTitle = new SelectElement(editTitleDropdown);

            // Select the specified title from the dropdown
            selectElementSelectTitle.SelectByValue(Title);
            editTitleDropdown.Click();



            // Input degree
            editInputDegree.Clear();
            editInputDegree.SendKeys(Degree);
            
            // Select Year of graduation dropdown
            editYearOfGraduation.Click();

            // Choose the year in the dropdown list
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select", 10);
            SelectElement selectElementSelectYear = new SelectElement(editYearOfGraduation);
            selectElementSelectYear.SelectByValue(Graduation);
            editYearOfGraduation.Click();

            

            updateButton.Click();

            Wait.WaitToBeVisible(driver, "CssSelector", ".ns-box-inner", 5);



        }
        


    }
}
