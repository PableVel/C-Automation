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

        private CartPage(IWebDriver driver) : base(driver) { }

        public static CartPage getInstance(IWebDriver driver)
        {
            if (instance == null)
            {
                instance = new CartPage(driver);
            }
            return instance;
        }
        public ProductsPage clickBack()
        {
            waitAndClick(backBtn);
            return ProductsPage.getInstance(driver);
        }
    }
}
