using MarsQA_1.pages;
using MarsQA_1.ProfilePage;
using MarsQA_1.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace MarsQA_1.Test
    
{
    [TestFixture]
   public class ProfileTest: CommonDriver
    {
            

        [Test, Order (1)]
        public void CreateProfile_Test()
        {
            //Profilepage object initilization and definition
            Homepage Homepageobj = new Homepage(driver);
            Homepageobj.Signin();

            SignInpage SignIapageobj = new SignInpage(driver);
            SignIapageobj.addlogindetail();


            Managedescription managedescriptionobj = new Managedescription(driver);
            managedescriptionobj.addDesc();

            Managelanguage managelanguageobj = new Managelanguage(driver);
            managelanguageobj.addLanguage();

            Manageskill manageskillobj = new Manageskill(driver);
            manageskillobj.Addskill();
            

        }

        [Test, Order(2)]
        public void Editdescription_Test()
        {
            Homepage Homepageobj = new Homepage(driver);
            Homepageobj.Signin();

            SignInpage SignIapageobj = new SignInpage(driver);
            SignIapageobj.addlogindetail();

            Managedescription managedescriptionobj = new Managedescription(driver);
            managedescriptionobj.editDesc();

            Managelanguage managelanguageobj = new Managelanguage(driver);
            managelanguageobj.editLanguage();

            Manageskill manageskillobj = new Manageskill(driver);
            manageskillobj.editSkill();

        }
            [Test,Order (3)]
        public void deleteDescription_Test()
        {
            Homepage Homepageobj = new Homepage(driver);
            Homepageobj.Signin();

            SignInpage SignIapageobj = new SignInpage(driver);
            SignIapageobj.addlogindetail();

            Managedescription managedescriptionobj = new Managedescription(driver);
            managedescriptionobj.delDesc();

            Managelanguage managelanguageobj = new Managelanguage(driver);
            managelanguageobj.deleteLanguage();

            Manageskill manageskillobj = new Manageskill(driver);
            manageskillobj.delSkill();

        }
        



    }
    }

