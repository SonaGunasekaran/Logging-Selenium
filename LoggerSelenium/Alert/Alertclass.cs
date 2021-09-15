/*
 * Project:Handling Alerts using Logger
 * Author:Sona G
 * Date :15/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace LoggerSelenium.Alert
{
    public class Alertclass
    {
        public Alertclass(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "button[onclick='jsAlert()']")]
        [CacheLookup]
        public IWebElement alertBtn;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement clickResult;
    }
}
