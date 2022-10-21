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
   
    public class ContactUsPage : Basepage
    {
        #region Conatact US Page Locators
        By btncont = By.XPath("//a[@href='/pages/contact-us']");
        By name = By.Id("ContactForm-name");
        By mail = By.Id("ContactForm-email");
        By phone = By.Id("ContactForm-phone");
        By cmt = By.Id("ContactForm-body");
        By btn = By.CssSelector("#ContactForm > div > div.contact-form__button > button");
        By ho = By.Id("DetailsMenu-header-menu-1");
        By homenu = By.CssSelector("#InlineMenu-header-menu-child-1 > li:nth-child(1)");
        By cbtna = By.XPath("//input[@type='submit' and @class='shopify-challenge__button btn']");
        //By newscancel = By.XPath("//img[@class='news-close-img']");


        #endregion



        #region Contact US page Method
        public void cont(String namee, String emailo, String phoneno, String comment)
        {
            PageLoad();
            //hoverhandle(ho);
            //Click(homenu);
            Click(btncont);
            Write(name, namee);
            Write(mail, emailo);
            Write(phone, phoneno);
            Write(cmt, comment);
            Click(btn);
            PlaybackWait(20000);
            //Click(newscancel);
            Click(cbtna);
        }

        #endregion
    }
}
