using CommonFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_UI
{
    public class SauceLabs:BasePage
    {
        private static SauceLabs _instance;
        public static IWebDriver? myDriver = null;

        private SauceLabs(IWebDriver driver) : base(driver) { }

        public static SauceLabs getInstance(IWebDriver Driver)
        {
            if (_instance == null)
            {
                _instance = new SauceLabs(Driver);
                myDriver = Driver;
            }
            else if (Driver != myDriver)
            {
                _instance = new SauceLabs(Driver);
            }
            return _instance;
        }
    }
}
