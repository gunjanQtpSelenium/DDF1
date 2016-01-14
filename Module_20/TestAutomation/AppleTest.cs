using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    class AppleSeleniumTest : TestCaseBase
    {
        [Test,TestCaseSource(typeof(TestCaseBase),"BrowserData")]
        public void AppleTest(string browserName)
        {
            RunTest(browserName, "http://apple.com");
        }
    }
}
