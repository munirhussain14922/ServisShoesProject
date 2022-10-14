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
        public TestContext instance;

        public TestContext TestContext

        {

            set { instance = value; }

            get { return instance; }

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Testdata.xml", "RegsiterWithValid", DataAccessMethod.Sequential)]
        public void ValidRegisterTC()
        {
            SeleniumInit("Chrome");
            OpenUrl();
            maxwindow();
            Register reg = new Register();

            String fname = TestContext.DataRow["fname"].ToString();
            String lname = TestContext.DataRow["lname"].ToString();
            String mail = TestContext.DataRow["mail"].ToString();
            String password = TestContext.DataRow["password"].ToString();
           
            reg.Registerfun(fname, lname, mail, password);
            String expected = TestContext.DataRow["message"].ToString();
            String actual = driver.FindElement(By.XPath("(//a[@href='/account'])[1]")).Text;
            Assert.AreEqual(expected, actual);

            
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Testdata.xml", "RegsiterWithinValid", DataAccessMethod.Sequential)]
        public void InvalidRegisterTC()
        {
            SeleniumInit("Chrome");
            OpenUrl();
            maxwindow();
            Register reg = new Register();

            String fname = TestContext.DataRow["fname"].ToString();
            String lname = TestContext.DataRow["lname"].ToString();
            String mail = TestContext.DataRow["mail"].ToString();
            String password = TestContext.DataRow["password"].ToString();
            String expected = TestContext.DataRow["message"].ToString();
           
            reg.Registerfun(fname, lname, mail, password);
            String actual = driver.FindElement(By.XPath("//li[text()='Email is invalid.']")).Text;
            Assert.AreEqual(expected, actual);



        }
    }
}
