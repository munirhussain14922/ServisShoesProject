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
namespace ServisShoesProject.ServisShoes.ContactUs
{
    [TestClass]
    public  class ContactPageTC : Basepage
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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Testdata.xml", "ContactusWithValid", DataAccessMethod.Sequential)]

        public void ContactValidTC()
        {
            OpenUrl();
            maxwindow();
            scroll();
            ContactUsPage contact = new ContactUsPage();


            ExtentReport.exChildTest=ExtentReport.extentReports.CreateTest("Contact Us With Valid");

            String namee = TestContext.DataRow["name"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Name");

            String emailo = TestContext.DataRow["mail"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Mail");

            String phoneno = TestContext.DataRow["phone"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Phone number");

            String comment = TestContext.DataRow["comment"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Comment");

            String expected = TestContext.DataRow["message"].ToString();

           

            contact.cont(namee, emailo, phoneno, comment);

            ExtentReport.exChildTest.Log(Status.Pass, "Click Submit");

            String actual = driver.FindElement(By.XPath("//div[@class='contact-form__message outline-none px-4 py-2 bg-primary-secondary-background mb-4']")).Text;
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Testdata.xml", "ContactusWithinValid", DataAccessMethod.Sequential)]

        public void ContactInValidTC()
        {
            
            OpenUrl();
            maxwindow();
            scroll();
            ContactUsPage contact = new ContactUsPage();
            ExtentReport.exChildTest = ExtentReport.extentReports.CreateTest("Contact Us With InValid");


            String namee = TestContext.DataRow["name"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Name");

            String emailo = TestContext.DataRow["mail"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Mail");

            String phoneno = TestContext.DataRow["phone"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Phone number");

            String comment = TestContext.DataRow["comment"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Comment");

            String expected = TestContext.DataRow["message"].ToString();

            

            contact.cont(namee, emailo, phoneno, comment);
            ExtentReport.exChildTest.Log(Status.Pass, "Click Submit");

            String actual = driver.FindElement(By.XPath("//a[@href='#ContactForm-email']")).Text;
            Assert.AreEqual(expected, actual);
        }


    }
}
