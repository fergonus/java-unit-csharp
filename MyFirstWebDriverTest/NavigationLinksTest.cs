// Java JUnit Webdriver Automation Tutorial 05 Locators-So66Vcw6IOo.mp4
// Date: 09-13-2015

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWebDriverTest
{
    [TestFixture]
    class NavigationLinksTest
    {

        IWebDriver driver;

        [SetUp]
        public void setUp()
        {
            // create an instance of webdriver
            driver = new ChromeDriver();

            // go to web page
            driver.Navigate().GoToUrl("http://www.thetestroom.com/webapp");
        }

        [TearDown]
        public void tearDown()
        {
            driver.Close();
            // Console.WriteLine("Teardown");
        }

        [Test]
        public void shouldNavigateLinksUsingLocators()
        {
            // click on the about link
            driver.FindElement(By.Id("contact_link")).Click();

            // check that the about page has "About" zoo title
            Assert.IsTrue(driver.FindElement(By.ClassName("subhead")).Text.Equals("Contact Form"));

            // using name locator
            driver.FindElement(By.Name("address_field")).SendKeys("This is address field");

            // using cssSelector locator
		    driver.FindElement(By.CssSelector("#adoption_link")).Click(); 

            // using linkText locator
            driver.FindElement(By.LinkText("HOME")).Click();

            // using partialLinkText locator
            driver.FindElement(By.PartialLinkText("ABO")).Click();

            // using tagName locator
            Assert.IsTrue(driver.FindElement(By.TagName("p")).Text.Contains("animals"));

            // using xpath locator
            driver.FindElement(By.XPath("//*[@id='contact_link']")).Click();
        }

    }
}
