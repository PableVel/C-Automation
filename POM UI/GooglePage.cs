using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_UI
{
    public class GooglePage:BasePage
    {
        private static GooglePage instance;
        
        private By searchBoxName = By.Name("q");
        private By searchBoxXpath = By.XPath("//input[@name='q']");
        private By searchBoxCss = By.CssSelector("input[name=q]");
        private GooglePage(IWebDriver driver) : base(driver) 
        {
            this.driver.Navigate().GoToUrl("https://www.google.com/");
        }
       
        public static GooglePage getInstance(IWebDriver driver)
        {
            if(instance == null)
            {
                instance = new GooglePage(driver);
            }
            return instance;
        }
        public void typeSearchBoxName(String textToType)
        {
            waitAndType(searchBoxName, textToType);
        }
        public void typeSearchBoxXpath(String textToType)
        {
            waitAndType(searchBoxXpath, textToType);
        }
        public void typeSearchBoxCss(String textToType)
        {
            waitAndType(searchBoxCss, textToType);
        }





    }
}
