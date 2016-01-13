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

            APP_LOGGER.Info(SelectionHelper.IsSuiteSelected(TestResource.SuitesExcelFilePath, "SuiteA"));
            APP_LOGGER.Info(SelectionHelper.IsSuiteSelected(TestResource.SuitesExcelFilePath, "SuiteB"));
            APP_LOGGER.Info(SelectionHelper.IsSuiteSelected(TestResource.SuitesExcelFilePath, "SuiteC"));
        }

        [Test]
        public void TestSelectionTest()
        {
            APP_LOGGER.Debug(SelectionHelper.IsTestSelected(TestResource.SuiteAExcelFilePath, "Test1"));
            APP_LOGGER.Debug(SelectionHelper.IsTestSelected(TestResource.SuiteAExcelFilePath, "Test2"));
            APP_LOGGER.Debug(SelectionHelper.IsTestSelected(TestResource.SuiteAExcelFilePath, "Test3"));
            APP_LOGGER.Debug(SelectionHelper.IsTestSelected(TestResource.SuiteAExcelFilePath, "Test4"));
            APP_LOGGER.Debug(SelectionHelper.IsTestSelected(TestResource.SuiteAExcelFilePath, "Test5"));
        }

        [Test]
        public void TestDataReadingTest()
        {
            List<Dictionary<string, string>> tdList = SelectionHelper.GetTestData(TestResource.SuiteAExcelFilePath, "Test4");
            foreach (var dict in tdList)
            {
                APP_LOGGER.DebugFormat("Runmode :{0}, Col1 :{1}", dict["Runmode"], dict["Col1"]);

            }
        }



        [Test, TestCaseSource("Test1Data")]
        public void DataDrivenTest1(Dictionary<string, string> dict)
        {
            ValidateRunMode("SuiteA", "Test1", dict["Runmode"]);
            APP_LOGGER.DebugFormat("Runmode :{0}, Col1 :{1}", dict["Runmode"], dict["Col1"]);
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

        //[TestCase(12, 3, 4)]
        //[TestCase(12, 2, 6)]
        //[TestCase(12, 4, 3)]
        //public void DivideTest(int n, int d, int q)
        //{
        //    Console.WriteLine(n + "--" + d + "---" + q);
               
        //}

    }
}