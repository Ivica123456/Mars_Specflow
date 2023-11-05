using AdvancedTask_Specflow.Model;
using AdvancedTask_Specflow.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask_Specflow.Pages.Components.ProfilePageTabComponents
{
    public class AddEditDeleteCertificationComponent:CommonDriver
    {
        private IWebElement certificateOrAwardTextBox;
        private IWebElement certificationFromTextBox;
        private IWebElement certificationYeardropdown;
        private IWebElement addButton;
        private IWebElement editCertificationAwordTextBox;
        private IWebElement editFromTextBox;
        private IWebElement editYearTextBox;
        private IWebElement updateButton;

        public void renderAddComponents()
        {
            try
            {
                certificateOrAwardTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
                certificationFromTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
                addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
                certificationYeardropdown = driver.FindElement(By.Name("certificationYear"));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void AddCertification(CertificationDataModel certificationDataModel)
        {
            renderAddComponents();
            certificateOrAwardTextBox.SendKeys(certificationDataModel.Certificate);
            //Enter the provider from:
            certificationFromTextBox.SendKeys(certificationDataModel.From);
            //Select the certification year from the dropdown:
            certificationYeardropdown.Click();
            SelectElement selectElementselectCertificationYear = new(certificationYeardropdown);
            selectElementselectCertificationYear.SelectByValue(certificationDataModel.Year);
            //Click on the "Add" button:
            addButton.Click();
            
        }
        public void renderEditComponents()
        {
            try
            {
                editCertificationAwordTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input"));
                editFromTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[2]/input"));
                editYearTextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[3]/select"));
                updateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]"));

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void EditCertification(CertificationDataModel certificationDataModel)
        {
            renderEditComponents();
            editCertificationAwordTextBox.Click();
            editCertificationAwordTextBox.Clear();
            editCertificationAwordTextBox.SendKeys(certificationDataModel.Certificate);
            editFromTextBox.Click();
            editFromTextBox.Clear();
            editFromTextBox.SendKeys(certificationDataModel.From);
            //Edit the certification year from the dropdown:
            editYearTextBox.Click();
            SelectElement selectElementselectCertificationYear = new(editYearTextBox);
            selectElementselectCertificationYear.SelectByValue(certificationDataModel.Year);
            Wait.WaitToExist(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]", 5);
            updateButton.Click();
            //Refresh page
            driver.Navigate().Refresh();
            //Wait for the certification button to be visible:
           
           
            
        }

        public void clearTable()
        {
            // Locate the table element by its class name
            IWebElement table = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table"));

            // Clear the table content (excluding the table header)
            IList<IWebElement> rows = table.FindElements(By.TagName("tr"));

            // Start from the second row (index 1) to preserve the header row
            for (int i = 1; i < rows.Count; i++)
            {
                // Locate the row's delete button and click it to remove the row
                IWebElement deleteButton = rows[i].FindElement(By.CssSelector("span.button > i.remove.icon"));
                deleteButton.Click();
            }
        }

    }
}
