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
        #region NewsLetter Locators

            By InputNewsletter = By.Id("Email-footer-newsletter-section");
            By gobutton = By.Id("Subscribe-footer-newsletter-section");
            By cbtna = By.XPath("//input[@type='submit' and @class='shopify-challenge__button btn']");
            //By newscancel = By.XPath("//img[@class='news-close-img']");
        #endregion

        #region NewsLetter Method
        public void Newslter(String Newsle)
            {
                PageLoad();
                Write(InputNewsletter, Newsle);
                Click(gobutton);
                PlaybackWait(20000);
                //Click(newscancel);
                Click(cbtna);
                ScrolToDown();
              }
        #endregion

    }
}
