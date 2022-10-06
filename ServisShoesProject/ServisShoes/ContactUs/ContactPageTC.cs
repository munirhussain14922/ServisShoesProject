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
        [TestMethod]
        public void ContactValidTC()
        {
            SeleniumInit("Chrome");
            OpenUrl("https://www.servis.pk/");
            maxwindow();
            scroll();
            ValidContactUs contact = new ValidContactUs();
            contact.cont("munir", "munir@gmail.com", "0302595301", "munirhussain");
        }
        [TestMethod]
        public void ContactInValidTC()
        {
            SeleniumInit("Chrome");
            OpenUrl("https://www.servis.pk/");
            maxwindow();
            scroll();
            ValidContactUs contact = new ValidContactUs();
            contact.cont("", "", "", "");
        }


    }
}
