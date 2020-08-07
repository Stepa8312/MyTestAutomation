using MyTestAutomation.Tests.parentTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTestAutomation.Tests.login
{
    class ValidLogin : ParentTest
    {
        [Test]
        public void LaunchApp()
        {

            loginPage.ClickLoginButton();

        }
    }
}
