using System;
using NUnit.Framework;
using System.Configuration;
using DELabsClub.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using Shouldly;
using System.Threading;

namespace DELabsClub.Tests
{
    [TestFixture]
    public class FeatureTests : BaseTest
    {
        [TestCase(TestName = "1. Alert Test"), Order(1)]
        public void OpenBrowser()
        {
            //HomePage home = new HomePage(driver);

            // Gets the URL of the home page from App.config
            url = ConfigurationManager.AppSettings["HomeUrl"];
            log.Info("Got the url from config file");

            // Maximise Window
            driver.Manage().Window.Maximize();
            log.Info("Browser maximized");

            // Navigates to the URL
            driver.Url = url;
            log.Info("Browsing to the URL");

            // Scrolls the page till the bottom
            IJavaScriptExecutor javaScript = (IJavaScriptExecutor)driver;
            javaScript.ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
            log.Info("Scrolling the page till bottom");

            // Finds the 'Contact Us' Button
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            IWebElement btnContact = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("contactUsMail")));
            btnContact.Click();

            // Switch to Alert and accept
            wait.Until(ExpectedConditions.AlertIsPresent());
            IAlert alert = driver.SwitchTo().Alert();
            alert.Text.ShouldBe("You tried contacting us");
            alert.Accept();
        }

        [TestCase(TestName = "2. Modal Test"), Order(2)]
        public void ModalTest()
        {

            // Get the url from the config file
            url = ConfigurationManager.AppSettings["ModalUrl"];

            // Maximises the window and opens the URL
            driver.Manage().Window.Maximize();
            driver.Url = url;

            // Finds the element
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@id='main']/button")));

            // Clicks the button
            element.Text.ShouldBe("Click To Open Modal");
            element.Click();

            // Finds Alert and accepts it
            //wait.Until(ExpectedConditions.AlertIsPresent());
            //IAlert alert = driver.SwitchTo().Alert();
            //alert.Accept();

            // Finds Modal button
            IWebElement modalBtn = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='modal-footer']/button")));
            modalBtn.Click();

            Thread.Sleep(1000);
            Assert.False(modalBtn.Displayed);
        }

        [TestCase(TestName = "3. Actions Test - WIP"), Order(3)]
        public void ActionTest()
        {

        }
    
        [TestCase(TestName ="4. Screenshot Test - WIP"),Order(4)]
        public void ScreenshotTest()
        {

        }

        [TestCase(TestName = "5. Window Test - WIP"), Order(5)]
        public void WindowTest()
        {

        }

        [TestCase("yes", TestName = "6. Logging Test"), Order(6)]
        public void LoggerTest(string str1)
        {
            log.Debug(str1 + "-Debug");
            log.Info(str1 + "-Info");
            log.Warn(str1 + "-Warn");
            log.Error(str1 + "-Error");
            log.Fatal(str1 + "-Fatal");
        }
    }
}
