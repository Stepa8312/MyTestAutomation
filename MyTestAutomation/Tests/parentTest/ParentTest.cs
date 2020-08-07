using MyTestAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTestAutomation.Tests.parentTest
{
    class ParentTest
    {
        IWebDriver driver;
        protected LoginPage loginPage;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com.ua/");

            loginPage = new LoginPage(driver);
        }

        [TearDown]
        public void ShutDown()
        {
            driver.Close();
        }
    }
}

