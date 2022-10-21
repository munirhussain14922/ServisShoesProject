using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.Login
{
    [TestClass]
    public class LoginTC : Basepage
    {
        #region Setup and Cleanup
        public TestContext instance;

        public TestContext TestContext

        {

            set { instance = value; }

            get { return instance; }

        }
        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {

        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {

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

        #region Login Test Cases
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Testdata.xml", "LoginWithValid", DataAccessMethod.Sequential)]
        public void Valid_LoginTC()
        {
            OpenUrl();
            maxwindow();
            LoginPage logpage = new LoginPage();

            ExtentReport.exChildTest = ExtentReport.extentReports.CreateTest("Login With Valid");


            String username = TestContext.DataRow["username"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter UserName");

            String password = TestContext.DataRow["password"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Password");

            String expected = TestContext.DataRow["message"].ToString();
            logpage.Loginfunction(username, password);
            ExtentReport.exChildTest.Log(Status.Pass, "Click Submit");

            String actual = driver.FindElement(By.XPath("(//a[@href='/account'])[1]")).Text;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Testdata.xml", "LoginWithinValid", DataAccessMethod.Sequential)]
        public void InvalidLoginTC()
        {
            
            OpenUrl();
            maxwindow();
            LoginPage logpage = new LoginPage();

            ExtentReport.exChildTest = ExtentReport.extentReports.CreateTest("Login With Invalid");

            String username = TestContext.DataRow["username"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter UserName");

            String password = TestContext.DataRow["password"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Password");

            String expected = TestContext.DataRow["message"].ToString();
            logpage.Loginfunction(username, password);
           ExtentReport.exChildTest.Log(Status.Pass, "Click Submit");

            String actual = driver.FindElement(By.XPath("//li[text()='Incorrect email or password.']")).Text;
            Assert.AreEqual(expected, actual);

        }


        #endregion

    }
}
