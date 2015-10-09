
// Java JUnit Webdriver Automation Tutorial 15 Page Factory-u8XH46u1QAw.mp4
// Date: 10-04-2015
// Page Factory

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebDriverFramework
{
    public class HomePage : AbstractPage
    {
        [FindsBy(How = How.Name, Using = "nav_contact")]
        private IWebElement contactPageLink;

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public ContactPage NavigateToContactPage()
        {
            driver.Navigate().GoToUrl("http://www.thetestroom.com/webapp");
            ContactPage contactPage = new ContactPage(driver);
            PageFactory.InitElements(driver, contactPage);
            return contactPage;
        }

    }
}
