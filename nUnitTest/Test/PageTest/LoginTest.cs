using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using NUnit.Allure.Core;
using Allure.Commons;
using NUnit.Allure.Attributes;

namespace nUnitTest.Test.PageTest
{    
    public class LoginTest : WebTest
    {      
        [Test]
        [Category("SampleTag")]
        [Description("Loggeo")]
        [AllureTag("NUnit", "Debug")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureFeature("Core")]
        public void ValidateLogin()
        {
            Console.WriteLine("TEST Loggeo");
            Page.LoginPage().goLoginPage().insertData().validateLogin();
            AllureLifecycle.Instance.WrapInStep(() =>
                {
                    Assert.Pass();
                    //Assert.Equals("I Want to se this on a remote machine", text);
                }, "Google Search"
            );
        }
    }
}
