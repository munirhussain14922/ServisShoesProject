using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.AddtoCart
{
    [TestClass]
    public class AddtoCartTC : Basepage
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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "TestData#csv", "TestData.csv", DataAccessMethod.Sequential)]
        public void invalidAdtocarttTC()
        {

            OpenUrl();
            maxwindow();

            addtocartPage adcart = new addtocartPage();

            ExtentReport.exChildTest = ExtentReport.extentReports.CreateTest("Add to Cart With Invalid");


            ExtentReport.exChildTest.Log(Status.Pass, "Click Product");
            ExtentReport.exChildTest.Log(Status.Pass, "Click Chappal");
            ExtentReport.exChildTest.Log(Status.Pass, "Click Quantity");
            ExtentReport.exChildTest.Log(Status.Pass, "Click Add to Cart");
            ExtentReport.exChildTest.Log(Status.Pass, "Click View Cart");



            String order_s = TestContext.DataRow["order_details"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Order Special");

            String sel_city = TestContext.DataRow["City"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter City");

            String mail = TestContext.DataRow["mail"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Email Address");

            String firstname = TestContext.DataRow["fname"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter First Name");

            String lastname = TestContext.DataRow["lname"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Last Name");

            String adress = TestContext.DataRow["City_name"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter City Name");

            //String apart = TestContext.DataRow["aprt"].ToString();
            //ExtentReport.exChildTest.Log(Status.Pass, "Enter Apartment Details");

            //String cityName = TestContext.DataRow["CityName"].ToString();
            //ExtentReport.exChildTest.Log(Status.Pass, "Enter City Name");

            String postal = TestContext.DataRow["postal"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Postal Code");

            String phoneno = TestContext.DataRow["phone"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Phone Number");

            adcart.adtocart(order_s, sel_city, mail, firstname, lastname, adress, postal, phoneno);
            String expected = TestContext.DataRow["message"].ToString();

            ExtentReport.exChildTest.Log(Status.Pass, "Click Shiping");
            ExtentReport.exChildTest.Log(Status.Pass, "Click Payment");

            String actual = driver.FindElement(By.XPath("//span[text()='Cash on Delivery (COD)']")).Text;
            Assert.AreEqual(expected, actual);

            //inadcart.adtocart("GOOD", "Lahore", "munir@gmail.com", "Munir", "Hussain", "LAhore", "NFC", "54000", "");
        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "TestData#csv", "TestData.csv", DataAccessMethod.Sequential)]

        public void validAdtocarttTC()
        {
            
            OpenUrl();
            maxwindow();

            ExtentReport.exChildTest = ExtentReport.extentReports.CreateTest("Add to Cart With Valid");


            addtocartPage adcart = new addtocartPage();
            ExtentReport.exChildTest.Log(Status.Pass, "Click Product");
            ExtentReport.exChildTest.Log(Status.Pass, "Click Chappal");
            ExtentReport.exChildTest.Log(Status.Pass, "Click Quantity");
            ExtentReport.exChildTest.Log(Status.Pass, "Click Add to Cart");
            ExtentReport.exChildTest.Log(Status.Pass, "Click View Cart");



            String order_s = TestContext.DataRow["order_details"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Order Special");

            String sel_city = TestContext.DataRow["City"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter City");

            String mail = TestContext.DataRow["mail"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Email Address");

            String firstname = TestContext.DataRow["fname"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter First Name");

            String lastname = TestContext.DataRow["lname"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Last Name");

            String adress = TestContext.DataRow["City_name"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter City Name");

            //String apart = TestContext.DataRow["aprt"].ToString();
            //ExtentReport.exChildTest.Log(Status.Pass, "Enter Apartment Details");

            //String cityName = TestContext.DataRow["CityName"].ToString();
            //ExtentReport.exChildTest.Log(Status.Pass, "Enter City Name");

            String postal = TestContext.DataRow["postal"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Postal Code");

            String phoneno = TestContext.DataRow["phone"].ToString();
            ExtentReport.exChildTest.Log(Status.Pass, "Enter Phone Number");

            adcart.adtocart(order_s, sel_city, mail, firstname, lastname, adress, postal, phoneno);
            String expected = TestContext.DataRow["message"].ToString();

            ExtentReport.exChildTest.Log(Status.Pass, "Click Shiping");
            ExtentReport.exChildTest.Log(Status.Pass, "Click Payment");

            String actual = driver.FindElement(By.XPath("//span[text()='Cash on Delivery (COD)']")).Text;
            Assert.AreEqual(expected, actual);

        }
    }
}
