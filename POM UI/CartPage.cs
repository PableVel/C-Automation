using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_UI
{
    public class CartPage:BasePage
    {
        private static CartPage instance;
        private By backBtn = By.CssSelector("[class=\"btn btn_secondary back btn_medium\"]");
        private By priceLabel = By.XPath("//*[@id=\"cart_contents_container\"]/div/div[1]/div[3]/div[2]/div[2]/div");
        private By checkoutBtn = By.Name("checkout");
        private static readonly object padlock = new object();
        private CartPage(IWebDriver driver) : base(driver) { }

        public static CartPage getInstance(IWebDriver driver)
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new CartPage(driver);
                }
                return instance;
            }
        }
        public ProductsPage clickBack()
        {
            waitAndClick(backBtn);
            return ProductsPage.getInstance(driver);
        }
        public String getPrice()
        {
            return getText(priceLabel);
        }
        public CheackoutPage1 clickCheckoutBtn()
        {
            waitAndClick(checkoutBtn);
            return CheackoutPage1.getInstance(driver);
        }
    }
}
