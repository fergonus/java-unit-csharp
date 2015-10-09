using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebDriverFramework
{
    [TestFixture]
    class WebAppTest : AbstractTestDriver
    {
        [Test]
        public void ShouldPerformSimpleClick()
        {
            HomePage homePage = new HomePage(driver);
            homePage
                .NavigateToWebApp()
                .NavigateToContactPage()
                .NavigateToHomePage();
        }
    }
}
