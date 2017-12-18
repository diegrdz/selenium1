using System;
using OpenQA.Selenium;

namespace Fdv1
{
    class DriverController
    {
        public static IWebDriver driver { get; set; }


        public static void enterTextByName(string element,string text)
        {
            driver.FindElement(By.Name(element)).SendKeys(text);
        }

        public static void enterTextById(string element, string text)
        {
            driver.FindElement(By.Id(element)).SendKeys(text);
            
        }



    }
}
