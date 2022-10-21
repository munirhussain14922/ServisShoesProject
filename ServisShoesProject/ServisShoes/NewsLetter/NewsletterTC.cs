using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.NewsLetter
{
    [TestClass]
    public class NewsletterTC : Basepage
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



        #region NewSLetter Test Cases
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Testdata.xml", "NewletterWithValid", DataAccessMethod.Sequential)]

        public void NewsletterWithValid()
        {
            OpenUrl();
            maxwindow();

            Newsletter newss = new Newsletter();

            ExtentReport.exChildTest = ExtentReport.extentReports.CreateTest("NewsLetter With Valid");

            String email = TestContext.DataRow["email"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Email ");

            String expected = TestContext.DataRow["message"].ToString();
            newss.Newslter(email);
            ExtentReport.exChildTest.Log(Status.Pass, "Click Go");

            String actual = driver.FindElement(By.XPath("//p[text()='Thanks for subscribing']")).Text;
            Assert.AreEqual(expected, actual);


        }



        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Testdata.xml", "NewletterWithinValid", DataAccessMethod.Sequential)]

        public void NewsletterWithInValid()
        {
            OpenUrl();
            maxwindow();

            Newsletter newss = new Newsletter();

            ExtentReport.exChildTest = ExtentReport.extentReports.CreateTest("NewsLetter With InValid");

            String email = TestContext.DataRow["email"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Email ");

            String expected = TestContext.DataRow["message"].ToString();
            newss.Newslter(email);
            ExtentReport.exChildTest.Log(Status.Pass, "Click Go");

            String actual = driver.FindElement(By.Id("Email-footer-newsletter-section")).Text;
            Assert.AreNotEqual(expected, actual);


        }
        #endregion
    }
}
