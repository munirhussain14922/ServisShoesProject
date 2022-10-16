using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.Register
{
    [TestClass]
    public class RegisterTC : Basepage
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


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Testdata.xml", "RegsiterWithValid", DataAccessMethod.Sequential)]
        public void ValidRegisterTC()
        {
            OpenUrl();
            maxwindow();
            Register reg = new Register();
            ExtentReport.exChildTest = ExtentReport.extentReports.CreateTest("Register With Valid");

            ExtentReport.exChildTest.Log(Status.Pass, "Click Register Page");

            String fname = TestContext.DataRow["fname"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter First Name");

            String lname = TestContext.DataRow["lname"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Last Name");

            String mail = TestContext.DataRow["mail"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Email");

            String password = TestContext.DataRow["password"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Password");


            reg.Registerfun(fname, lname, mail, password);
            ExtentReport.exChildTest.Log(Status.Pass, "Click Register");

            String expected = TestContext.DataRow["message"].ToString();
            String actual = driver.FindElement(By.XPath("(//a[@href='/account'])[1]")).Text;
            Assert.AreEqual(expected, actual);

            
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Testdata.xml", "RegsiterWithinValid", DataAccessMethod.Sequential)]
        public void InvalidRegisterTC()
        {
            OpenUrl();
            maxwindow();
            Register reg = new Register();
            ExtentReport.exChildTest = ExtentReport.extentReports.CreateTest("Register With Invalid");
            ExtentReport.exChildTest.Log(Status.Pass, "Click Register Page");

            String fname = TestContext.DataRow["fname"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter First Name");

            String lname = TestContext.DataRow["lname"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Last Name");

            String mail = TestContext.DataRow["mail"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Email");

            String password = TestContext.DataRow["password"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Password");

            String expected = TestContext.DataRow["message"].ToString();
           
            reg.Registerfun(fname, lname, mail, password);
            ExtentReport.exChildTest.Log(Status.Pass, "Click Register");

            String actual = driver.FindElement(By.XPath("//li[text()='Email is invalid.']")).Text;
            Assert.AreEqual(expected, actual);



        }
    }
}
