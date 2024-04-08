using Allure.Net.Commons;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMTestFramework.Base
{
    public abstract class BaseTest
    {
        protected IWebDriver driver;

        protected const string BaseUrl = "https://demo.1crmcloud.com/";

        //protected HomePage homePage;

        [OneTimeSetUp]
        public void GlobalSetup()
        {

        }

        [SetUp]
        public virtual void SetUp()
        {

        }

        [TearDown]
        public virtual void TearDown()
        {

            driver.Dispose();
        }

        [OneTimeTearDown]
        public virtual void GlobalTearDown()
        {
            
        }

        public void SaveAndLoadCookies()
        {
            var cookies = driver.Manage().Cookies.AllCookies;

            foreach (var cookie in cookies)
            {
                driver.Manage().Cookies.AddCookie(cookie);
            }

            driver.Navigate().Refresh();
        }
    }
}
