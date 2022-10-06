using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.ForgotPassword
{
    [TestClass]
    public  class ForgotPasswordTC : Basepage
    {
        [TestMethod]
        public void ValidforgotPasswordTC()
        {
            SeleniumInit("Chrome");
            OpenUrl("https://www.servis.pk/");
            maxwindow();

            Validforgotpasspage forpass = new Validforgotpasspage();
            forpass.ForgotPassword("munir@gmail.com");


        }
        [TestMethod]
        public void InvalidforgotPasswordTC()
        {
            SeleniumInit("Chrome");
            OpenUrl("https://www.servis.pk/");
            maxwindow();

            InvalidforgotPasswrod forpass = new InvalidforgotPasswrod();
            forpass.ForgotPassword("munir@@gmail.com");


        }

    }
}
