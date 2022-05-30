using MarsQA_1.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void SignInfunction()
        {
            // open chrome browser
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            //signInpage object initilization and definition

            SignInpage SignInpageobj = new SignInpage();
            SignInpageobj.SignInsteps(driver);


        }
        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
    
