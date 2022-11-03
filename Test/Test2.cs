using OpenQA.Selenium;
using CommonFramework;
using POM_UI;
namespace Test
{
    [TestFixture]
    public class Test2
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = Driver.driverConstructor(Browser.Chrome);
        }

        [Test]
        public void task2()
        {
            LoginPage loginObj = LoginPage.getInstance(driver);
            loginObj.typeUser("standard_user");
            loginObj.typePassword("secret_sauce");
            ProductsPage productsObj = loginObj.clickLogin();
            Assert.AreEqual("Swag Labs", productsObj.getTitle("Swag Labs"));
            productsObj.selectFromContainerByText("Price (low to high)");
            productsObj.clickAddCartBikeLightBtn();
            productsObj.clickAddCartBoltTShirtBtn();
            CartPage cartObj = productsObj.clickShoppingCartBtn();
            Assert.AreEqual("https://www.saucedemo.com/cart.html", cartObj.getURL("https://www.saucedemo.com/cart.html"));
            productsObj = cartObj.clickBack();
            Assert.AreEqual("Swag Labs", productsObj.getTitle("Swag Labs"));
            productsObj.clickMenuBtn();
            SauceLabs sauceLabsObj = productsObj.clickAboutBtn();
            Assert.AreEqual("Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs", sauceLabsObj.getTitle("Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs"));
            


        }

        [OneTimeTearDown]
        public void tearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}