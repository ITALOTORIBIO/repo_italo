using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nUnitTest.Interfaces
{
    public interface ISeleniumUtils
    {
        string getText(By element);
        public String getText(String str);
        void click(By element);
        void click(String Xpath);
        void setText(By element, String text);
        void mouseOver(String Xpath);
        void mouseOver(By element);
        IList<IWebElement> getElements(By elements);

        public IWebDriver GetDriver();
    }
}
