using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.Login
{
    public class LoginPage : Basepage
    {
        //login Page 
        By clicklogin = By.XPath("(//a[@href='/account/login'])[1]");
        By phoneEmail = By.Id("CustomerForm-email");
        By pass = By.Id("CustomerForm-password");
        By cbtna = By.XPath("//input[@type='submit' and @class='shopify-challenge__button btn']");
        By loginButton = By.CssSelector("#customer_login > div > div.flex.items-center.flex-col.justify-center > button");

        public void Loginfunction(String user, String pass1)
        {
            Click(clicklogin);
            Write(phoneEmail, user);
            Write(pass, pass1);
            Click(loginButton);
            Thread.Sleep(20000);
            Click(cbtna);
        }
        
    }
}
