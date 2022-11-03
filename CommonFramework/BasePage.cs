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
            wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(35));
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

        public String getTitle()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.TagName("div")));
            return driver.Title;
        }

        public String getURL()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.TagName("div")));
            return driver.Url;
        }

        public String getPageSource()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(By.TagName("div")));
            return driver.PageSource;
        }
        public String getText(By locator)
        {
            IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
            return element.Text;
        }


        





    }
}
