using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_UI
{
    public class ProductsPage:BasePage
    {
        private static ProductsPage instance;
        private By sortContainerDropDown = By.CssSelector("select.product_sort_container");
        private By addCartBikeLightBtn = By.Name("add-to-cart-sauce-labs-bike-light");
        private By addCartBoltTShirtBtn = By.CssSelector("button[data-test=\"add-to-cart-sauce-labs-bolt-t-shirt\"]");
        private By shoppingCartLink = By.XPath("//*[@id=\"shopping_cart_container\"]/a");
        private By menuBtn = By.CssSelector("button[id =\"react-burger-menu-btn\"]");
        private By aboutLink = By.LinkText("ABOUT");
        private static readonly object padlock = new object();

        private ProductsPage(IWebDriver driver) : base(driver) { }

        public static ProductsPage getInstance(IWebDriver driver)
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new ProductsPage(driver);
                }
                return instance;
            }
        }

        public void selectFromContainerByText(String textToType)
        {
            selectFromDropDownByText(sortContainerDropDown, textToType);
        }
        public void clickAddCartBikeLightBtn()
        {
            waitAndClick(addCartBikeLightBtn);
        }
        public void clickAddCartBoltTShirtBtn()
        {
            waitAndClick(addCartBoltTShirtBtn);
        }
        public CartPage clickShoppingCartBtn()
        {
            waitAndClick(shoppingCartLink);
            return CartPage.getInstance(driver);
        }
        public void clickMenuBtn()
        {
            waitAndClick(menuBtn);
        }

        public SauceLabs clickAboutBtn()
        {
            waitAndClick(aboutLink, 15);
            return SauceLabs.getInstance(driver);
        }
        public String getPrice(int productNumber)
        {
            By productPrice = By.XPath("//*[@class='inventory_list']/div["+productNumber+"]/div[2]/div[2]/div");
            return getText(productPrice);
        }
        public void clickAddProduct(int productNumber)
        {                               
            By addProductBtn = By.XPath("//*[@class='inventory_list']/div["+productNumber+"]/div/div[2]/button");
            waitAndClick(addProductBtn);
        }
       
    }
}
