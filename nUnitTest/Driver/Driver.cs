using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nUnitTest.Driver
{
    abstract class Driver
    {
        public IWebDriver? driver;
        public abstract void initDriver();
        public abstract void destroyDriver();
        public abstract IWebDriver returnDriver();
    }
}
