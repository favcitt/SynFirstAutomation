using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SYNAutomation
{
    public class ContactUsPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("https://synergiesservices.com/contact-us/");
            
            ///Waits until the active element sets to, in this case, the name field box.
            //var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            //wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("name") == "your-name");
        }

        //This returns the parameters for the fluent syntax method.
        public static FieldFilling WithName(string userName)
        {
            return new FieldFilling(userName);
        }
    }

    public class FieldFilling
    {
        //Variable to storage the info used by the test
        private readonly string userName;
        private string userEmail;
        private string userCompany;
        private string userMsg;

        //The constructors for each parameter
        public FieldFilling(string userName)
        {
            this.userName = userName;
        }

        public FieldFilling WithEmail(string userEmail)
        {
            this.userEmail = userEmail;
            return this;
        }

        public FieldFilling WithCompany(string userCompany)
        {
            this.userCompany = userCompany;
            return this;
        }

        public FieldFilling WithMsg(string userMsg)
        {
            this.userMsg = userMsg;
            return this;
        }

        public void SendBotton()
        {
            var nameInput = Driver.Instance.FindElement(By.Name("your-name"));
            nameInput.SendKeys(userName);

            var emailInput = Driver.Instance.FindElement(By.Name("your-email"));
            emailInput.SendKeys(userEmail);

            var companyInput = Driver.Instance.FindElement(By.Name("your-company"));
            companyInput.SendKeys(userCompany);

            var msgInput = Driver.Instance.FindElement(By.Name("your-message"));
            msgInput.SendKeys(userMsg);

            var sendButton = Driver.Instance.FindElement(By.CssSelector(".wpcf7-submit"));
            sendButton.Click();
        }
    }
}
