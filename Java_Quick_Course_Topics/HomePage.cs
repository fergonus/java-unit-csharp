// Java JUnit Webdriver Automation Tutorial 07 Page Object-pO5Ry_GLC60.mp4
// Page Object

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_Quick_Course_Topics
{
    public class HomePage : AbstractPage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public HomePage navigateToWebApp()
        {
            driver.Navigate().GoToUrl("http://thetestroom.com/webapp");
            return new HomePage(driver);
        }

        public ContactPage ClickOnContact()
        {
            driver.FindElement(By.Id("contact_link")).Click();
            return new ContactPage(driver);
        }
    }
}
