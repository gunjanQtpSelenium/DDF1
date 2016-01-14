using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestAutomation
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    class SeleniumBasedTests : TestCaseBase
    {
        [Test, TestCaseSource(typeof(TestCaseBase), "BrowserData")]
        public void GoogleTest(string browserName)
        {
            RunTest(browserName, "http://google.com");
        }
    }
}
