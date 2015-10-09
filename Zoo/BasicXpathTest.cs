// Java JUnit Webdriver Automation Tutorial 10 Xpath-AiD33piY-sM.mp4
// Date: 10-03-2015

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class BasicXpathTest
    {
        [Test]
        public void XpathTest()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.thetestroom.com/webapp");

            // locate the contact link using xpath and click on it
            driver.FindElement(By.XPath("//a[contains(@id, 'contact_link')]")).Click();

            // Now we are on the "Contact" page
            // locate the name input on "Contact" page using xpath and enter text into it
            driver.FindElement(By.XPath("//input[contains(@name, 'name_field')]")).SendKeys("test name");

            driver.Close();


        }
    }
}
