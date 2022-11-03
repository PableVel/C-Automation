using NUnit.Framework;
using OpenQA.Selenium;
using CommonFramework;
using POM_UI;

namespace Tests
{
    public class Task1
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            driver = Driver.driverConstructor(Browser.FireFox);
        }

        [Test]
        public void task1()
        {
            GooglePage googlePage = GooglePage.getInstance(driver);
            googlePage.typeSearchBoxXpath("Hi");
            googlePage.typeSearchBoxCss("Karthik");
            googlePage.typeSearchBoxID("from");
            googlePage.typeSearchBoxName("Mexico");
        }

        [OneTimeTearDown]
        public void tearDown()
        {
            driver.Quit();
        }
        

        
    }
}
