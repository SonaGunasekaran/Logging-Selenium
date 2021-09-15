/*
 * Project:Handling Alerts using Logger
 * Author:Sona G
 * Date :15/09/2021
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LoggerSelenium.Base
{
    public class Baseclass
    {
        public static IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "http://the-internet.herokuapp.com/javascript_alerts";
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }

    }
}
