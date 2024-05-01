using AdvancedTask_Specflow.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask_Specflow.Pages.Components.ProfilePageTabComponents
{
    public class CertificationComponents:CommonDriver
    {
        private IWebElement clickAddNewButton;
        private IWebElement editButton;
        private IWebElement deleteButton;
        
        public void renderComponents()
        {
            try
            {

                clickAddNewButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
                editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]"));
                deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void AddNewButton()
        {
            renderComponents();
            clickAddNewButton.Click();
        }
        public void EditButton()
        {
            renderComponents();
            editButton.Click();


        }
        public void DeleteButton()
        {
            renderComponents();
            deleteButton.Click();
            Thread.Sleep(2000);
        }
        public bool IsdeleteSelection()
        {
            try
            {
                Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]", 2);
                return false;

            }
            catch (Exception)
            {
                return true;
            }
        }

    }
}
