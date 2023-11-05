using AdvancedTask_Specflow.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask_Specflow.Pages.Components.ProfilePageTabComponents
{
    public class ProfilePageTabsComponents:CommonDriver
    {
       
        private IWebElement educationButton;
        private IWebElement clickCertificationButton;
        private IWebElement welcomeButton;
        private IWebElement singOut;
        private IWebElement manageRequestsDropdown;
        private IWebElement sentRequestButton;
        private IWebElement receivedRequestButton;
        

        public void renderComponents()
        {
            try
            {
                Wait.WaitToExist(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 5);
                educationButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
                Wait.WaitToExist(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 5);
                clickCertificationButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
                Wait.WaitToExist(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span", 5);
                welcomeButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
                singOut = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));
                manageRequestsDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]"));
                Wait.WaitToBeClickable(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]/div/a[2]", 5);
                sentRequestButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]/div/a[2]"));
                Wait.WaitToExist(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]/div/a[1]", 10);
                receivedRequestButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[1]/div/a[1]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void clickEducationTab()
        {
            renderComponents();
            educationButton.Click();
            
        }
        public void clickCertificationTab()
        {
            renderComponents();
            clickCertificationButton.Click();

        }
        public void clickWelcomeTab()
        {
            renderComponents();
            welcomeButton.Click();
        }
        public void clickSignOut()
        {
            renderComponents();
            singOut.Click();
        }
        public void clickManageRequests()
        {
            renderComponents(); 
            manageRequestsDropdown.Click();
                             

        }
        public void clickSentRequests()
        {
            renderComponents();
            Thread.Sleep(1000); 
            sentRequestButton.Click();
        }
        public void clickReceivedRequests()
        {
            renderComponents();
            Thread.Sleep(1000);
            receivedRequestButton.Click();
        }




    }
}
