using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;


namespace TestProject1
{
    public class Tests
    {
        IWebDriver driver;
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            driver = new ChromeDriver();
        }


        [Test]
        public void Test1()
        {

            /*ChromeOptions options = new ChromeOptions();
            options.AddArgument("--lang=en");
            IWebDriver driver = new ChromeDriver(options);*/


            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com/");
            IWebElement searchBoxID = driver.FindElement(By.Name("q"));
            IWebElement searchBoxXPATH = driver.FindElement(By.XPath("//input[@name='q']"));
            IWebElement searchBoxCSS = driver.FindElement(By.CssSelector("input[name=q]"));

            
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}