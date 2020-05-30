using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System.Collections.ObjectModel;
using System.Threading;
using ConsoleApp_LogIn.PageObject;

namespace ConsoleApp_LogIn
{
    class Test
    {
        IWebDriver driver;
        WebDriverWait wait;
        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
        [Test]
        public void TestLogIn()
        {
            HomePage naslovna = new HomePage(driver);
            LogIn registracija;
            naslovna.GoToPage();
            registracija = naslovna.SignButton();
            registracija.Username.SendKeys("ppetar");
            registracija.Password.SendKeys("pppetar");
            registracija.RegButton.Click();
        }
    }
}
