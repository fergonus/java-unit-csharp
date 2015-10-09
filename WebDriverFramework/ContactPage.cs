// Java JUnit Webdriver Automation Tutorial 15 Page Factory-u8XH46u1QAw.mp4
// Date: 10-05-2015
// Page Factory

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverFramework
{
    public class ContactPage : AbstractPage
    {
        //HomePage homePage = new HomePage(driver);
        [FindsBy(How = How.Name, Using = "nav_home")]
        private IWebElement contactPageLink;

        public ContactPage(IWebDriver driver) : base(driver)
        {
        }

        public HomePage NavigateToHomePage()
        {
            driver.Navigate().GoToUrl("http://www.thetestroom.com/webapp");
            HomePage homePage = new HomePage(driver);
            PageFactory.InitElements(driver, homePage);
            return homePage;
        }
    }
}
