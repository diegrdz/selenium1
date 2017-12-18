using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Fdv1
{

    class Program
    {


        public static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            //Config the ChromeDriver
            DriverController.driver = new ChromeDriver();
            DriverController.driver.Manage().Window.Maximize();
            DriverController.driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            DriverController.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void TestCase1()
        {
            //Navigate to Google Page
            DriverController.driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine("Opened URL");

            //Search Seleniumhq and enter into the Seleniumhq Site
            DriverController.enterTextById("lst-ib", "Seleniumhq");
            DriverController.driver.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
            DriverController.driver.FindElement(By.XPath("//a[@href='http://www.seleniumhq.org/']")).Click();
            Console.WriteLine("Executed TestCase1");

            //Verify the seleniumhq url
            Assert.That(DriverController.driver.Url == "http://www.seleniumhq.org/");
            Console.WriteLine("Assert executed");
        }

        [TearDown]
        public void CleanUp()
        {
            //Close the driver
            DriverController.driver.Close();
            Console.WriteLine("Driver closed");
        }




    }
}
