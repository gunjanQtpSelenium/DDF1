using System;
using NUnit.Framework;
using DataDrivenFramework;

namespace TestAutomation
{
    [TestFixture]
    public class UnitTests
    {

        [Test]
        public void SuiteSelectionTest()
        {

            Console.WriteLine(SelectionHelper.IsSuiteSelected("C:\\Users\\a\\Desktop\\DDF1\\Module_20\\TestAutomation\\TestData\\Suite.xlsx", "SuiteA"));
            Console.WriteLine(SelectionHelper.IsSuiteSelected("C:\\Users\\a\\Desktop\\DDF1\\Module_20\\TestAutomation\\TestData\\Suite.xlsx", "SuiteB"));
            Console.WriteLine(SelectionHelper.IsSuiteSelected("C:\\Users\\a\\Desktop\\DDF1\\Module_20\\TestAutomation\\TestData\\Suite.xlsx", "SuiteC"));


        }

        [Test]
        public void TestSelectionTest()
        {
            Console.WriteLine(SelectionHelper.IsTestSelected("C:\\Users\\a\\Desktop\\DDF1\\Module_20\\TestAutomation\\TestData\\SuiteA.xlsx", "Test1"));
            Console.WriteLine(SelectionHelper.IsTestSelected("C:\\Users\\a\\Desktop\\DDF1\\Module_20\\TestAutomation\\TestData\\SuiteA.xlsx", "Test2"));
            Console.WriteLine(SelectionHelper.IsTestSelected("C:\\Users\\a\\Desktop\\DDF1\\Module_20\\TestAutomation\\TestData\\SuiteA.xlsx", "Test3"));
            Console.WriteLine(SelectionHelper.IsTestSelected("C:\\Users\\a\\Desktop\\DDF1\\Module_20\\TestAutomation\\TestData\\SuiteA.xlsx", "Test4"));
            Console.WriteLine(SelectionHelper.IsTestSelected("C:\\Users\\a\\Desktop\\DDF1\\Module_20\\TestAutomation\\TestData\\SuiteA.xlsx", "Test5"));


        }

    }
}