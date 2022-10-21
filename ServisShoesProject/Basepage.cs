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
using AventStack.ExtentReports;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;


namespace ServisShoesProject.ServisShoes.Login
{ 
    public class Basepage
    {

        public static IWebDriver driver;
        public static void SeleniumInit(string browser)

        {
            if (browser == "Chrome")
            {
                driver = new ChromeDriver();
            }
            else if (browser == "Edge")
            {
                driver = new EdgeDriver();
            }
            else if (browser == "FireFox")
            {
                driver = new FirefoxDriver();
            }


        }
        public void Clear(By by)

        {

            driver.FindElement(by).Clear();

        }
        public static void OpenUrl()

        {

            driver.Url = "https://www.servis.pk/";

        }
        //public static void Write(By by, string value)

        //{

        //    driver.FindElement(by).SendKeys(value);

        //}
        public void Write(By by, string value)
        {
            try
            {
                driver.FindElement(by).SendKeys(value);
                //TakeScreenshot(Status.Pass, "Enter Text");


            }
            catch (Exception )
            {

                //TakeScreenshot(Status.Fail, "Enter Text: " + ex.ToString());
            }
        }
        public void Click(By by)

        {
            //try
            //{
            //    driver.FindElement(By.XPath("//img[@class='news-close-img']")).Click();
            //}
            //catch (WebDriverException ex)
            //{
            //    Logger.LogMessage("WebDriver exception: ", ex);
            //    driver.FindElement(by).Click();
            //    //element.click();
            //}
            //try
            //{
            //    driver.FindElement(By.XPath("//img[@class='news-close-img']")).Click();
            //}
            //catch (Exception exa)
            //{
            //    Logger.LogMessage("WebDriver exception: ", exa);

            //    driver.FindElement(by).Click();

            //}


            //try
            //{
                try
                {
                    driver.FindElement(By.XPath("//img[@class='news-close-img']")).Click();
                    driver.FindElement(by).Click();

                }
                catch (Exception)
                {
                    //Logger.LogMessage("WebDriver exception: ", exa);

                    driver.FindElement(by).Click();
                }


                

           // }
            //catch (Exception ex)
            //{
            //    //Logger.LogMessage("WebDriver exception: ", ex);

            //    driver.FindElement(by).Click();
            //}

        }


        public void scroll()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,2000);");
        }
        //public void scrollelement(IWebElement by)
        //{
        //    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", by);
        //    IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
        //    executor.ExecuteScript("document.body.style.zoom='0.5'");
        //}
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

        }
        public void hoverhandle(By by)
        {
            Actions hover = new Actions(driver);
            hover.MoveToElement(driver.FindElement(by)).Build().Perform();
        }
        public void Selectdrop(By by, String value)
        {
            IWebElement dropdown = driver.FindElement(by);
            SelectElement dropdownmenu = new SelectElement(dropdown);
            dropdownmenu.SelectByValue(value);
        }
        public void waitforelement(By by)
        {

            
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));


        }
        public static void TakeScreenshot(Status status, string stepDetail)
        {
            string path = @"C:\Users\MUNIRHUSSAIN\source\repos\munirhussain14922\ServisShoesProject\ServisShoesProject\screenshots\" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
            image_username.SaveAsFile(path + ".png", ScreenshotImageFormat.Png);
            ExtentReport.exChildTest.Log(status, stepDetail, MediaEntityBuilder
                .CreateScreenCaptureFromPath(path + ".png").Build());
        }
        public static void CloseDriver()
        {
            driver.Close();
        }
        public static void PlaybackWait(int miliSeconds)

        {

            Thread.Sleep(miliSeconds);

        }
        public static void ScrolToDown()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");
        }
        public static void ScrollToTop()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,document.head.scrollHeight)");
        }
        public static void ImplicitWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

        }
        public static void PageLoad()
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(50);

        }

    }
}

