using OpenQA.Selenium;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.NewsLetter
{
    public class Newsletter : Basepage
    {
       
        
            By InputNewsletter = By.Id("Email-footer-newsletter-section");
            By gobutton = By.Id("Subscribe-footer-newsletter-section");
            By cbtna = By.XPath("//input[@type='submit' and @class='shopify-challenge__button btn']");


        public void Newslter(String Newsle)
            {
                Write(InputNewsletter, Newsle);
                Click(gobutton);
                Thread.Sleep(20000);
                Click(cbtna);
                ScrolToDown();
        }

    }
}
