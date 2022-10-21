using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.Logout
{
    [TestClass]
    public class LogoutTC : Basepage
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


        #region Logout Test case

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Testdata.xml", "LogoutWithValid", DataAccessMethod.Sequential)]
        public void LogoutTC_1()
        {
            OpenUrl();
            maxwindow();
            logout logoutb = new logout();
            ExtentReport.exChildTest = ExtentReport.extentReports.CreateTest("Logout With Valid");

            String username = TestContext.DataRow["username"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter UserName");

            String password = TestContext.DataRow["password"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Password");

            String msg = TestContext.DataRow["message"].ToString();
            logoutb.Logoutfunction(username, password);
            ExtentReport.exChildTest.Log(Status.Pass, "Click Submit");
            ExtentReport.exChildTest.Log(Status.Pass, "Click Logout");


            String actual = driver.FindElement(By.XPath("(//a[@href='/account/login'])[1]")).Text;
            Assert.AreNotEqual(msg, actual);
         

        }
        #endregion
    }
}
