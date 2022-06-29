using MarsQA_1.Utilities;
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
    public  class Manageskill
    {
        IWebDriver driver;

        // Click on skill button

        [FindsBy(How = How.XPath,Using ="//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")]
        public IWebElement SkillTab { get; set; }


        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")]
        public IWebElement addNewskillBtn { get; set; }


        // Add skill
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")]

         public IWebElement AddskillTextbox { get; set; }
               

        // select level
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")]
        public IWebElement skilllevelDropdown { get; set; }
        

        [FindsBy(How = How.XPath, Using ="//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")]
       public IWebElement skillAddbutton { get; set; }

        // Edit Skill


        [FindsBy(How = How.XPath, Using ="//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")]
        public IWebElement editSkillTab { get; set; }


        [FindsBy(How = How.XPath, Using= "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i")]
       public IWebElement EditskillButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input")]
        public IWebElement editSkillTextbox { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select")]
         public IWebElement editskilllevelDropdown { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]")]
        public IWebElement UpdateskillButton { get; set; }

        // Delete Skill

        [FindsBy(How = How.XPath, Using="//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")]
        public IWebElement delSkillTab { get; set; }

        [FindsBy(How = How.XPath, Using="//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")]
        public IWebElement RemoveSkillbtn { get; set; }    

     

        public  Manageskill(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Addskill()
        {
            SkillTab.Click();
            Thread.Sleep(1000);
            addNewskillBtn.Click();
            Thread.Sleep(1000);
            AddskillTextbox.Click();
            AddskillTextbox.Clear();
            AddskillTextbox.SendKeys("Test Analyst");
            Thread.Sleep(1000);

            // Add SkillLevel

            skilllevelDropdown.Click();
            Thread.Sleep(1000);
            skilllevelDropdown.SendKeys("Beginner");
            Thread.Sleep(1000);
            skillAddbutton.Click();
            Wait.ElementIsVisible(driver, "XPath", "//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]",5);
           // Thread.Sleep(1000);


        }
        public void editSkill()
        {
            editSkillTab.Click();
            Thread.Sleep(1000);
            EditskillButton.Click();
            Thread.Sleep(1000);
            editSkillTextbox.Click();
            editSkillTextbox.Clear();
            editSkillTextbox.SendKeys("Edited Skill");

            // Edited SkillLevel
            editskilllevelDropdown.Click();
            editskilllevelDropdown.SendKeys("Expert");
            UpdateskillButton.Click();
            Thread.Sleep(1000);

         }
        public void delSkill()
        {   
            delSkillTab.Click();
            Thread.Sleep(1000);
            RemoveSkillbtn.Click();
            Thread.Sleep(1000);

        }

        public string GetSkill()
        {
            Thread.Sleep(2000);
            return driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text;
            
        }

        public string Getskilllevel()
        {
            Thread.Sleep(2000);
            return driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]")).Text;
            

        }
        public string GeteditedSkill()
        {
            Thread.Sleep(2000);
            return driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text;
            

        }
        public string GeteditedSkillLevel()
        {
            Thread.Sleep(2000);
            return driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;
            
        }
        public string deleteSkill()
        {
            return driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;
            

        }






    }


}

