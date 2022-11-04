using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace POM_UI
{
    public class LoginPage:BasePage
    {
        private static LoginPage? _instance;
        private By userField = By.Name("user-name");
        private By passwordField = By.Id("password");
        private By loginBtn = By.XPath("//input[@data-test=\"login-button\"]");
        private static readonly object padlock = new object();
        public static IWebDriver? myDriver = null;


        private LoginPage(IWebDriver driver): base(driver)
        {
        }
        public static LoginPage getInstance(IWebDriver Driver)
        {
            lock (padlock)
            {
                
                
                if (_instance == null)
                {
                    _instance = new LoginPage(Driver);
                    myDriver = Driver;
                }
                else if(Driver != myDriver)
                {
                    _instance = new LoginPage(Driver);
                }
                Driver.Manage().Window.Maximize();

                Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
                return _instance;
            }
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

        public ProductsPage login(String user, String password) {
            typeUser(user);
            typePassword(password);
            return clickLogin();
        }

    }
}
