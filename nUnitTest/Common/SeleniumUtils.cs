using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using nUnitTest.Driver;
using nUnitTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nUnitTest.Common
{
    public class SeleniumUtils : ISeleniumUtils, IControlLocator
    {
        private readonly IWebDriver _driver;
        WebDriverWait wait;
        public SeleniumUtils(IWebDriver driver)
        {
            _driver = driver;
            wait = new WebDriverWait(driver,TimeSpan.FromSeconds(50));
        }

		public void NavigateToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
            DriverActions.TakeTestScreenShot(_driver, "NavigateToUrl");
        }

        public string getText(By element)
        {            
            IWebElement webElement = wait.Until(_driver => _driver.FindElement(element));
            return webElement.Text;
        }

        public String getText(String str)
        {
            IWebElement element = wait.Until(driver => driver.FindElement(By.XPath(str)));
            return element.Text;
        }

		public void click(By element)
		{
			IWebElement webElement = wait.Until(_driver => _driver.FindElement(element));
			webElement.Click();
		}

		public void click(String Xpath)
		{
			IWebElement webElement = wait.Until(_driver => _driver.FindElement(By.XPath(Xpath)));
			webElement.Click();
		}

		public void setText(By element, String text)
		{
			IWebElement webElement = wait.Until(_driver => _driver.FindElement(element));
			webElement.SendKeys(text);
		}

		public void mouseOver(String Xpath)
		{
			IWebElement webElement = wait.Until(_driver => _driver.FindElement(By.XPath(Xpath)));
			Actions builder = new Actions(_driver);
			builder.MoveToElement(webElement).Perform();
		}

		public void mouseOver(By element)
		{
			IWebElement webElement = wait.Until(_driver => _driver.FindElement(element));
			Actions builder = new Actions(_driver);
			builder.MoveToElement(webElement).Perform();
		}


		public IList<IWebElement> getElements(By elements)
		{
			IList<IWebElement> webElements = wait.Until(_driver => _driver.FindElements(elements));
            return webElements;
		}
		

        public IWebDriver GetDriver()
        {
            return _driver;
        }

    }
}
