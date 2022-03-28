using NUnit.Framework;
using OpenQA.Selenium;
using nUnitTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Allure.Core;
using Allure.Commons;

namespace nUnitTest.Pages
{
    public class LoginPage : WebPage, ILoginPage
    {
        public LoginPage(ISeleniumUtils seleniumUtils, IControlLocator controlLocator) : base(seleniumUtils, controlLocator)
        {
        }

        public string Brand => "generic";    
        private string url = "https://phptravels.org/login";

        private string email_user = "italo@gmail.com";
        private string pass_user = "It@lo04";
        
        //WebElements

        private By tB_emailUser = By.XPath("//input[@id='inputEmail']");
        private By tB_passUser = By.XPath("//input[@id='inputPassword']");
        private By b_Login = By.XPath("//input[@id='login']");

        private string Dashboard = "/html/body/div[2]/div[1]/div/div/div/div[1]/div/div";


        //Methods

        public LoginPage goLoginPage()
        {
            _controlLocator.NavigateToUrl(url);
            return new LoginPage(_seleniumUtils,_controlLocator);
        }


        public LoginPage insertData()
        {
            _seleniumUtils.setText(tB_emailUser, email_user);
            _seleniumUtils.setText(tB_passUser, pass_user);
            _seleniumUtils.click(b_Login);
            return new LoginPage(_seleniumUtils,_controlLocator);
        }

        public void validateLogin()
        {
            var textConfirmLogin = _seleniumUtils.getText(Dashboard);
            AllureLifecycle.Instance.WrapInStep(() =>
            {
                Assert.AreEqual("Please complete the captcha and try again.", textConfirmLogin);
            }, "Please complete the captcha and try again.");


        }
    }
}
