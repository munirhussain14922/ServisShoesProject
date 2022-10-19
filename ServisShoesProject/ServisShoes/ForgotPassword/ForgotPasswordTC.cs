using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.ForgotPassword
{
    [TestClass]
    public  class ForgotPasswordTC : Basepage
    {

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


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Testdata.xml", "ForgotPasswordWithValid", DataAccessMethod.Sequential)]

        public void ValidforgotPasswordTC()
        {
            OpenUrl();
            maxwindow();
            forgotpasspage forpass = new forgotpasspage();

            ExtentReport.exChildTest = ExtentReport.extentReports.CreateTest("Forgot Password With Valid");

            String email = TestContext.DataRow["email"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Email Address");

            String expected = TestContext.DataRow["message"].ToString();
            forpass.ForgotPassword(email);
            ExtentReport.exChildTest.Log(Status.Pass, "Click Submit");

            String actual = driver.FindElement(By.XPath("//p[text()='We will send you an email to reset your password']")).Text;
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Testdata.xml", "ForgotPasswordWithinValid", DataAccessMethod.Sequential)]

        public void InvalidforgotPasswordTC()
        {
            OpenUrl();
            maxwindow();
            forgotpasspage forpass = new forgotpasspage();
            ExtentReport.exChildTest = ExtentReport.extentReports.CreateTest("Forgot Password With InValid");

            String email = TestContext.DataRow["email"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Email Address");

            String expected = TestContext.DataRow["message"].ToString();
            forpass.ForgotPassword(email);
            ExtentReport.exChildTest.Log(Status.Pass, "Click Submit");

            String actual = driver.FindElement(By.XPath("//p[text()='We will send you an email to reset your password']")).Text;
            Assert.AreEqual(expected, actual);

        }

    }
}
