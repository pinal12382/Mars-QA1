using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.ProfilePage
{
    public class Managedescription
    {
        IWebDriver driver;

        [FindsBy(How = How.XPath,Using="//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")]
        IWebElement descriptionButton;
        [FindsBy(How =How.XPath,Using= "//div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")]
        IWebElement descriptionTextbox;
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")]
        IWebElement saveBtn;
        
        //Edit Description
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")]
        IWebElement editDescbtn;
        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")]
        IWebElement editDescTextbox;
        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/div/div/form/div/div/div[2]/button")]
        IWebElement saveButton;

        //Delete Description
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")]
        IWebElement deldescbtn;
        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")]
        IWebElement delDescTextbox;
        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/div/div/form/div/div/div[2]/button")]
        IWebElement delsaveButton;

        public Managedescription(IWebDriver _driver)
        {
            driver = _driver;
            PageFactory.InitElements(driver, this);


        }
        public void addDesc()
        {
            descriptionButton.Click();
            descriptionTextbox.Click();
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys("Hi I am Pinal");
            saveBtn.Click();
            Thread.Sleep(2000);
        }
        public void editDesc()
        {
            
            editDescbtn.Click();
            editDescTextbox.Click();
            editDescTextbox.Clear();
            editDescTextbox.SendKeys("Edited Description");
            saveButton.Click();

        }

        public void delDesc()
        {
            Thread.Sleep(2000);
            deldescbtn.Click();
            delDescTextbox.Click();
            delDescTextbox.Clear();
            delsaveButton.Click();
        }

        public string GetDescription()
        {

            Thread.Sleep(2000);
                 
            return driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/span")).Text;

        }
        public string GeteditedDescription()
        {

            Thread.Sleep(2000);
            return driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/span")).Text;
            
        }









    }
}
