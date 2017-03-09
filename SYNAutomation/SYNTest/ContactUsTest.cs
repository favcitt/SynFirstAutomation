using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SYNAutomation;

namespace SYNTest
{
    [TestClass]
    public class ContactUsTest
    {
        //Inicialize the test before calling the browser
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        //Tested parameters
        [TestMethod]
        public void User_Fills_ContactUs_Page()
        {
            //Go to the CONTACT_US tab
            ContactUsPage.GoTo();

            //Sends the information to each field to be sent.
            ContactUsPage.WithName("John Doe")
                .WithEmail("alias@anonymous.com")
                .WithCompany("Pica Pollo Company")
                .WithMsg("This is a message")
                .SendBotton();

            //Assert.AreEqual(ContactUsPage.IsAt, "Application was sent!", "Application was not sent!");
        }
    }

        
}
