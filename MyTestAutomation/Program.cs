using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyTestAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com.ua");
            Console.ReadKey();
            driver.Quit();
        }
    }
}
