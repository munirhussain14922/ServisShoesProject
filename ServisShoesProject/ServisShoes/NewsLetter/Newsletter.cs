using OpenQA.Selenium;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.NewsLetter
{
    public class Newsletter : Basepage
    {
       
        
            By InputNewsletter = By.Id("Email-footer-newsletter-section");
            By gobutton = By.Id("Subscribe-footer-newsletter-section");

            public void Newslter(String Newsle)
            {
                Write(InputNewsletter, Newsle);
                Click(gobutton);
            }


        
    }
}
