using AdvancedTask_Specflow.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask_Specflow.Pages
{
    
    public class ProfilePage: CommonDriver
    {
        WebDriverWait wait;
        private IWebElement tabIndex => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
        //private IWebElement changePasswordButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/div/a[2]"));
        private IWebElement currentPasswordTextBox => driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[1]/input"));
        private IWebElement newPasswordTextBox => driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[2]/input"));
        private IWebElement confirmPasswordTextBox => driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[3]/input"));
        private IWebElement saveButton => driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[4]/button"));
        public ProfilePage()
        {

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));


        }
        public void changePassword(string CurrentPassword,string NewPassword,string ConfirmPassword)
        {
            
            tabIndex.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/div/a[2]", 10);
            IWebElement changePasswordButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/div/a[2]"));
            changePasswordButton.Click();

            
            currentPasswordTextBox.SendKeys(CurrentPassword);

            
            newPasswordTextBox.SendKeys(NewPassword);

            
            confirmPasswordTextBox.SendKeys(ConfirmPassword);

            
            saveButton.Click();
            driver.Navigate().Refresh();



        }
       
        public void incorrectCurrentPassword(string CurrentPassword, string NewPassword, string ConfirmPassword)
        {
            driver.Navigate().Refresh();
            tabIndex.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/div/a[2]", 10);
            IWebElement changePasswordButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/div/a[2]"));
            changePasswordButton.Click();
            currentPasswordTextBox.SendKeys(CurrentPassword);


            newPasswordTextBox.SendKeys(NewPassword);


            confirmPasswordTextBox.SendKeys(ConfirmPassword);


            saveButton.Click();
            driver.Navigate().Refresh();

        }
        public void newPasswordSameAsCurrent(string CurrentPassword, string NewPassword, string ConfirmPassword)
        {
            
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span", 10);
            tabIndex.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/div/a[2]", 10);
            IWebElement changePasswordButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/div/a[2]"));
            changePasswordButton.Click();
            currentPasswordTextBox.SendKeys(CurrentPassword);


            newPasswordTextBox.SendKeys(NewPassword);


            confirmPasswordTextBox.SendKeys(ConfirmPassword);


            saveButton.Click();
        }
        public void passworddNotMeetRequirements(string CurrentPassword, string NewPassword, string ConfirmPassword)
        {
            tabIndex.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/div/a[2]", 10);
            IWebElement changePasswordButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/div/a[2]"));
            changePasswordButton.Click();
            currentPasswordTextBox.SendKeys(CurrentPassword);


            newPasswordTextBox.SendKeys(NewPassword);


            confirmPasswordTextBox.SendKeys(ConfirmPassword);


            saveButton.Click();
            driver.Navigate().Refresh();
        }
        public void changePasswordBack(string CurrentPassword, string NewPassword, string ConfirmPassword)
        {

            tabIndex.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/div/a[2]", 10);
            IWebElement changePasswordButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/div/a[2]"));
            changePasswordButton.Click();
            currentPasswordTextBox.SendKeys(CurrentPassword);


            newPasswordTextBox.SendKeys(NewPassword);


            confirmPasswordTextBox.SendKeys(ConfirmPassword);


            saveButton.Click();

        }










    }
}
