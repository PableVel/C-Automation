using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;


namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void Test1()
        {

            /*ChromeOptions options = new ChromeOptions();
            options.AddArgument("--lang=en");
            IWebDriver driver = new ChromeDriver(options);*/

            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com/");
            IWebElement searchBoxID = driver.FindElement(By.Name("q"));
            IWebElement searchBoxXPATH = driver.FindElement(By.XPath("//div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input"));
            IWebElement searchBoxCSS = driver.FindElement(By.CssSelector("body > div.L3eUgb > div.o3j99.ikrT4e.om7nvf > form > div:nth-child(1) > div.A8SBwf > div.RNNXgb > div > div.a4bIc > input"));

            driver.Quit();
        }
    }
}