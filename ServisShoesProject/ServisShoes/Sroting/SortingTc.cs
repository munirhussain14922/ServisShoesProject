using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.Sroting
{
    [TestClass]
    public class SortingTc : Basepage
    {
        [TestMethod]
        public void SortingfunctionTC()
        {
            SeleniumInit("Chrome");
            OpenUrl("https://www.servis.pk/");
            maxwindow();

            Sorting sort = new Sorting();
            sort.sorintg("manual");


        }
    }
}
