using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace DELabsClub.Tests
{
    [TestFixture]
    public class BaseTest : BaseLogger
    {
        protected IWebDriver driver;
        protected string url;
        protected WebDriverWait wait;

        [OneTimeSetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }
        
        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
