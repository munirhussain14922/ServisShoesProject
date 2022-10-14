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
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Testdata.xml", "ForgotPasswordWithValid", DataAccessMethod.Sequential)]

        public void ValidforgotPasswordTC()
        {
            SeleniumInit("Chrome");
            //OpenUrl("https://www.servis.pk/");
            maxwindow();

            forgotpasspage forpass = new forgotpasspage();

            String email = TestContext.DataRow["email"].ToString();
            String expected = TestContext.DataRow["message"].ToString();
            forpass.ForgotPassword(email);
            String actual = driver.FindElement(By.XPath("//h1[text()='Reset your password']")).Text;
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Testdata.xml", "ForgotPasswordWithinValid", DataAccessMethod.Sequential)]

        public void InvalidforgotPasswordTC()
        {
            SeleniumInit("Chrome");
            //OpenUrl("https://www.servis.pk/");
            maxwindow();

            forgotpasspage forpass = new forgotpasspage();
            String email = TestContext.DataRow["email"].ToString();
            String expected = TestContext.DataRow["message"].ToString();
            forpass.ForgotPassword(email);
            String actual = driver.FindElement(By.XPath("//h1[text()='Reset your password']")).Text;
            Assert.AreEqual(expected, actual);

        }

    }
}
