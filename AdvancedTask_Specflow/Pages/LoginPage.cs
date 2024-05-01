using AdvancedTask_Specflow.Utilities;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTask_Specflow.Pages
{
    public class LoginPage : CommonDriver
    {
        WebDriverWait wait;

        IWebElement signInButton => driver.FindElement(By.XPath("//a[contains(@class,\"item\")]"));
        IWebElement emailTextbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        IWebElement passwordTextbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        IWebElement rememberMeCheckbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[3]/div/input"));
        IWebElement loginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        IWebElement sendVerificationEmail => driver.FindElement(By.XPath("//*[@id=\"submit-btn\"]"));


        public LoginPage()
        {

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

        }
        public void goToProfilePage()
        {
           

            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver, "XPath", "//a[contains(@class,\"item\")]", 10);
            signInButton.Click();

           
        }
        public void signIn()
        {
            string username = Environment.GetEnvironmentVariable("MarsEmail");
            string password = Environment.GetEnvironmentVariable("MarsPassword");

            // Enter valid username in TextBox
            Wait.WaitToBeVisible(driver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[1]/input", 5);
            emailTextbox.SendKeys(username);

            // Enter valid password in TextBox
            passwordTextbox.SendKeys(password);

            //Identify remember me checkbox and click
            rememberMeCheckbox.Click();

            // Click on Login
            loginButton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a", 10);


        }
        public void doSignIn(string email,string password)
        {
            
            // Enter valid username in TextBox
            Wait.WaitToBeVisible(driver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[1]/input", 5);
            emailTextbox.SendKeys(email);

            // Enter valid password in TextBox
            passwordTextbox.SendKeys(password);

            //Identify remember me checkbox and click
            rememberMeCheckbox.Click();

            // Click on Login
            loginButton.Click();
           
            

        }
        public void doSignInEmpty(string email, string password)
        {

            // Enter valid username in TextBox
            Wait.WaitToBeVisible(driver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[1]/input", 5);
            emailTextbox.SendKeys(email);

            // Enter valid password in TextBox
            passwordTextbox.SendKeys(password);

            //Identify remember me checkbox and click
            rememberMeCheckbox.Click();

            // Click on Login
            loginButton.Click();


        }
        public void sendVerification()
        {

            // Enter valid username in TextBox
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"submit-btn\"]", 5);
            sendVerificationEmail.Click();




        }
    }
}
