// Java JUnit Webdriver Automation Tutorial 03 Writing a Basic Script Using Selenium-Pss-noR4vGc.mp4

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWebDriverTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an instance of webdriver
            IWebDriver driver = new ChromeDriver();

            // go to web page
            driver.Navigate().GoToUrl("http://www.thetestroom.com/webapp");

            // click on the about link
            driver.FindElement(By.Id("about_link")).Click();

            // check that the about page has the about zoo title
		    String title = driver.Title;

            if (title.Equals("About Zoo"))
            {
                Console.WriteLine("Found the about page with the value of " + title);
            }
            else
            {
                Console.WriteLine("Instead found page with: " + title);
            }

            // close the driver
            driver.Close();
        }
    }
}
