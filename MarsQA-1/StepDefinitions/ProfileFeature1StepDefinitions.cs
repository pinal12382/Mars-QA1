using MarsQA_1.pages;
using MarsQA_1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class ProfileFeature1StepDefinitions :CommonDriver
    {
        SignInpage SignInpageobj = new SignInpage();
        Profilepage Profilepageobj = new Profilepage();

        [Given(@"I logged in to localhost sucessfully")]
        public void GivenILoggedInToLocalhostSucessfully()
        {
            // open chrome browser
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            //signInpage object initilization and definition

            SignInpage SignInpageobj = new SignInpage();
            SignInpageobj.SignInsteps(driver);
        }


        [When(@"I create a New Profile Record")]
        public void WhenICreateANewProfileRecord()
        {
            Profilepageobj.CreateProfile(driver);
        }

        [Then(@"New Profile should be created successfully")]
        public void ThenNewProfileShouldBeCreatedSuccessfully()
        {
            Profilepage Profilepageobj = new Profilepage();
            //string newDescription = Profilepageobj.GetDescription(driver);
            //string newlanguage = Profilepageobj.GetLanguage(driver);
            //string newlanglevel = Profilepageobj.Getlanguagelevel(driver);
            //string newSkill = Profilepageobj.GetSkill(driver);
            //string newSkilllevel = Profilepageobj.Getskilllevel(driver);

            //Assert.That(newDescription == "Hi I am Pinal", "Actual description and expected description did not match");
            //Assert.That(newlanguage == "English", "Actual Language and expected language did not match");
            //Assert.That(newlanglevel == "Fluent", "Actual language level and expected language level did not match");
            //Assert.That(newSkill == "Test Analyst", "Actual skill and expected skill did not match");
            //Assert.That(newSkilllevel == "Beginner", "Actual skill level and expected skill level did not match");

        }
        [When(@"I update a New '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)' in profile page")]
        public void WhenIUpdateANewInProfilePage(string Description , string Language, string LanguageLevel, string Skill, string Skilllevel)
        {
            Profilepageobj.EditProfile(driver, Description, Language, LanguageLevel, Skill, Skilllevel);
        }

        [Then(@"The Record should be upaded '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)' in the profile page")]
        public void ThenTheRecordShouldBeUpadedInTheProfilePage(string Description, string Language, string LanguageLevel, string Skil, string SkilLeval)
        {
            //string editeddescription = Profilepageobj.GeteditedDescription(driver);
            //string editedlanguage = Profilepageobj.Geteditedlanguage(driver);
            //string editedlanguagelevel = Profilepageobj.Geteditedlanguagelevel(driver);
            //string editedskill = Profilepageobj.GeteditedSkill(driver);
            //string editedskilllevel = Profilepageobj.GeteditedSkillLevel(driver);

            //Assert.That(editeddescription == Description, "Actual description and expected description did not match");
            //Assert.That(editedlanguage == Language, "Actual language and expected language did not match");
            //Assert.That(editedlanguagelevel == LanguageLevel, "Actual languagelevel and expected languagelevel did not match");
            //Assert.That(editedskill == Skil, "Actual skill and expected skill did not match");
            //Assert.That(editedskilllevel == SkilLeval, "Actual skilllevel and expected skilllevel did not match");
        }

        [When(@"I deleted Edited profile record in the profile page")]
        public void WhenIDeletedEditedProfileRecordInTheProfilePage()
        {
            Profilepage Profilepageobj = new Profilepage();
            Profilepageobj.DeleteProfile(driver);
        }

        [Then(@"Edited record shold be deleted succssfully")]
        public void ThenEditedRecordSholdBeDeletedSuccssfully()
        {
            
            //string deleteditedlanguage = Profilepageobj.deletelangeage(driver);
            //string deletededitedSkill = Profilepageobj.deleteSkill(driver);

           
            //Assert.That(deleteditedlanguage != "Hindi", "Language should not be deleted");
            //Assert.That(deletededitedSkill != "Edited Skill", "Skill should not be deleted");
        }



        

            
        


    }
}
