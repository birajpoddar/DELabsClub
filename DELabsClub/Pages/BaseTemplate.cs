using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DELabsClub.Pages
{
    class BaseTemplate : BasePage
    {
        protected IWebDriver driver;

        public BaseTemplate(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        #region Navigation Elements
        [FindsBy(How = How.XPath, Using = "//nav/*/*/a")]
        protected IWebElement navLogo;

        [FindsBy(How = How.XPath, Using = "//nav/*/*/ul/li[1]/a")]
        protected IWebElement navHome;

        [FindsBy(How = How.XPath, Using = "//nav/*/*/ul/li[2]/a")]
        protected IWebElement navTut;

        [FindsBy(How = How.XPath, Using = "//nav/*/*/ul/li[2]/ul/li[1]/a")]
        protected IWebElement navAngTut;

        [FindsBy(How = How.XPath, Using = "//nav/*/*/ul/li[2]/ul/li[2]/a")]
        protected IWebElement navCsharpTut;

        [FindsBy(How = How.XPath, Using = "//nav/*/*/ul/li[2]/ul/li[3]/a")]
        protected IWebElement navJscriptTut;

        [FindsBy(How = How.XPath, Using = "//nav/*/*/ul/li[3]/a")]
        protected IWebElement navBlog;

        [FindsBy(How = How.XPath, Using = "//nav/*/*/ul/li[4]/a")]
        protected IWebElement navInfi;

        [FindsBy(How = How.XPath, Using = "//nav/*/*/ul/li[5]/a")]
        protected IWebElement navPlay;
        #endregion

        #region Footer Elements
        [FindsBy(How = How.XPath, Using = "//footer/*/*/div[2]/ul/li[1]/a")]
        protected IWebElement footerHome;

        [FindsBy(How = How.XPath, Using = "//footer/*/*/div[2]/ul/li[2]/a")]
        protected IWebElement footerSign;

        [FindsBy(How = How.XPath, Using = "//footer/*/*/div[2]/ul/li[3]/a")]
        protected IWebElement footerDownload;

        [FindsBy(How = How.XPath, Using = "//footer/*/*/div[3]/ul/li[1]/a")]
        protected IWebElement footerInfo;

        [FindsBy(How = How.XPath, Using = "//footer/*/*/div[3]/ul/li[2]/a")]
        protected IWebElement footerContact;

        [FindsBy(How = How.XPath, Using = "//footer/*/*/div[3]/ul/li[3]/a")]
        protected IWebElement footerReview;

        [FindsBy(How = How.XPath, Using = "//footer/*/*/div[4]/ul/li[1]/a")]
        protected IWebElement footerFaq;

        [FindsBy(How = How.XPath, Using = "//footer/*/*/div[4]/ul/li[2]/a")]
        protected IWebElement footerHelp;

        [FindsBy(How = How.XPath, Using = "//footer/*/*/div[4]/ul/li[3]/a")]
        protected IWebElement footerForum;

        [FindsBy(How = How.XPath, Using = "//footer/*/*/div[5]/div/a[1]")]
        protected IWebElement footerSocTwit;

        [FindsBy(How = How.XPath, Using = "//footer/*/*/div[5]/div/a[2]")]
        protected IWebElement footerSocFbook;

        [FindsBy(How = How.XPath, Using = "//footer/*/*/div[5]/div/a[3]")]
        protected IWebElement footerSocGplus;

        [FindsBy(How = How.XPath, Using = "//footer/*/*/div[5]/button")]
        protected IWebElement footerSocContact;
        #endregion
    }
}
