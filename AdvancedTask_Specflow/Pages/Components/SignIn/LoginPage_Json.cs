using AdvancedTask_Specflow.Model;
using AdvancedTask_Specflow.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask_Specflow.Pages.Components.SignIn
{
    public class LoginPage_Json:CommonDriver
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
        public void doSignIn(Login_JsonDataModel login_JsonDataModel)
        {

            renderComponents();

            //Enter the valid email address and password.
            emailTextbox.SendKeys(login_JsonDataModel.email);
            passwordTextbox.SendKeys(login_JsonDataModel.password);
            //Click on "Login" button

            loginButton.Click();

        }






    }
}

