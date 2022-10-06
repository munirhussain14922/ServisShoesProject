using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.ForgotPassword
{
   
    public class InvalidforgotPasswrod : Basepage
    {
        By clicklogin = By.XPath("(//a[@href='/account/login'])[1]");
        By recoverbtn = By.XPath("//a[@href='#recover']");
        By Inputemail = By.Id("RecoverEmail");
        By submit = By.XPath("(//button[@class='button button--cta button--solid'])[1]");

        public void ForgotPassword(String emailadress)
        {
            Click(clicklogin);
            Click(recoverbtn);
            Write(Inputemail, emailadress);
            Click(submit);

        }
       
    }
}

