using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.pages
{
   public class Homepage
    {
              
         public  IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div/div/div[1]/div/a")]
        public IWebElement SignInbtn { get; set;}

            public Homepage(IWebDriver driver)
            {
               this.driver = driver;
                PageFactory.InitElements(driver,this);
            }
            public void HomePageNavigate()
            {
                driver.Navigate().GoToUrl("http://localhost:5000/");
               Thread.Sleep(2000);
                driver.Manage().Window.Maximize();
               Thread.Sleep(2000);  
                
            }
        public void Signin(IWebDriver driver)
        {


            SignInbtn.Click();
            Thread.Sleep(2000);

        }
        }
}
