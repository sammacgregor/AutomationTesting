using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject1
{
    class Helper
    {

        public static void CreateIfMissing(string path)
        {

            bool folderExists = Directory.Exists(path);
            if (!folderExists)
                Directory.CreateDirectory(path);
        }

        public static void NewScreenshot(string path)
        {

            ChromeDriver driver = new ChromeDriver();
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(path + ".png", ScreenshotImageFormat.Png);
            driver.Quit();
        }


    }
}
