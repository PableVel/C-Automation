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
        private static SauceLabs instance;

        private SauceLabs(IWebDriver driver) : base(driver) { }

        public static SauceLabs getInstance(IWebDriver driver)
        {
            if (instance == null)
            {
                instance = new SauceLabs(driver);
            }
            return instance;
        }
    }
}
