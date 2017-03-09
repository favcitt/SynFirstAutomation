using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYNAutomation
{
    //This class helps to "globalize" the call and entry proceadure to a webpage.
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            //Solves the problem with the GECKODRIVER when webpage is called.
            Instance = new FirefoxDriver(FirefoxDriverService.CreateDefaultService("C:\\Users\\Satellite\\Documents\\Visual Studio 2015\\Projects\\SYNAutomation\\SYNAutomation\\bin\\Debug", "geckodriver.exe"));

            //And implicit wait to smooth the 'call' of the browser.
            Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }
    }
}
