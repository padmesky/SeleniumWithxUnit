using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWithXUnit
{
    public class FirstSeleniumTest: IDisposable
    {
        public IWebDriver driver;
        public FirstSeleniumTest()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");
        }

        public void Dispose()
        {
            driver.Quit();
        }

        [Fact]
        public void Test1()
        {
            IWebElement searchBar = driver.FindElement(By.ClassName("entry-title"));
            Assert.Contains(searchBar.Text, "Home");
        }

    }
}
