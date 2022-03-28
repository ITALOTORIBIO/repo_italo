using OpenQA.Selenium;
using nUnitTest.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using nUnitTest.Pages;
using nUnitTest.Pages.Base;
using Autofac;
using nUnitTest.Interfaces;
using nUnitTest.Configuration;
using NUnit.Allure.Core;
using Allure.Commons;
using NUnit.Framework.Interfaces;

namespace nUnitTest.Test
{
    [TestFixture]
    [AllureNUnit]
    public class WebTest
    {
        public IWebDriver driver;
        DriverFactory driverFactory;
        protected IPageFactory Page;
        string hubUrl;
        //protected SearchPage? search;
        //protected PurchasePage? purchase;

        [SetUp]
        public void Setup()
        {
            driverFactory = new DriverFactory();
            //driverFactory.getDriverBrowser(config_properties.browser);
            //driver = driverFactory.getDriver();
            AllureLifecycle.Instance.CleanupResultDirectory();
            hubUrl = "http://localhost:4444/wd/hub";
            driver = driverFactory.CreateInstance(Enum.BrowserType.Chrome, hubUrl);
            driver.Manage().Window.Maximize();           

            var container = new ContainerBuilder().Register(driver);
            Page = new PichonPageFactory(container.Build());
        }


        [TearDown]
        public void TearDown()
        {
           //driverFactory.tearDown();
           driver.Close();
        }

        
    }
}
