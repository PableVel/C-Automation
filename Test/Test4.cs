using CommonFramework;
using OpenQA.Selenium;
using POM_UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Test4
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = Driver.driverConstructor(Browser.Chrome);
        }
        [Test]
        public void task4()
        {
            LoginPage loginObj = LoginPage.getInstance(driver);
            ProductsPage productsObj = loginObj.login("standard_user", "secret_sauce");
            String price1 = productsObj.getPrice(1);
            productsObj.clickAddProduct(1);
            CartPage cartObj = productsObj.clickShoppingCartBtn();
            String price2 = cartObj.getPrice();
            Assert.IsTrue(price1 == price2);
            CheackoutPage1 checkoutObj = cartObj.clickCheckoutBtn();
            checkoutObj.typeFirstNameField("Pablo");
            checkoutObj.typeLastNameFieldd("Velazquez");
            checkoutObj.typeZipCodeField("35234");
            CheackoutPage2 checkout2Obj = checkoutObj.clickContinue();
            String price3 = checkout2Obj.getPrice();
            Assert.IsTrue(price2 == price3);
            checkout2Obj.clickFinishBtn();





        }
        [OneTimeTearDown]
        public void tearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
