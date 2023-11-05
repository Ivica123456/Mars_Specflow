using AdvancedTask_Specflow.Utilities;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedTask_Specflow.Model;

namespace AdvancedTask_Specflow.Pages.Components.SignIn
{
    public class LoginPage : CommonDriver
    {


        
        private IWebElement emailTextbox;
        private IWebElement passwordTextbox;
        private IWebElement loginButton;


        public void renderComponents()
        {
            try
            {
                emailTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void doSignIn(string email, string password)
        {

            renderComponents();

            //Enter the valid email address and password.
            emailTextbox.SendKeys(email);
            passwordTextbox.SendKeys(password);
            //Click on "Login" button

            loginButton.Click();

        }






    }
}
