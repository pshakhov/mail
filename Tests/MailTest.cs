using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using MailTest.BusinessObject;
using MailTest.TestData;
using MailTest.BusinessFunctions;
using MailTest.PageMail;
using TechTalk.SpecFlow;

namespace MailTest.Test
{
    [Binding]
    //[TestClass]
    public class MailTest
    {

        public static IWebDriver driver;
        // private static IWebDriver driver;

        [Given(@"I open browser")]
        //[AssemblyInitialize()]
        public static void GivenIOpenBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [When(@"I open ""(.*)"" url")]
        //[TestMethod]
        public void WhenIOpenUrl(string p0)
        {
            driver.Url = "http://google.ru";
        }

        //[TestMethod]
        [Then(@"Title contains ""(.*)"" text")]
        public void ThenTitleContainsText(string p0)
        {
            string pageTitle = driver.Title;
            Assert.IsTrue(pageTitle.Contains("Google"), "Title is incorrect or not present");
        }

        //[TestMethod]
        bool IsElementPresentMethod(By locator)
        {
            try
            {
                driver.FindElement(locator);
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
            return true;
        }

        [When(@"I login by user credentials")]
        public void WhenILoginByUserCredentials()
        {
            Thread.Sleep(2000);

            UserObject uo = UserDataGenerator.GenerateUser();
            new LoginLogic(driver).PerformLogin(uo);

            Assert.IsTrue(IsElementPresentMethod(By.XPath(".//*[@title='Notes']")));
        }

        //[TestMethod]
        [Then(@"I logout from mail")]
        public void ThenILogoutFromMail()
        {
            MailPage page = new MailPage(driver);
            page.LogoutMethod();

            Assert.IsTrue(IsElementPresentMethod(By.Id("headingText")));
        }

        //[AssemblyCleanup()]
        [AfterScenario]
        public static void cleanUp()
        {
            driver.Close();
        }

    }  
}



