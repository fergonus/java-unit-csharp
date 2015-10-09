// Java JUnit Webdriver Automation Tutorial 11 CssSelector-Xbfd-la6f_U.mp4
// Date: 10-03-2015

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class CssSelectorTest
    {
        [Test]
        public void CssTest()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.thetestroom.com/webapp");

            // By id
            driver.FindElement(By.CssSelector("#contact_link")).Click();

            // On "Contact" page
            // node or tag
            Console.WriteLine(driver.FindElement(By.CssSelector("p")).Text);

            // By class
            driver.FindElement(By.CssSelector(".home")).Click();

            // On "Home" page
            // Attribute expression
            driver.FindElement(By.CssSelector("[href='adoption.html']")).Click();

            // Now on "Adoption" page
            driver.Close();
        }
    }
}
