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

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();

        }

        [Test]
        public void LaunchApp()
        {
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.google.com.ua/");

        }

        [TearDown]
        public void ShutDown()
        {
            driver.Close();
        }
    }
}

