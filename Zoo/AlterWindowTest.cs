// Java JUnit Webdriver Automation Tutorial 12 Pop-ups and Windows-jMpMk6YxgAY.mp4
// Date: 10-03-2015
// Alerts and Popup windows

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
    class AlterWindowTest
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.thetestroom.com/webapp");
        }

        [TearDown]
        public void ShutDown()
        {
            driver.Close();
        }

        [Test]
        public void AlertTest()
        {
            // Go to "Contact" page
            driver.FindElement(By.Id("contact_link")).Click();

            // Now on "Contact" page
            driver.FindElement(By.Id("submit_message")).Click();

            System.Threading.Thread.Sleep(1000);

            // Create an alert
            IAlert alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);

            // Verify that we are on the alert page
            Assert.True(alert.Text.Contains("Name"));

            // Click the accept button
            alert.Accept();
        }

        [Test]
        public void WindowTest()
        {
            // Get and save the current window
            string parentWindow = driver.CurrentWindowHandle;

            // Click on the 'Terms" link to get a popup
            driver.FindElement(By.Id("footer_term")).Click();

            // loop through all the windows
            foreach(string currentWindow in driver.WindowHandles)
            {
                driver.SwitchTo().Window(currentWindow);
            }

            Console.WriteLine(driver.Url);

            driver.Close();

            // switch back to the previous window
            driver.SwitchTo().Window(parentWindow);

            // Verify we are on the previous window
            Console.WriteLine(driver.Url);
        }

    }
}
