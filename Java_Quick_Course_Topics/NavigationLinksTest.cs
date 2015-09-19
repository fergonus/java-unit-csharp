// Java JUnit Webdriver Automation Tutorial 05 Locators-So66Vcw6IOo.mp4

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
    class NavigationLinksTest
    {
        IWebDriver driver;

        [SetUp]
        public void TestSetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://thetestroom.com/webapp");
        }

        [TearDown]
        public void TestShutDown()
        {
            driver.Close();
        }

        [Test]
        public void UsingLocators()
        {
            driver.FindElement(By.Id("contact_link")).Click();

            // check that the about page has the zoo title
            Assert.IsTrue(driver.FindElement(By.ClassName("subhead")).Text.Equals("Contact Form"));

            // using name locator
            driver.FindElement(By.PartialLinkText("ABO")).Click();
        }
    }
}
