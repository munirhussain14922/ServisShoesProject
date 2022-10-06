using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.Register
{
    [TestClass]
    public class RegisterTC : Basepage

    {
        [TestMethod]

        public void ValidRegisterTC()
        {
            SeleniumInit("Chrome");
            OpenUrl("https://www.servis.pk/");
            maxwindow();
            Register reg = new Register();
            reg.Registerfun("munir", "hussain", "munir1@gmail.com", "munirhussain");
        }
        [TestMethod]

        public void InvalidRegisterTC()
        {
            SeleniumInit("Chrome");
            OpenUrl("https://www.servis.pk/");
            maxwindow();
            Register reg = new Register();
            reg.Registerfun("munir", "hussain", "", "munirhussain");
        }
    }
}
