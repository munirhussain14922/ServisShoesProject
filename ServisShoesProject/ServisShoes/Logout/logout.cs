using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.Logout
{
    public class logout : Basepage
    {
        By clicklogin = By.XPath("(//a[@href='/account/login'])[1]");
        By phoneEmail = By.Id("CustomerForm-email");
        By pass = By.Id("CustomerForm-password");
        By loginButton = By.CssSelector("#customer_login > div > div.flex.items-center.flex-col.justify-center > button");
        By cbtna = By.XPath("//input[@type='submit' and @class='shopify-challenge__button btn']");
        By logoutbtn = By.XPath("(//a[@href='/account/logout'])[1]");
        By wiatlog = By.XPath("(//a[@href='/account' and @class='header-top__link'])[1]");
        By newscancel = By.XPath("//img[@class='news-close-img']");




        public void Logoutfunction(String user, String pass1)
        {
            Click(clicklogin);
            Write(phoneEmail, user);
            Write(pass, pass1);
            Click(loginButton);
            PlaybackWait(20000);
            Click(newscancel);
            Click(cbtna);
            PlaybackWait(1500);
            Click(logoutbtn);
        }

    }
}
