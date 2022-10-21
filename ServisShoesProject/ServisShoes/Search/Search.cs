using OpenQA.Selenium;
using ServisShoesProject.ServisShoes.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisShoesProject.ServisShoes.Search
{
    public class Search : Basepage
    {
        #region SearchPage Locators
        By search1 = By.XPath("//button[@aria-controls='SearchBar-header-top']");
        By searchinput = By.Id("SearchBarInput-header-top");
        By enter = By.XPath("(//div[@class='search-bar__icon absolute right-0 inset-y-0 w-6 mr-4 z-10 group-focus-within:text-primary-accent'])[1]");
        By radio1 = By.Id("Filter-filter.v.availability-1");
        By pricefrom = By.Id("Filter-filter.v.price.gte");
        By priceto = By.Id("Filter-filter.v.price.lte");
        By chkekisha = By.Id("Filter-filter.p.vendor-2");
        By chkeklara = By.Id("Filter-filter.p.vendor-5");
        By chkekservis = By.Id("Filter-filter.p.vendor-7");
        
        By color = By.Id("Filter-filter.v.option.color-2");
        By size = By.Id("Filter-filter.v.option.size-3");
        #endregion


        #region Search Method

        public void search(String searching, String frprice, String toprice)
        {
            PageLoad();
            Click(search1);
            Write(searchinput, searching);
            Click(enter);
            Click(radio1);
            Write(pricefrom, frprice);
            Write(priceto, toprice);
            Click(chkekisha);
            Click(chkeklara);
            Click(chkekservis);
            
           //scrollelement1(color);
            

            Click(color);
            //Click(size);
        }
        #endregion
    }
}
