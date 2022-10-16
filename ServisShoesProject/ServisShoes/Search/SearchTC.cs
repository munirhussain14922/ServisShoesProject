using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.Search
{
    [TestClass]
    public class SearchTC : Basepage
    {
        #region Setup and Cleanup
        public TestContext instance;

        public TestContext TestContext

        {

            set { instance = value; }

            get { return instance; }

        }
        [ClassInitialize]
        public static void ClassInitialize(TestContext TestContext)
        {

            ExtentReport.LogReport("Extent Report");
        }
        [ClassCleanup]
        public static void ClassCleanUp()
        {
            ExtentReport.extentReports.Flush();
        }
        [TestInitialize()]
        public void TestInit()
        {
            SeleniumInit("Chrome");
        }

        [TestCleanup()]
        public void TestCleanUp()
        {
            CloseDriver();
        }
        #endregion
        #region Test Case 1
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Testdata.xml", "SearchWithinValid", DataAccessMethod.Sequential)]

        public void SearchWithValid()
        {
            OpenUrl();
            maxwindow();
            scroll();
            Search searchmthfun = new Search();
            ExtentReport.exChildTest = ExtentReport.extentReports.CreateTest("Search With Valid");

            ExtentReport.exChildTest.Log(Status.Pass, "Click Search Bar");

            String searchproname = TestContext.DataRow["keyword"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Keyword");
            ExtentReport.exChildTest.Log(Status.Pass, "Click Enter");
            ExtentReport.exChildTest.Log(Status.Pass, "Check Stock In");

            String priceto = TestContext.DataRow["priceto"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Price TO");

            String priceFrom = TestContext.DataRow["pricefrom"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Price From");
            ExtentReport.exChildTest.Log(Status.Pass, "Check Brand");
            ExtentReport.exChildTest.Log(Status.Pass, "Check Brand2");
            ExtentReport.exChildTest.Log(Status.Pass, "Check Brand3");
            ExtentReport.exChildTest.Log(Status.Pass, "Check Color");

            String expected = TestContext.DataRow["message"].ToString();

            searchmthfun.search(searchproname, priceto, priceFrom);
            String actual = driver.FindElement(By.Id("ProductCount")).Text;
            Assert.AreEqual(expected, actual);
        }
        #endregion

    }
}
