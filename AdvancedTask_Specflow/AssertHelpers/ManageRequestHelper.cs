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
    public class ManageRequestHelper:CommonDriver
    {
        WebDriverWait wait;

        public ManageRequestHelper()
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }
        public void assertSentRequest()
        {
                       
            // Assert that the current URL is the profile page URL
            Assert.AreEqual("http://localhost:5000/Home/SentRequest", driver.Url);

        }
        public void assertReceivedRequest()
        {
            // Assert that the current URL is the profile page URL
            Assert.AreEqual("http://localhost:5000/Home/ReceivedRequest", driver.Url);
        }
    }
}
