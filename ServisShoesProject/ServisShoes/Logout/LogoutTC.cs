using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.Logout
{
    [TestClass]
    public class LogoutTC : Basepage
    {
        public TestContext instance;

        public TestContext TestContext

        {

            set { instance = value; }

            get { return instance; }

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Testdata.xml", "LogoutWithValid", DataAccessMethod.Sequential)]
        public void LogoutTC_1()
        {
            SeleniumInit("Chrome");
            //OpenUrl("https://www.servis.pk/");
            maxwindow();
            logout logoutb = new logout();
            String username = TestContext.DataRow["username"].ToString();
            String password = TestContext.DataRow["password"].ToString();
            String msg = TestContext.DataRow["message"].ToString();
            logoutb.Logoutfunction(username, password);
            String actual = driver.FindElement(By.XPath("(//a[@href='/account/login'])[1]")).Text;
            Assert.AreNotEqual(msg, actual);
         
        }

    }
}
