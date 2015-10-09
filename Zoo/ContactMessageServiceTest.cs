// Java JUnit Webdriver Automation Tutorial 09 Writing JUnit Test Suites-bF16VXvfJIk.mp4
// Date: 09-21-2015
// Test Suites

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class ContactMessageServiceTest : AbstractWebDriverTest
    {

        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("Contact message test before execution");
        }

        [TearDown]
        public void AbstractShutDown()
        {
            Console.WriteLine("Contact message test after execution");
        }

        [Test]
        public void ShouldBeAbleToSendContactMessage()
        {
            Console.WriteLine("Contact message test execution");
        }
    }
}
