using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.Register
{
    public class Register : Basepage
    {
        By reclick = By.XPath("//a[@href='/account/register']");
        By fname = By.Id("CreateCustomerForm-firstname");
        By lname = By.Id("CreateCustomerForm-lastname");
        By email = By.Id("CreateCustomerForm-email");
        By passwrd = By.Id("CreateCustomerForm-password");
        By cbtna = By.XPath("//input[@type='submit' and @class='shopify-challenge__button btn']");
        By regbtn = By.CssSelector("#create_customer > div > div.flex.items-center.flex-col.justify-center > button");
        By newscancel = By.XPath("//img[@class='news-close-img']");

        public void Registerfun(String firstname, String lastname, String regmail, String paswrd)
        {
            Click(reclick);
            Write(fname, firstname);
            Write(lname, lastname);
            Write(email, regmail);
            Write(passwrd, paswrd);
            Click(regbtn);
            PlaybackWait(12000);
            Click(newscancel);
            Click(cbtna);
            
        }
    }
}
