using AdvancedTask_Specflow.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask_Specflow.Pages
{
    public class SplashPage: CommonDriver
    {
        private IWebElement signInButton;


        public void renderComponents()
        {
            try
            {
                signInButton = driver.FindElement(By.XPath("//a[contains(@class,\"item\")]"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void clickSignInButton()
        {

            //Click on "Sign In" button
            Wait.WaitToBeClickable(driver, "XPath", "//a[contains(@class,\"item\")]", 10);

            renderComponents();
            signInButton.Click();

        }

    }
}
