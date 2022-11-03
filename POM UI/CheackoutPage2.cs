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
        private static CheackoutPage2 instance;
        private By priceProduct = By.XPath("//*[@id=\"checkout_summary_container\"]/div/div[1]/div[3]/div[2]/div[2]/div");
        private By finishBtn = By.Id("finish");
        private static readonly object padlock = new object();
        private CheackoutPage2(IWebDriver driver) : base(driver) { }
        public static CheackoutPage2 getInstance(IWebDriver driver)
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new CheackoutPage2(driver);
                }
                return instance;
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
    }
}
