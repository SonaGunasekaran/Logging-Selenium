/*
 * Project:Handling Alerts using logger
 * Author:Sona G
 * Date :15/09/2021
 */
using NUnit.Framework;

namespace LoggerSelenium
{
    public class Tests : Base.Baseclass
    {
        [Test, Order(1)]
        public void test_alert()
        {
            DoAction.DoActions.TestAcceptAlert();
        }
    }


}
