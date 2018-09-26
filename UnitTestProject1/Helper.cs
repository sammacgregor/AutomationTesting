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

        public static void NewScreenshot(string testCase, ChromeDriver driver)
        {

            string ROOT_FOLDER = "G:/My Drive/";
            String DATE = DateTime.Today.ToShortDateString();

            Helper.CreateIfMissing(ROOT_FOLDER + DATE);

            String root = ROOT_FOLDER + DATE + "/" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(root + " " + testCase + ".png", ScreenshotImageFormat.Png);
        }

    }
}
