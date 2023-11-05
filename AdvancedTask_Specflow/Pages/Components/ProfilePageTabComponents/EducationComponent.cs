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
    public class EducationComponent:CommonDriver
    {

        private IWebElement clickAddNewButton;
        private IWebElement PencilIcon;
        private IWebElement deleteButton;


        public void renderComponents()
        {
            try
            {

                
                clickAddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
                PencilIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]"));
                deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]"));

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
        public void editButton()
        {
            renderComponents();
            PencilIcon.Click();


        }
        public void delete()
        {
            renderComponents();
            deleteButton.Click();
            Thread.Sleep(2000);



        }
       
        public bool IsdeleteSelection()
        {
            try
            {
                Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]", 5);
                return false;

            }
            catch (Exception)
            {
                return true;
            }
        }
       



    }
}
