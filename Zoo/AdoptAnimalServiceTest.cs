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
    class AdoptAnimalServiceTest : AbstractWebDriverTest
    {

        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("Adoption test before execution");
        }

        [TearDown]
        public void AbstractShutDown()
        {
            Console.WriteLine("Adoption test after execution");
        }

        [Test]
        public void ShouldBeAbleToAdoptAnAnimal()
        {
            Console.WriteLine("Adoption test execution");
        }
    }
}
