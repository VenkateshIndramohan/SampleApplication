using AutomationResources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SampleApplication
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void SetupForEverySingleTestMethod()
        {
            var factory = new WebDriverFactory();
            driver = factory.Create(BrowserType.Chrome);

        }
        private IWebDriver driver;
        [TestMethod]
        public void TestMethod1()
        {
           // driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.cleartrip.com/flights?utm_source=google&utm_medium=cpc&utm_campaign=BR_Cleartrip-Desktab&dxid=CjwKCAjw1JeJBhB9EiwAV612yzfxQhY02yTVG3bDFan2KurX76mSEg65Grm-4JHKkh5H8KHcM6mp-xoCxpMQAvD_BwE&gclid=CjwKCAjw1JeJBhB9EiwAV612yzfxQhY02yTVG3bDFan2KurX76mSEg65Grm-4JHKkh5H8KHcM6mp-xoCxpMQAvD_BwE");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[2]/label[1]/div[1]/span")).Click();
            driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[3]/div[1]/div[1]/div/div/div/input")).SendKeys("chennai");
          
            driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[2]/label[3]/div[1]/span")).Click();
            driver.FindElement(By.XPath("//*[@id='root'']/div/div/div[1]/div/div[2]/div/div[3]/div/div[2]/div[1]/div/div/input")).SendKeys("chennai");
        }
    }
}
