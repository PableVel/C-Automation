using OpenQA.Selenium;
using CommonFramework;
using POM_UI;
namespace Test
{
    [TestFixture]
    public class Test1
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = Driver.driverConstructor(Browser.Chrome);
        }

        [Test]
        public void task1()
        {
            GooglePage googlePage = GooglePage.getInstance(driver);
            googlePage.typeSearchBoxXpath("Hi");
            googlePage.typeSearchBoxCss("Karthik");
            googlePage.typeSearchBoxName("from Mexico");

            Assert.Pass();
        }

        [OneTimeTearDown]
        public void tearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}