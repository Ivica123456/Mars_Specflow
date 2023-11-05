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
    public class LoginAssertHelper: CommonDriver
    {
        WebDriverWait wait;
        
        public LoginAssertHelper() 
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }
        public void successMessage()
        {

            // Wait for the success message element to be visible
            var successMessageElement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span")));

            // Assert that the success message is displayed
            Assert.IsTrue(successMessageElement.Displayed);
        }
        public void failureMessage()
        {
            // Wait for the success message element to be visible
            var failedMessageElement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]")));

            // Assert that the success message is displayed
            Assert.IsTrue(failedMessageElement.Displayed);
        }
    }
}
