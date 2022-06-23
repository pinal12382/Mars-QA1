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
   internal class ProfileTest: CommonDriver
    {
        
             
        [Test, Order (1)]
        public void CreateProfile_Test()
        {
            //Profilepage object initilization and definition
            Homepage Homepageobj = new Homepage (driver);
            Homepageobj.Signin();

            SignInpage SignIapageobj = new SignInpage (driver);
            SignIapageobj.addlogindetail();



            Managedescription managedescriptionobj = new Managedescription(driver);
            managedescriptionobj.addDesc();

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

        }
        


    }
    }

