using MarsQA_1.pages;
using MarsQA_1.ProfilePage;
using MarsQA_1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class LanguageStepDefinitions:CommonDriver
    {
       
        [When(@"I create a New language and language level Record")]
        public void WhenICreateANewLanguageAndLanguageLevelRecord()
        { 
            Managelanguage managelanguageobj = new Managelanguage(driver);
            managelanguageobj.addLanguage();
        }

        [Then(@"New language  and New language level record should be created successfully")]
        public void ThenNewLanguageAndNewLanguageLevelRecordShouldBeCreatedSuccessfully()
        {
            Managelanguage managelanguageobj = new Managelanguage(driver);

            Assert.IsTrue(managelanguageobj.GetLanguage().Contains("English"));

            Assert.IsTrue(managelanguageobj.GetLanguagelevel().Contains("Fluent"));

        }
        
        [When(@"I edit a New language and language level Record")]
        public void WhenIEditANewLanguageAndLanguageLevelRecord()
        {
            Managelanguage managelanguageobj = new Managelanguage(driver);
            managelanguageobj.editLanguage();
        }

        [Then(@"New edited language and language level record should be edited successfully")]
        public void ThenNewEditedLanguageAndLanguageLevelRecordShouldBeEditedSuccessfully()
        {
            Managelanguage managelanguageobj = new Managelanguage(driver);

            Assert.IsTrue(managelanguageobj.GeteditedLanguage().Contains("Hindi"));

            Assert.IsTrue(managelanguageobj.GeteditedLanguagelevel().Contains("Native"));

        }

        [When(@"I delete a language and language level Record")]
        public void WhenIDeleteALanguageAndLanguageLevelRecord()
        {
            Managelanguage managelanguageobj = new Managelanguage(driver);
            managelanguageobj.deleteLanguage();

        }

        [Then(@"language record should be deleted successfully")]
        public void ThenLanguageRecordShouldBeDeletedSuccessfully()
        {
            Managelanguage managelanguageobj = new Managelanguage(driver);

            Assert.IsTrue(managelanguageobj.deletelang().Contains("Language should not be deleted"));
           // Assert.That(deleteditedlanguage != "Hindi", "Language should not be deleted");

        }
    }
}
