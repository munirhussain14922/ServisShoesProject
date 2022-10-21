using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.Sroting
{
    [TestClass]
    public class SortingTc : Basepage
    {
        #region Setup and Cleanup
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


        #region Sorting Test Case
        [TestMethod]
        public void SortingWithFeature()
        {
            OpenUrl();
            maxwindow();
            Sorting sort = new Sorting();
            ExtentReport.exChildTest = ExtentReport.extentReports.CreateTest("Soriting With Valid Feature");

            ExtentReport.exChildTest.Log(Status.Pass, "Hover Over New Arrivals");
            ExtentReport.exChildTest.Log(Status.Pass, "Click Men");

            sort.sorintg("manual");
            ExtentReport.exChildTest.Log(Status.Pass, "Select Feature");

            IWebElement actual = driver.FindElement(By.XPath("(//option[text()='Featured'])[1]"));


            Assert.AreEqual(true, actual.Selected);


            #endregion

        }
    }
}
