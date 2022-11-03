using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_UI
{
    public class CheackoutPage1:BasePage
    {
        private static CheackoutPage1 instance;
        private By firstNameField = By.Id("first-name");
        private By lastNameField = By.Id("last-name");
        private By zipCodeField = By.Id("postal-code");
        private By continueBtn = By.Id("continue");
        private static readonly object padlock = new object();

        private CheackoutPage1(IWebDriver driver) : base(driver) { }
        public static CheackoutPage1 getInstance(IWebDriver driver)
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new CheackoutPage1(driver);
                }
                return instance;
            }
        }

        public void typeFirstNameField(String textToType)
        {
            waitAndType(firstNameField,textToType);
        }
        public void typeLastNameFieldd(String textToType)
        {
            waitAndType(lastNameField, textToType);
        }
        public void typeZipCodeField(String textToType)
        {
            waitAndType(zipCodeField, textToType);
            
        }
        public CheackoutPage2 clickContinue()
        {
            waitAndClick(continueBtn);
            return CheackoutPage2.getInstance(driver);
        }
    }
}
