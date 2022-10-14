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
        public TestContext instance;

        public TestContext TestContext

        {

            set { instance = value; }

            get { return instance; }

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Testdata.xml", "NewletterWithValid", DataAccessMethod.Sequential)]

        public void Newslter()
        {
            SeleniumInit("Chrome");
            OpenUrl();
            maxwindow();

            Newsletter newss = new Newsletter();
            String email = TestContext.DataRow["email"].ToString();
            String expected = TestContext.DataRow["message"].ToString();
            newss.Newslter(email);
           // String actual = driver.FindElement(By.XPath("//p[text()='Thanks for subscribing']")).Text;
            //Assert.AreEqual(expected, actual);


        }
    }
}
