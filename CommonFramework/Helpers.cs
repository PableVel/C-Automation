using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace TestProject1
{
    class Helpers
    {
        /*IWebDriver driver;
        WebDriverWait wait;
        public Helpers(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        
        public void waitAndClick(By locator)
        {
            
            try
            {
                IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
                element.Click();
                Console.WriteLine(locator + " was clicked");
            }
            catch (NoSuchElementException nE) {
                Console.WriteLine(nE.Message);
            }
            
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Fail("This element does not exists: " + locator);
                
            }
        }
        public void waitAndType(By locator, String textToType)
        {
            try
            {
                IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
                element.SendKeys(textToType);
                Console.WriteLine("Keys sent to "+ locator );
            }
            catch (NoSuchElementException nE)
            {
                Console.WriteLine(nE.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Fail("This element does not exists: " + locator);

            }
        }
        public void waitAndClick (By locator, int maxTime)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxTime));
            try
            {
                IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
                element.Click();
                Console.WriteLine(locator + " was clicked");
            }
            catch (NoSuchElementException nE)
            {
                Console.WriteLine(nE.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Fail("This element does not exists: " + locator);

            }
        }
        public void waitAndType(By locator, int maxTime, String textToType)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(maxTime));
            try
            {
                IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
                element.SendKeys(textToType);
                Console.WriteLine("Keys sent to " + locator);
            }
            catch (NoSuchElementException nE)
            {
                Console.WriteLine(nE.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.Fail("This element does not exists: " + locator);

            }
        }*/
    }
}
