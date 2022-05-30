using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.pages
{
    internal  class SignInpage
    {
        public void SignInsteps(IWebDriver driver)

        {
            //  launch locolhost
            driver.Navigate().GoToUrl("http://localhost:5000/");

            try
            {
                // click on signin button
                IWebElement signInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
                signInButton.Click();


                // Identify email textbox and  enter valid emailaddress

                IWebElement emailAddressTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                emailAddressTextbox.SendKeys("pinal12382@gmail.com");


                // Identify Password textbox and enter valid password

                IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                passwordTextbox.SendKeys("aarna1310");

                // click on loginbutton

                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                loginButton.Click();
                Thread.Sleep(2000);

            }
            catch(Exception ex)

            {
                Assert.Fail(" local host URL did not launch " ,ex.Message);
                throw;

            }

                  



        }
    }
}
