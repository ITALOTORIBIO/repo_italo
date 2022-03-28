using nUnitTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nUnitTest.Interfaces
{
    public interface ILoginPage : IPages
    {
        LoginPage goLoginPage();
        LoginPage insertData();
        void validateLogin();
    }
}
