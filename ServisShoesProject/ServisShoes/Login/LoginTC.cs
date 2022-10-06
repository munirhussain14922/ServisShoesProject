using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.Login
{
    [TestClass]
    public class LoginTC : Basepage
    {
        [TestMethod]
        public void Valid_LoginTC()
        {
            SeleniumInit("Chrome");
            OpenUrl("https://www.servis.pk/");
            maxwindow();
            ValidLogin logpage = new ValidLogin();
            logpage.Login1("munir@gmail.com", "munirhussain");
        }
        [TestMethod]
        public void InvalidLoginTC()
        {
            SeleniumInit("Chrome");
            OpenUrl("https://www.servis.pk/");
            maxwindow();
            InValidLogin logpage = new InValidLogin();
            logpage.Login1("munir@gmail.com", "munirhussain123");
        }


    }
}
