using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWithXUnit
{
    public class HtmlContactFormTests
    {
        public IWebDriver driver;

        [Fact]
        public void FindElementsWithDifferentTypesOfLocators()
        {
            //Initialise Chrome Driver
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/html-contact-form/");

            IWebElement firstName = driver.FindElement(By.ClassName("firstname"));
            firstName.SendKeys("Name");

            IWebElement lastName = driver.FindElement(By.Id("lname"));
            lastName.SendKeys("LastName");

            IWebElement countryField = driver.FindElement(By.CssSelector("input[name='country']"));
            countryField.SendKeys("United States");

            IWebElement firstLink = driver.FindElement(By.PartialLinkText("Google Link"));

            IWebElement secondLink = driver.FindElement(By.XPath("//a[text()='Google Link is here']"));

            IWebElement subject = driver.FindElement(By.Id("subject"));
            subject.SendKeys("Subject");

            IWebElement submitButton = driver.FindElement(By.CssSelector("Input[value='Submit']"));
            submitButton.Click();

            //Close chrome browser.
            driver.Quit();
        }
    }
}
