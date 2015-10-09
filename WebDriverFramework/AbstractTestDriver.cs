using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace WebDriverFramework
{
    class AbstractTestDriver
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
