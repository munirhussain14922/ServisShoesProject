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
    public class Wishlist : Basepage
    {


        By prodt = By.XPath("//a[@href='/collections/men-sandal-chapal']");

        By chapp = By.CssSelector("#ProductCard-template--14192492445814__collection-6722006646902 > a > div.product-card__labels-container.inset-0.absolute");
        By size = By.XPath("//label[@for='template--14192492839030__product-1-1']");
        By quanityt = By.XPath("//button[@class='quantity__button' and @name='plus']");

        By btnadd = By.Id("AddToCart-template--14192492839030__product");
        By viewcart = By.Id("cart-notification-form");

        public void Wishlistmeth()
        {
            Click(prodt);

            Click(chapp);
            Click(size);
            Click(quanityt);
            PlaybackWait(400);
            Click(btnadd);
            ImplicitWait();
            Click(viewcart);
        }
    }

        
}
