using NUnit.Framework;
using Sikuli4Net.sikuli_REST;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.IO;
using Sikuli4Net.sikuli_UTIL;

namespace sikulitest
{
    [TestFixture]
    public class UnitTest1
    {
        IWebDriver driver;

        [SetUp]
        public void SettingDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.bannerhealth.com/healthcareblog/articles/categories/healthy-women");
        }

        [Test]
        public void TestMethod1()
        {
            var fullpath1 = Path.Combine(@"C:\Users\CarlosIbarra\Documents\images", @"\imageBefore.PNG");
            var fullpath2 = Path.Combine(@"C:\Users\CarlosIbarra\Documents\images", @"\imageAfter.PNG");
            Pattern ImageAfter = new Pattern("C:/Users/CarlosIbarra/source/repos/sikulitest/sikulitest/bin/Debug/images/imageAfter.png");
            Pattern ImageBefore = new Pattern("C:/Users/CarlosIbarra/source/repos/sikulitest/sikulitest/bin/Debug/images/imageBefore.png");

            Testpage.MoveToSomePlace(driver, By.CssSelector("#content > div > section > div > div > div > div > div"));
            
            Screen scr = new Screen();
            scr.Find(ImageAfter, true);
            var result =  scr.Exists(ImageAfter);
            Console.WriteLine("Sucess");
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
