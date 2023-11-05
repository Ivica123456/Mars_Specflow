using AdvancedTask_Specflow.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask_Specflow.AssertHelpers
{
    public class ChangePasswordMessageHelper: CommonDriver
    {
        WebDriverWait wait;

        public ChangePasswordMessageHelper()
        {

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }



        public void successMessage()
        {
            // Get the success message element
            var successMessageElement = driver.FindElement(By.XPath("/html/body/div[1]/div"));

            // Assert that the success message is displayed
            Assert.IsTrue(successMessageElement.Displayed);
        }
        public void faildMessage ()
        {
            // Get the failed message element
            var failedMessageElement = driver.FindElement(By.XPath("/html/body/div[1]/div"));

            // Assert that the faild message is displayed
            Assert.IsTrue(failedMessageElement.Displayed);
        }
        public void IsUserLoggedIn() 
        {

            var Dashboard = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[1]"));
            Assert.AreEqual("Dashboard", Dashboard.Text);
            // Assert that the current URL is the profile page URL
            Assert.AreEqual("http://localhost:5000/Account/Profile", driver.Url);

        }
        

    }
}
