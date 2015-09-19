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
    public class ContactPage : AbstractPage
    {
        public ContactPage(IWebDriver driver) : base(driver)
        {
        }

        public ContactPage FillFormWithData()
        {
            driver.FindElement(By.Name("name_field")).SendKeys("test_name");
            driver.FindElement(By.Name("address_field")).SendKeys("test_address");
            driver.FindElement(By.Name("postcode_field")).SendKeys("test_postcode");
            driver.FindElement(By.Name("email_field")).SendKeys("test_email");
            return new ContactPage(driver);
        }

        public ContactResultPage SubmitForm()
        {
            driver.FindElement(By.Id("submit_message")).Click();
            return new ContactResultPage(driver);
        }
    }
}
