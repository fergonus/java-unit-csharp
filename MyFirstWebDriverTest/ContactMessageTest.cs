// Java JUnit Webdriver Automation Tutorial 06 JUnit Assertions-DCbxx67vfmo.mp4
// Assertions
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
    class ContactMessageTest
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
        public void shouldSendValidMessage()
        {
            Click(By.Id("contact_link"));
            Assert.IsTrue(driver.Title.Equals("Contact"));

            Type(By.Name("name_field"), "test name");
            Type(By.Name("address_field"), "test address");
            Type(By.Name("postcode_field"), "test postcode");
            Type(By.Name("email_field"), "test email");

            Assert.IsFalse(!(driver.FindElement(By.Name("name_field")).Text.Equals("")));

            Click(By.Id("submit_message"));
            Assert.AreEqual(driver.Title, "Contact Confirmation");

        }

        public void Type(By by, String value)
	    {
		    driver.FindElement(by).SendKeys(value);
	    }
	
	    public void Click(By by)
	    {
		    driver.FindElement(by).Click();
	    }
    }
}
