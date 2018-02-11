using System;
using NUnit.Framework;
using System.Configuration;
using DELabsClub.Pages;
using OpenQA.Selenium;

namespace DELabsClub
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            IWebDriver driver;

            HomePage home = new HomePage(driver);
            
        }
    }
}
