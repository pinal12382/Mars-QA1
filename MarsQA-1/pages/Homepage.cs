using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.pages
{
   public class Homepage
    {
              
           IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div/div/div[1]/div/a")]
        IWebElement signInbtn;

            public Homepage(IWebDriver _driver)
            {
                driver = _driver;
                PageFactory.InitElements(driver, this);
            }
            public void HomePageNavigate()
            {
                driver.Navigate().GoToUrl("http://localhost:5000/");
                driver.Manage().Window.Maximize();
            }
            public void Signin()
            {
                signInbtn.Click();
            }
        }
}
