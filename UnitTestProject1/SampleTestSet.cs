using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;



namespace UnitTestProject1
{
    [TestClass]
    public class SampleTestSet
    {

        public static String ROOT_FOLDER = "G:/My Drive/";
        String date = DateTime.Today.ToShortDateString();




        [TestMethod]
        public void Test1()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "https://www.google.com.au";

                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                driver.FindElement(By.Id("lst-ib")).SendKeys("Hello World");

                driver.FindElement(By.Name("btnK")).Submit();
                String path = ROOT_FOLDER + date;
                Helper.CreateIfMissing(path);
                String targetFilePath = ROOT_FOLDER + date + "/" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + this.GetType().FullName;
                Helper.NewScreenshot(targetFilePath);


                driver.Close();
                driver.Dispose();
            }
            catch {



                String path = ROOT_FOLDER + date;
                Helper.CreateIfMissing(path);
                String targetFilePath = ROOT_FOLDER + date + "/" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + this.GetType().FullName;
                Helper.NewScreenshot(targetFilePath);
                driver.Quit();
            }
        }

        [TestMethod]
        public void Test2()
        {
            ChromeDriver driver = new ChromeDriver();
            try
            {
                string url = "https://www.google.com.au";

                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                driver.FindElement(By.Id("lst-ib")).SendKeys("Hello Service");

                driver.FindElement(By.Name("btnK")).Submit();


                
                String path = ROOT_FOLDER + date;
                Helper.CreateIfMissing(path);
                String targetFilePath = ROOT_FOLDER + date + "/" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + this.GetType().FullName;
                Helper.NewScreenshot(targetFilePath);
                               

                driver.Close();
                driver.Dispose();
            }
            catch
            {
                String path = ROOT_FOLDER + date;
                Helper.CreateIfMissing(path);
                String targetFilePath = ROOT_FOLDER + date + "/" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + this.GetType().FullName;
                Helper.NewScreenshot(targetFilePath);
                driver.Quit();
            }
        }

        [TestMethod]
        public void Test3() {

            Console.WriteLine();
            String date = DateTime.Today.ToShortDateString();


        }


    }
}
