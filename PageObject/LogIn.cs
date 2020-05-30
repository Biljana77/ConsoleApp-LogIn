using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System.Collections.ObjectModel;
using System.Threading;

namespace ConsoleApp_LogIn.PageObject
{
    class LogIn
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public LogIn (IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }
        public IWebElement Username
        {
            get
            {
                IWebElement element;
                try
                {
                    element = this.driver.FindElement(By.Name("username"));
                }
                catch (Exception)
                {
                    element = null;
                }
                return element;
            }
        }
             public IWebElement Password
        {
            get
            {
                IWebElement element;
                try
                {
                    element = this.driver.FindElement(By.Name("password"));
                }
                catch (Exception)
                {
                    element = null;
                }
                return element;
            }
        }
        public IWebElement RegButton
        {
            get
            {
                IWebElement element;
                try
                {
                    element = this.driver.FindElement(By.Name("login"));
                }
                catch (Exception)
                {
                    element = null;
                }
                return element;
            }
        }
    }
    
}
