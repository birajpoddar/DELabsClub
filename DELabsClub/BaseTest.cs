using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DELabsClub
{
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver driver;
        protected string url;

        [SetUp]
        public void SetUp()
        {

        }
        
        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
