// Java JUnit Webdriver Automation Tutorial 15 Page Factory-u8XH46u1QAw.mp4
// Date: 10-04-2015
// Page Factory

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebDriverFramework
{
    public class AbstractPage
    {
        protected IWebDriver driver;

        public AbstractPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebDriver GetDriver()
        {
            return driver;
        }

        public HomePage NavigateToWebApp()
        {
            driver.Navigate().GoToUrl("http://www.thetestroom.com/webapp");
            return new HomePage(driver);
        }
    }
}
