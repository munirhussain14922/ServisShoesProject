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
        [TestMethod]
        public void WISHlistTC()
        {
            SeleniumInit("Chrome");
            OpenUrl("https://www.servis.pk/");
            maxwindow();

            Wishlist cartlist = new Wishlist();

            cartlist.Wishlistmeth();


        }
    }
}
