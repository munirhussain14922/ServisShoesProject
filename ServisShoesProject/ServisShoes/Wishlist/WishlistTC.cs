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

namespace ServisShoesProject.ServisShoes.Wishlist
{
    [TestClass]
    public class WishlistTC : Basepage
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


        #region Wishlist Test Case
        [TestMethod]
        public void WishlistWithValid()
        {
            OpenUrl();
            maxwindow();
            ExtentReport.exChildTest = ExtentReport.extentReports.CreateTest("Wishlist With Valid");

            Wishlist cartlist = new Wishlist();
            String expected = "YOUR CART";

            cartlist.Wishlistmeth();
            ExtentReport.exChildTest.Log(Status.Pass, "Click Product");
            //
            //ExtentReport.exChildTest.Log(Status.Fail, "Click Product");

            ExtentReport.exChildTest.Log(Status.Pass, "Click Chappal");
            ExtentReport.exChildTest.Log(Status.Pass, "Click Quantity");
            ExtentReport.exChildTest.Log(Status.Pass, "Click Add To Cart");
            ExtentReport.exChildTest.Log(Status.Pass, "Click View Cart");

            String actual = driver.FindElement(By.XPath("//h1[text()='Your cart']")).Text;
            Assert.AreEqual(expected, actual);



        }
        #endregion
    }
}
