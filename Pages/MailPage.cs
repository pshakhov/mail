using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;

namespace MailTest.PageMail
{

    class MailPage
    {
        private IWebDriver driver;
        public MailPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        [FindsBy(How = How.XPath, Using = "//*[@title='Notes'")]
        public IWebElement Notes;

        public void LogoutMethod()
        {
            driver.Url = "https://accounts.google.com/logout?";
        }
    }
}