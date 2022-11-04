using CommonFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_UI
{
    public class CheackoutPage2:BasePage
    {
        private static CheackoutPage2? _instance;
        private By priceProduct = By.XPath("//*[@id=\"checkout_summary_container\"]/div/div[1]/div[3]/div[2]/div[2]/div");
        private By finishBtn = By.Id("finish");
        private By menuBtn = By.CssSelector("button[id =\"react-burger-menu-btn\"]");
        private By logOut = By.Id("logout_sidebar_link");
        private static readonly object padlock = new object();
        public static IWebDriver? myDriver = null;

        private CheackoutPage2(IWebDriver driver) : base(driver) { }
        public static CheackoutPage2 getInstance(IWebDriver Driver)
        {
            lock (padlock)
            {
                if (_instance == null)
                {
                    _instance = new CheackoutPage2(Driver); 
                    myDriver = Driver;

                }
                else if (Driver != myDriver)
                {
                    _instance = new CheackoutPage2(Driver);
                }
                return _instance;
            }
        }
        public String getPrice()
        {
           return getText(priceProduct);
        }
        public void clickFinishBtn()
        {
            waitAndClick(finishBtn);
        }
        public void clickMenuBtn()
        {
            waitAndClick(menuBtn);
        }
        public void clickLogOut()
        {
            waitAndClick(logOut);
        }
    }
}
