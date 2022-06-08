using MarsQA_1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.pages
{
    internal  class Profilepage
    {
        public string Description;

        public void CreateProfile(IWebDriver driver)
        {
            // create Profile
            // Add decription

            Thread.Sleep(2000);
            IWebElement descriptionButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            descriptionButton.Click();
            


            IWebElement descTextArea = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            descTextArea.Click();
            descTextArea.Clear();
            descTextArea.SendKeys("Hi I am Pinal");
            Description = descTextArea.Text;

            // click on save Button
            IWebElement SaveButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            SaveButton.Click();
            Thread.Sleep(2000);

            //Wait.waitforwebElement(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]",5);


            // Add language
            IWebElement languageTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languageTab.Click();

            Thread.Sleep(2000);
            IWebElement addNewbutton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewbutton.Click();
            


            // Add language 
            IWebElement langTextbox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            langTextbox.Click();
            langTextbox.Clear();
            langTextbox.SendKeys("English");

            // choose Level
            IWebElement langlevelDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            langlevelDropdown.Click();
            langlevelDropdown.SendKeys("Fluent");


            // click Addbutton

            IWebElement addButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
            Thread.Sleep(2000);


            // Click on skill button
            
            IWebElement SkillTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();
            Thread.Sleep(1000);

            IWebElement addNewskill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewskill.Click();
            Thread.Sleep(1000);

            // Add skill
            IWebElement AddskillTextbox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));

            AddskillTextbox.Click();
            AddskillTextbox.Clear();
            AddskillTextbox.SendKeys("Test Analyst");

            // select level
            IWebElement skilllevelDropdown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skilllevelDropdown.Click();
            skilllevelDropdown.SendKeys("Beginner");

            // Click on Add button

            IWebElement skillAddbutton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            skillAddbutton.Click();
            Thread.Sleep(2000);

                  }
        public string GetDescription(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement actualDescription = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/span"));
            return actualDescription.Text;

        }
        public string GetLanguage(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement actualLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return actualLanguage.Text;
        }
        public string Getlanguagelevel(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement actuallanglevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));

            return actuallanglevel.Text;
        }
        public string GetSkill(IWebDriver driver)
        {
            Thread.Sleep(2000);
                
            IWebElement actualskill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));

            return actualskill.Text;

        }


        public string Getskilllevel(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement actualskilllevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));

            return actualskilllevel.Text;
        }
        

        public void EditProfile(IWebDriver driver, string decprm,string langprm,string langlelprm,string skillprm,string skilllelprm)
{

            // Edit decription

            Thread.Sleep(2000);
        IWebElement descriptionButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
        descriptionButton.Click();
               

         IWebElement descTextArea = driver.FindElement(By.XPath("//div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
descTextArea.Click();
descTextArea.Clear();
descTextArea.SendKeys(decprm);
            

// click on save Button
IWebElement SaveButton = driver.FindElement(By.XPath("//div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
SaveButton.Click();
Thread.Sleep(2000);


            // Edit language
            Thread.Sleep(2000);
 IWebElement languageTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
 languageTab.Click();

            Thread.Sleep(2000);
  IWebElement EditlanguageButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
  EditlanguageButton.Click();
  Thread.Sleep(1000);

IWebElement Editlanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
Editlanguage.Click();
Editlanguage.Clear();
Editlanguage.SendKeys(langprm);

IWebElement Editleveldropedown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
Editleveldropedown.Click();
Editleveldropedown.SendKeys(langlelprm);

IWebElement UpdateButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
UpdateButton.Click();


            // Edit Skill
            Thread.Sleep(2000);
IWebElement SkillTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
SkillTab.Click();
Thread.Sleep(1000);

IWebElement EditskillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
EditskillButton.Click();

            Thread.Sleep(2000);
IWebElement AddskillTextbox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));

AddskillTextbox.Click();
AddskillTextbox.Clear();
AddskillTextbox.SendKeys(skillprm);


IWebElement skilllevelDropdown = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));

skilllevelDropdown.Click();
skilllevelDropdown.SendKeys(skilllelprm);

IWebElement UpdateskillButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
UpdateskillButton.Click();
          

}

    public string GeteditedDescription(IWebDriver driver)
    {


            Thread.Sleep(2000);
    IWebElement createDescription = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/span"));
    return createDescription.Text;
    }
    public string Geteditedlanguage(IWebDriver driver)
    {
            Thread.Sleep(2000);
         IWebElement createlanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return createlanguage.Text;
     }
    public string Geteditedlanguagelevel(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement createlanguagelevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return createlanguagelevel.Text;
        }
    public string GeteditedSkill(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement createdskill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return createdskill.Text;
        }
    public string GeteditedSkillLevel(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement createSkilllevel = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return createSkilllevel.Text;
        }



public  void DeleteProfile(IWebDriver driver)
{
            // Delete Description


            Thread.Sleep(2000);
IWebElement Deletedescription = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
Deletedescription.Click();            

IWebElement CleardescTextArea = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
CleardescTextArea.Click();
CleardescTextArea.Clear();
CleardescTextArea.SendKeys("");
CleardescTextArea.Clear();

// Delete Language

IWebElement languageTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
languageTab.Click();

            Thread.Sleep(2000);
     IWebElement Removelang = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
     Removelang.Click();



            // Delete Skill
            Thread.Sleep(2000);
            IWebElement SkillTab = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillTab.Click();

           IWebElement RemoveSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            RemoveSkill.Click();

              }
        // Asserstion 

        
        public string deletelangeage(IWebDriver driver)
        {
                        IWebElement clearLanguage = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return clearLanguage.Text;
        }

        public string deleteSkill(IWebDriver driver)
        {
            IWebElement clearSkill = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return clearSkill.Text;

        }
    }
}
