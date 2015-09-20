// Java JUnit Webdriver Automation Tutorial 07 Page Object-pO5Ry_GLC60.mp4
// Page Object

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
    public class ContactMessageTest : AbstractWebDriverTest
    {
        IWebDriver driver;

        [SetUp]
        public void TestSetUp()
        {
            onHomePage.navigateToWebApp();
            Console.WriteLine("Before in test");
        }

        //[TearDown]
        //public void TestShutDown()
        //{
        //    driver.Close();
        //}

        [Test]
        public void ShouldSendContactMessage()
        {
            // HomePage onHomePage = new HomePage(driver);
            // onHomePage = onHomePage.NavigateToWebApp();
            ContactPage onContactPage = onHomePage.ClickOnContact();
            System.Threading.Thread.Sleep(5000);
            ContactResultPage onResultPage = onContactPage.FillFormWithData().SubmitForm();
            System.Threading.Thread.Sleep(5000);
            Assert.IsTrue(onResultPage.GetConfirmationMessage().Contains("Many thanks for your message"),"Test passed");
        }
    }
}
