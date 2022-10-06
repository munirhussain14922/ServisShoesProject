using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        [TestMethod]
        public void Newslter()
        {
            SeleniumInit("Chrome");
            OpenUrl("https://www.servis.pk/");
            maxwindow();

            Newsletter newss = new Newsletter();
            newss.Newslter("munir@gmail.com");


        }
    }
}
