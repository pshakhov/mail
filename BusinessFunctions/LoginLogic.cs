using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using MailTest.BusinessObject;
using MailTest.PageMain;
using System.Threading;

namespace MailTest.BusinessFunctions
{
    class LoginLogic
    {
        private IWebDriver driver;

        public LoginLogic(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void PerformLogin(UserObject uo)
        {
            MainPage page = new MainPage(driver);

            page.loginButton.Click();

            page.SetIdent(uo.SetIdent());
            page.identNextButton.Click();
            Thread.Sleep(2000);

            page.SetPass(uo.SetPass());
            page.passNextButton.Click();
            Thread.Sleep(2000);

            page.mailButton.Click();
            Thread.Sleep(2000);
        }
    }
}

