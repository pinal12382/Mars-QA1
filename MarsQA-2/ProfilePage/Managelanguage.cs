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
    public class Managelanguage
    {
        IWebDriver driver;

        // Add Language

        [FindsBy(How = How.XPath,Using = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")]
        public IWebElement languageTab { get; set; }

        [FindsBy(How = How.XPath,Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div" )]
        public IWebElement addNewbutton { get; set; }

        [FindsBy(How = How.XPath,Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")]
        public IWebElement langTextbox { get; set; }

        [FindsBy(How = How.XPath,Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")]
        public IWebElement langlevelDropdown { get; set; }

        [FindsBy(How=How.XPath,Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")]
        public IWebElement addButton { get; set; }

        // Edit language





        public Managelanguage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }
        public void addLanguage() 
        {
            languageTab.Click();
            addNewbutton.Click();

            langTextbox.Click();
            langTextbox.Clear();
            langTextbox.SendKeys("English");

            // choose Level

            langlevelDropdown.Click();
            langlevelDropdown.SendKeys("Fluent");
            Thread.Sleep(2000);
        }

        

    }
}
