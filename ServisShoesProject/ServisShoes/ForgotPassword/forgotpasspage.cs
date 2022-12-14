using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ServisShoesProject.ServisShoes.ForgotPassword
{
    [TestClass]
    public class forgotpasspage : Basepage
    {
        #region ForgotPassword Locators

        By clicklogin = By.XPath("(//a[@href='/account/login'])[1]");
        By recoverbtn = By.XPath("//a[@href='#recover']");
        By Inputemail = By.Id("RecoverEmail");
        By submit = By.XPath("(//button[@class='button button--cta button--solid'])[1]");
        By cbtna = By.XPath("//input[@type='submit' and @class='shopify-challenge__button btn']");
        //By newscancel = By.XPath("//img[@class='news-close-img']");

        #endregion

        #region ForgotPassword Method
        public void ForgotPassword(String emailadress)
        {
            PageLoad();
            Click(clicklogin);
            Click(recoverbtn);
            Write(Inputemail, emailadress);
            Click(submit);
            PlaybackWait(20000);
            //Click(newscancel);
            Click(cbtna);
            PlaybackWait(5000);

        }
        #endregion
    }
}
