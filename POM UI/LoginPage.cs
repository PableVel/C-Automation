using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace POM_UI
{
    public class LoginPage:BasePage
    {
        private static LoginPage instance;
        private By userField = By.Name("user-name");
        private By passwordField = By.Id("password");
        private By loginBtn = By.XPath("//input[@data-test=\"login-button\"]");

        private LoginPage(IWebDriver driver): base(driver)
        {
            this.driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        }
        public static LoginPage getInstance(IWebDriver driver)
        {
            if(instance == null) { 
                instance = new LoginPage(driver);
            }
            return instance;
        }

        public void typeUser(String textToType)
        {
            waitAndType(userField, textToType);
        }
        public void typePassword(String textToType)
        {
            waitAndType(passwordField, textToType);
        }
        public ProductsPage clickLogin()
        {
            waitAndClick(loginBtn);
            return ProductsPage.getInstance(driver);
        }

    }
}
