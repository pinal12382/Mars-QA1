using MarsQA_1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.pages
{
    public  class SignInpage
    {

        IWebDriver driver;
        [FindsBy(How = How.XPath,Using = "/html/body/div[2]/div/div/div[1]/div/div[1]/input")]
        public IWebElement Emailtxtbox { get; set; }

        [FindsBy(How = How.XPath,Using = "/html/body/div[2]/div/div/div[1]/div/div[2]/input")]

        public IWebElement PasswordtxtBox { get; set; }

        [FindsBy(How = How.XPath,Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
       public IWebElement LoginBtn { get; set; }


        public SignInpage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }
        public void addlogindetail()
        {
            Emailtxtbox.Click();
            Emailtxtbox.SendKeys("pinal12382@gmail.com");

            PasswordtxtBox.Click();
            PasswordtxtBox.SendKeys("aarna1310");
        }
        public void login()
        {
            LoginBtn.Click();
            Thread.Sleep(2000);
        }

       
       

       

                

                
                
               

           

                  



        }
    }

