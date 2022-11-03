using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonFramework;
using System.Runtime.ConstrainedExecution;
using static System.Net.WebRequestMethods;
using OpenQA.Selenium.Support.UI;

namespace POM_UI
{
    public class BasePage
    {
        public IWebDriver driver;
        WebDriverWait wait;
        


        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            this.driver.Manage().Window.Maximize();
            
            wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(10));
        }

        public void GoToUrl(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void waitAndClick(By locator)
        {

            try
            {
                IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
                element.Click();
            }
            catch (NoSuchElementException nE)
            {
                Console.WriteLine(nE.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void waitAndType(By locator, String textToType)
        {
            try
            {
                IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
                element.Clear();
                element.SendKeys(textToType);
            }
            catch (NoSuchElementException nE)
            {
                Console.WriteLine(nE.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void waitAndClick(By locator, int maxTime)
        {
            WebDriverWait newWait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxTime));
            try
            {
                IWebElement element = newWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
                element.Click();
            }
            catch (NoSuchElementException nE)
            {
                Console.WriteLine(nE.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void waitAndType(By locator, int maxTime, String textToType)
        {
            WebDriverWait newWait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxTime));
            try
            {
                IWebElement element = newWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
                element.Clear();
                element.SendKeys(textToType);
            }
            catch (NoSuchElementException nE)
            {
                Console.WriteLine(nE.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void selectFromDropDownByText(By locator,String textToCompare)
        {
            new SelectElement(wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator))).SelectByText(textToCompare);
        }

        public String getTitle(String expectedTitle)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TitleContains(expectedTitle));
            return driver.Title;
        }

        public String getURL(String expectedURL)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains(expectedURL));
            return driver.Url;
        }

        





    }
}
