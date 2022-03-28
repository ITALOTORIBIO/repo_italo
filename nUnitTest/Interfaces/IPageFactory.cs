using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nUnitTest.Interfaces
{
    public interface IPageFactory
    {
        ILoginPage LoginPage();
        IHomePage HomePage();
    }
}
