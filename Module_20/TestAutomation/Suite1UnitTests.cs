using System;
using NUnit.Framework;
using DataDrivenFramework;
using System.Collections.Generic;


namespace TestAutomation
{
    [TestFixture]
    public class Suite1UnitTests : TestCaseBase
    {

        [Test]
        public void SuiteSelectionTest()
        {
          
            Console.WriteLine(SelectionHelper.IsSuiteSelected(TestResource.SuitesExcelFilePath, "SuiteA"));
            Console.WriteLine(SelectionHelper.IsSuiteSelected(TestResource.SuitesExcelFilePath, "SuiteB"));
            Console.WriteLine(SelectionHelper.IsSuiteSelected(TestResource.SuitesExcelFilePath, "SuiteC"));
        }

        [Test]
        public void TestSelectionTest()
        {
            Console.WriteLine(SelectionHelper.IsTestSelected(TestResource.SuiteAExcelFilePath, "Test1"));
            Console.WriteLine(SelectionHelper.IsTestSelected(TestResource.SuiteAExcelFilePath, "Test2"));
            Console.WriteLine(SelectionHelper.IsTestSelected(TestResource.SuiteAExcelFilePath, "Test3"));
            Console.WriteLine(SelectionHelper.IsTestSelected(TestResource.SuiteAExcelFilePath, "Test4"));
            Console.WriteLine(SelectionHelper.IsTestSelected(TestResource.SuiteAExcelFilePath, "Test5"));
        }

        [Test]
        public void TestDataReadingTest()
        {
            List<Dictionary<string, string>> tdList = SelectionHelper.GetTestData(TestResource.SuiteAExcelFilePath, "Test4");
            foreach (var dict in tdList)
            {
                Console.WriteLine("Runmode :{0}, Col1 :{1}", dict["Runmode"], dict["Col1"]);

            }
        }

      

        [Test, TestCaseSource("Test1Data")]
        public void DataDrivenTest1(Dictionary<string, string> dict)
        {
            ValidateRunMode("SuiteA", "Test1", dict["Runmode"]);
            Console.WriteLine("Runmode :{0}, Col1 :{1}", dict["Runmode"], dict["Col1"]);
        }

        //DATA SOURCE
        public static IEnumerable<Dictionary<string, string>> Test1Data()
        {
            List<Dictionary<string, string>> tdList = SelectionHelper.GetTestData(TestResource.SuiteAExcelFilePath, "Test1");
            foreach (var dict in tdList)
            {
                yield return dict;
            }
        }

    }
}