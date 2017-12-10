using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;

namespace MailTest.PageMain
{
    class MainPage
    {
        private IWebDriver driver;
        public MainPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        [FindsBy(How = How.Id, Using = "gb_70")]
        public IWebElement loginButton;

        public void ClickTo()
        {
            new Actions(driver).Click().
                    Build().
                    Perform();
        }

        [FindsBy(How = How.Id, Using = "gb_71")]
        public IWebElement logoutButton;

        [FindsBy(How = How.Name, Using = "identifier")]
        public IWebElement identField;

        public void SetIdent(string text)
        {
            new Actions(driver).SendKeys(identField, text).
                Build().
                Perform();
        }

        [FindsBy(How = How.Id, Using = "identifierNext")]
        public IWebElement identNextButton;

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement passField;

        public void SetPass(string text)
        {
            new Actions(driver).SendKeys(passField, text).
                Build().
                Perform();
        }

        [FindsBy(How = How.Id, Using = "passwordNext")]
        public IWebElement passNextButton;

        [FindsBy(How = How.XPath, Using = "//div[@id='searchform']/div/div/div/div/div[1]/div[2]/a")]
        public IWebElement mailButton;
    }
}
