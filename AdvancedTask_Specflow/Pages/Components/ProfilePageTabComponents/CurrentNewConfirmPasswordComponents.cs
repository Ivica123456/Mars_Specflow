using AdvancedTask_Specflow.Model;
using AdvancedTask_Specflow.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask_Specflow.Pages.Components.ProfilePageTabComponents
{
    public class CurrentNewConfirmPasswordComponents:CommonDriver
    {
        private IWebElement currentPasswordTextBox;
        private IWebElement newPasswordTextBox;
        private IWebElement confirmPasswordTextBox;
        private IWebElement saveButton;

        public void renderComponents()
        {
            try
            {
                currentPasswordTextBox = driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[1]/input"));
                newPasswordTextBox = driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[2]/input"));
                confirmPasswordTextBox = driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[3]/input"));
                saveButton = driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[4]/button"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void inCurrentPassword(PasswordChangeDataModel passwordChangeDataModel)
        {
            renderComponents();
            currentPasswordTextBox.Click();
            currentPasswordTextBox.SendKeys(passwordChangeDataModel.Current);
            confirmPasswordTextBox.Click() ;
            confirmPasswordTextBox.SendKeys(passwordChangeDataModel.Confirm);
            newPasswordTextBox.Click();
            newPasswordTextBox.SendKeys(passwordChangeDataModel.New);
            saveButton.Click();


        }
        public void passworddNotMeetRequirements(PasswordChangeDataModel passwordChangeDataModel)
        {
            renderComponents();
            currentPasswordTextBox.Click();
            currentPasswordTextBox.SendKeys(passwordChangeDataModel.Current);
            confirmPasswordTextBox.Click();
            confirmPasswordTextBox.SendKeys(passwordChangeDataModel.Confirm);
            newPasswordTextBox.Click();
            newPasswordTextBox.SendKeys(passwordChangeDataModel.New);
            saveButton.Click();
            driver.Navigate().Refresh();


        }
        public void newPassword(PasswordChangeDataModel passwordChangeDataModel)
        {
            renderComponents();
            currentPasswordTextBox.Click();
            currentPasswordTextBox.SendKeys(passwordChangeDataModel.Current);
            confirmPasswordTextBox.Click();
            confirmPasswordTextBox.SendKeys(passwordChangeDataModel.Confirm);
            newPasswordTextBox.Click();
            newPasswordTextBox.SendKeys(passwordChangeDataModel.New);
            saveButton.Click();
            driver.Navigate().Refresh();
            
        }
     

    }



}
