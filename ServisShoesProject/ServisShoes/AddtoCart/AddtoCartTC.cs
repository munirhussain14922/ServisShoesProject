using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.AddtoCart
{
    [TestClass]
    public class AddtoCartTC : Basepage

    {
        [TestMethod]
        public void invalidAdtocarttTC()
        {
            SeleniumInit("Chrome");
            OpenUrl("https://www.servis.pk/");
            maxwindow();

            InValidaddtocart inadcart = new InValidaddtocart();
            inadcart.adtocart("GOOD", "Lahore", "Lahore", "munir@gmail.com", "Munir", "Hussain", "LAhore", "NFC", "54000", "");


        }
        [TestMethod]
        public void validAdtocarttTC()
        {
            SeleniumInit("Chrome");
            OpenUrl("https://www.servis.pk/");
            maxwindow();

            Validaddtocart adcart = new Validaddtocart();
            adcart.adtocart("GOOD", "Lahore", "Lahore", "munir@gmail.com", "Munir", "Hussain", "LAhore", "NFC", "54000", "03025957701");


        }
    }
}
