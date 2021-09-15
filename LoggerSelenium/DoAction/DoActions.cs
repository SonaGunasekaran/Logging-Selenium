/*
 * Project:Handling Alerts using Logger
 * Author:Sona G
 * Date :15/09/2021
 */
using LoggerSelenium.Alert;
using System;
using log4net;

namespace LoggerSelenium.DoAction
{
    public class DoActions : Base.Baseclass
    {
        public static ILog logger = LogManager.GetLogger(typeof(Tests));
        public static void TestAcceptAlert()
        {
            //find the button element by using Css Selector
            try
            {
                Alertclass alert = new Alertclass(driver);
                //alert.alertBtn.Click();
                System.Threading.Thread.Sleep(2000);

                //send the commands to alert window
                var alert_win = driver.SwitchTo().Alert();
                //Accept the alert
                alert_win.Accept();
                System.Threading.Thread.Sleep(2000);

                Console.WriteLine(alert.clickResult.Text);
                System.Threading.Thread.Sleep(2000);

                if (alert.clickResult.Text == "You successfuly clicked an alert")
                {
                    Console.WriteLine("Alert Test Successful");
                }
            }
            catch
            {
                logger.Info("Alert Popup NotFound");
            }

            logger.Info("Testcase Succesfull");
        }
    }
}
