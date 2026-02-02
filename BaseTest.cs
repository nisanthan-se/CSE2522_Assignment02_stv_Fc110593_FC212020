using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CSE2522_Assignment02.Utilities
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://uitestingplayground.com/");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}

