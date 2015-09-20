// Java JUnit Webdriver Automation Tutorial 08 Abstract Test Driver-UhXqp9zKNys.mp4
// Date: 09-19-2015
// Abstract Test Driver
// Test Class: ContactMessageTest.cs

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_Quick_Course_Topics
{
    [TestFixture]
    public class AbstractWebDriverTest
    {
        protected IWebDriver driver;
        protected HomePage onHomePage;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            onHomePage = new HomePage(driver);
            Console.WriteLine("Before in abstract");
        }

        [TearDown]
        public void ShutDown()
        {
            driver.Close();
            Console.WriteLine("After in abstract");
        }
    }
}
