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
    public class EducationAssertHelper: CommonDriver
    {
        WebDriverWait wait;

        public EducationAssertHelper()
        {

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        }
        public void tableRowCountry()
        {
           
            
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            // Wait for the row with Croatia to be clickable
            var row = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//tr[td[text()='Croatia']]")));

            // Wait for the row with SEdUNet to be visible
            var row1 = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//tr[td[text()='SEduNet']]")));

            // Assert that the country and SEdUNet are displayed
            Assert.IsTrue(row.Displayed);
            Assert.IsTrue(row1.Displayed);


        }
        public void assertTableRowEdit()
        {
            // Find the table row with the country Germany
            var row = driver.FindElement(By.XPath("//tr[td[text()='Brazil']]"));

            Assert.IsTrue(row.Displayed);
            
            
        }
        public void assertTableRowDelete()
        {
            var success = educationComponentObj.IsdeleteSelection();
            Assert.IsTrue(success);

        }
        public void clearTable()
        {
            // Locate the table element by its class name
            IWebElement table = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table"));
            
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
