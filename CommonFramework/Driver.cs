using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace CommonFramework
{
    public enum Browser
    {
        /*FireFox,*/
        Chrome
    }
    public class Driver
    {
        private static IWebDriver? driver = null;

        private Driver(Browser browserType)
        {
            /*if (browserType == Browser.FireFox)
            {
                new DriverManager().SetUpDriver(new FirefoxConfig());
                driver = new FirefoxDriver();
            } else*/ if (browserType == Browser.Chrome)
            {
                /*new DriverManager().SetUpDriver(new ChromeConfig());*/
                driver = new ChromeDriver();
            } else driver = new InternetExplorerDriver();
        }

        public static IWebDriver driverConstructor(Browser browserType)
        {
            if(driver == null)
            {
                new Driver(browserType);
            }
            return driver;
        }
    }
}
