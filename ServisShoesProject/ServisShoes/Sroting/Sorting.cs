using OpenQA.Selenium;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.Sroting
{
    public class Sorting : Basepage
    {
        By ho = By.Id("DetailsMenu-header-menu-1");
        By homenu = By.CssSelector("#InlineMenu-header-menu-child-1 > li:nth-child(1)");
        By selectsorting = By.Id("SortBy-template--14192492445814__collection");

        public void sorintg(String dro)
        {
            hoverhandle(ho);
            Click(homenu);

            Selectdrop(selectsorting, dro);



        }
    }
}
