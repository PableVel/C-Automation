using OpenQA.Selenium;
using CommonFramework;
using POM_UI;
namespace Test
{
    [TestFixture]
    public class Test3
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = Driver.driverConstructor(Browser.Chrome);
        }

        [Test]
        public void task3()
        {
            LoginPage loginObj = LoginPage.getInstance(driver);
            ProductsPage productsObj = loginObj.login("standard_user", "secret_sauce");
            String title  = productsObj.getTitle();
            Console.WriteLine("The title is: "+ title+" and its size is: "+title.Length);
            String url = productsObj.getURL();
            Console.WriteLine("The url is: "+ url+" and its size is: "+url.Length);
            String pageSource = productsObj.getPageSource();
            Console.WriteLine("The page soucer is: ");
            Console.WriteLine(pageSource);
            Console.WriteLine("And its size is: "+ pageSource.Length);
        }

        [OneTimeTearDown]
        public void tearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}