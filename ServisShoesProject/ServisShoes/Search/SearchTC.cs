using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.Search
{
    [TestClass]
    public class SearchTC : Basepage
    {
        public TestContext instance;

        public TestContext TestContext

        {

            set { instance = value; }

            get { return instance; }

        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Testdata.xml", "SearchWithinValid", DataAccessMethod.Sequential)]

        public void Searchfun()
        {
            SeleniumInit("Chrome");
            OpenUrl();
            maxwindow();
            scroll();
            Search searchmthfun = new Search();

            String searchproname = TestContext.DataRow["keyword"].ToString();
            String priceto = TestContext.DataRow["priceto"].ToString();
            String priceFrom = TestContext.DataRow["pricefrom"].ToString();
            String expected = TestContext.DataRow["message"].ToString();

            searchmthfun.search(searchproname, priceto, priceFrom);
            String actual = driver.FindElement(By.Id("ProductCount")).Text;
            Assert.AreEqual(expected, actual);
        }

    }
}
