using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTestAutomation.Pages
{
    public class LoginPage : ParentPage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {

        }


        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'ServiceLogin')]")]
        private IWebElement loginButton;

        public void ClickLoginButton()
        {
            loginButton.Click();
        }
    }
}
