using AdvancedTask_Specflow.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask_Specflow.Pages.Components.ProfilePageTabComponents
{
    public class ChangePasswordComponent:CommonDriver
    {
        private IWebElement changePasswordButton;

        public void renderComponents()
        {
            try
            {
                Wait.WaitToExist(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/div/a[2]", 5);
                changePasswordButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span/div/a[2]"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void clickPasswordButton()
        {
            renderComponents();
            Thread.Sleep(2000);
            changePasswordButton.Click();
        }



    }
}
