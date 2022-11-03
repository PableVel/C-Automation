using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TestProject1
{
    public class Tests
    {
        /* IWebDriver driver;

       [OneTimeSetUp]
       public void OneTimeSetUp()
       {
           driver = new ChromeDriver();
           driver.Manage().Window.Maximize();
           /*helpers = new Helpers(driver);*//*
    }


    [Test]
        public void Test2()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            helpers.waitAndType(By.Name("user-name"), "standard_user");
            helpers.waitAndType(By.Id("password"), "secret_sauce");
            helpers.waitAndClick(By.XPath("//input[@data-test=\"login-button\"]"));
            SelectElement dropDown = new SelectElement(driver.FindElement(By.CssSelector("select.product_sort_container")));
            dropDown.SelectByText("Price (low to high)");
            helpers.waitAndClick(By.Name("add-to-cart-sauce-labs-bike-light"));
            helpers.waitAndClick(By.CssSelector("button[data-test=\"add-to-cart-sauce-labs-bolt-t-shirt\"]"));
            helpers.waitAndClick(By.XPath("//*[@id=\"shopping_cart_container\"]/a"));
            helpers.waitAndClick(By.CssSelector("[class=\"btn btn_secondary back btn_medium\"]"));
            helpers.waitAndClick(By.XPath("//*[@data-test=\"product_sort_container\"]"));
            helpers.waitAndClick(By.CssSelector("button[id=\"react-burger-menu-btn\"]"));
            helpers.waitAndClick(By.LinkText("ABOUT"), 5);
            Assert.AreEqual(driver.Title, "Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs");
        }
        [OneTimeTearDown]
        public void TearDown()
        {
            Thread.Sleep(3000);
            driver.Close();

        }*/
    }
}