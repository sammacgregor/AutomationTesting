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

                Helper.NewScreenshot(this.GetType().FullName, driver);


                driver.Close();
                driver.Dispose();
            }
            catch {

                Helper.NewScreenshot(this.GetType().FullName, driver);
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



                Helper.NewScreenshot(this.GetType().FullName, driver);



                driver.Close();
                driver.Dispose();
            }
            catch
            {
                Helper.NewScreenshot(this.GetType().FullName, driver);

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
