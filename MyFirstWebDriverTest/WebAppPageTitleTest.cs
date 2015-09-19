using NUnit.Framework;
// Java JUnit Webdriver Automation Tutorial 04 Writing a Basic JUnit Script Using Selenium-tpaUr4N7eVI.mp4
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
    class WebAppPageTitleTest
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
        public void shouldHavePageTitleOfAboutPage()
	    {
		
		    // click on the about link
		    driver.FindElement(By.Id("about_link")).Click();
		
		    // check that the about page has the about zoo title
		    Assert.AreEqual("About Zoo", driver.Title);
            Console.WriteLine(driver.Title);
	    }

        [Test]
        public void shouldHavePageTitleOfContact()
	    {
		
		    // click on the about link
		    driver.FindElement(By.Id("contact_link")).Click();
		
		    // check that the about page has the about zoo title
            Assert.AreEqual("Contact", driver.Title);
            Console.WriteLine(driver.Title);		
	    }
    }
}
