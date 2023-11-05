using AdvancedTask_Specflow.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask_Specflow.AssertHelpers
{
    public class CertificationAssertHelper:CommonDriver
    {
        WebDriverWait wait;

        public CertificationAssertHelper()
        {

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

        }
        public void assertAddCertification()
        {
            // Get the success message element from the page.
            var successMessageElement = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            // Verify that the success message element is displayed.
            Assert.IsTrue(successMessageElement.Displayed);

            // Verify that the certificate is displayed.
            Wait.WaitToExist(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]", 5);
            var Certificate = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            Assert.AreEqual("NetRiders Challenge Croatia 2011", Certificate.Text);


        }
        public void assertEditCertification() 
        {
            // Get the success message element from the page.
            var successMessageElement = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            // Verify that the success message element is displayed.
            Assert.IsTrue(successMessageElement.Displayed);

            // Verify that the certificate is displayed.
            Wait.WaitToExist(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]", 5);
            var Certificate = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            Assert.AreEqual("Test Analyst", Certificate.Text);


        }
        public void assertTableRowDelete()
        {
            // Get the delete message element from the page.
            var successMessageElement = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            // Verify that the delete message element is displayed.
            Assert.IsTrue(successMessageElement.Displayed);


            var success = certificationComponentsObj.IsdeleteSelection();
            Assert.IsTrue(success);

        }
        
        
    }
}
