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


        By ho = By.Id("DetailsMenu-header-menu-1");
        By homenu = By.CssSelector("#InlineMenu-header-menu-child-1 > li:nth-child(1)");
        By quanityt = By.XPath("//button[@class='quantity__button' and @name='plus']");
        By prodt = By.Id("ProductCard-template--14192492445814__collection-6630322929782");

        By size = By.XPath("//label[@for='template--14192492839030__product-1-1']");

        By btnadd = By.Id("AddToCart-template--14192492839030__product");
        By addcart = By.Id("cart-button");


        public void Wishlistmeth()
        {
            hoverhandle(ho);
            Click(homenu);
            Click(prodt);
            Click(size);
            Click(quanityt);
            Click(btnadd);
            Thread.Sleep(15000);
            Click(addcart);
        }
    }

        
}
