using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.AddtoCart
{

    public class Validaddtocart : Basepage
    {
        By prodt = By.XPath("//a[@href='/collections/men-sandal-chapal']");
        By chapp = By.CssSelector("#ProductCard-template--14192492445814__collection-6722006646902 > a > div.product-card__labels-container.inset-0.absolute");
        By size = By.XPath("//label[@for='template--14192492839030__product-1-1']");
        By quanityt = By.XPath("//button[@class='quantity__button' and @name='plus']");
        
        By btnadd = By.Id("AddToCart-template--14192492839030__product");
        By viewcart = By.Id("cart-notification-form");
        By description = By.Id("Cart-Note");
        By selectcity = By.Id("select2-cityNameDropdown-container");
        By citywrite = By.XPath("//input[@class='select2-search__field']");
        By agree = By.Id("Cart-Agreement");
        By checkout = By.Id("checkout");
        By email = By.Id("email");
        By fname = By.Id("TextField1");
        By lname = By.Id("TextField2");
        By address = By.Id("TextField3");
        By apart = By.Id("TextField4");
        By postal = By.Id("TextField6");
        By phone = By.Id("TextField7");
        By shipping = By.XPath("//button[@class='_2pOWh uWTUp _1Kqoj _2tVwl _3MrgP _10zXD sd4hU']");
        By payment = By.XPath("//*[@id='Form2']//child::button[1]");
       // By completeorder = By.CssSelector("#Form3 > div:nth-child(1) > div > div._3XHWd._7J8O > div:nth-child(1) > button");

        //By payment = By.XPath("//button[@class='_2pOWh uWTUp _1Kqoj _2tVwl _3MrgP _10zXD sd4hU']");

        public void adtocart(String city, String desc, String citywt, String mail, String faname, String lanme, String Addresss, String aprtment, String postalcode, String phoneno)
        {
            Click(prodt);
            Click(chapp);
            Click(size);
            Click(quanityt);

            Click(btnadd);
            Thread.Sleep(8000);
            Click(viewcart);
            Write(description, desc);
            Click(selectcity);
            Write(citywrite, citywt + Keys.Enter);
            Click(agree);
            Click(checkout);
            Write(email, mail);
            Write(fname, faname);
            Write(lname, lanme);
            Write(address, Addresss);
            Write(apart, aprtment);
            Write(postal, postalcode);
            Write(phone, phoneno);
            Click(shipping);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            Click(payment);
            //Click(completeorder);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            //var bnt= driver.FindElement(By.XPath("//span[text()='Continue to payment']"));
            //bool element = bnt.Enabled;
            //Assert.IsTrue(element);

        }
        
    }
}
