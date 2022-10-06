using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace ServisShoesProject.ServisShoes.Login
{ 
    public class Basepage
    {
       // public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static IWebDriver driver;
        public static void SeleniumInit(string browser)

        {
           // log.Info("Report is Working");

            driver = new ChromeDriver();

        }
        public static void OpenUrl(string url)

        {

            driver.Url = url;

        }
        public static void Write(By by, string value)

        {

            driver.FindElement(by).SendKeys(value);

        }
        public void Click(By by)

        {

            driver.FindElement(by).Click();

        }


        public void scroll()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,2000);");
        }
        public void scrollelement(IWebElement by)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", by);
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("document.body.style.zoom='0.5'");
        }
        public void scrollelement1(By by)
        {
            var scrollement = driver.FindElement(by);

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", scrollement);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", by);

        }
        public void maxwindow()
        {
            driver.Manage().Window.Maximize();
        }
        public void alerthandle()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            IAlert alter = driver.SwitchTo().Alert();
            alter.Accept();
            //driver.FindElement(By.XPath("//button[text()='Later']"));

        }
        public void hoverhandle(By by)
        {
            Actions hover = new Actions(driver);
            hover.MoveToElement(driver.FindElement(by)).Build().Perform();
            // driver.FindElement(by).Click();
        }
        public void Selectdrop(By by, String value)
        {
            IWebElement dropdown = driver.FindElement(by);
            SelectElement dropdownmenu = new SelectElement(dropdown);
            dropdownmenu.SelectByValue(value);
        }





    

    }
}

