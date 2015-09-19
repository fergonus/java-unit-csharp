// Java JUnit Webdriver Automation Tutorial 07 Page Object-pO5Ry_GLC60.mp4
// Page Object

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_Quick_Course_Topics
{
    public class ContactResultPage : AbstractPage
    {
        public ContactResultPage(IWebDriver driver) : base(driver)
        {
        }

        public string GetConfirmationMessage()
        {
            return driver.FindElement(By.TagName("p")).Text;
        }
    }
}
