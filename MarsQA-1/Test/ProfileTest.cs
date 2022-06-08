using MarsQA_1.pages;
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

            Profilepage Profilepageobj = new Profilepage();
            Profilepageobj.CreateProfile(driver);

        }
        [Test,Order (2)]
        public void EditProfile_Test()
        {
            //Edit Profile
            Profilepage Profilepageobj = new Profilepage();
            Profilepageobj.EditProfile(driver, "Edited ", "Hindi", "Native","Edited Skill","Expert");
        }
        [Test,Order (3)]
        public void DeleteProfile_Test()
        {
            //Detete Profile
            Profilepage Profilepageobj = new Profilepage();
            Profilepageobj.DeleteProfile(driver);

        }
        


    }
    }

