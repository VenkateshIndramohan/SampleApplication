using NLog;
using OpenQA.Selenium;
using System;

namespace SampleApplication
{
    internal class SampleApplicationPage : BaseSampleApplicationPage
    {
        // private IWebDriver Driver { get; set; }
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public SampleApplicationPage(IWebDriver driver) : base(driver) { }
        /*{
            Driver = driver;
        }*/

        internal void GoTo()
        {
            logger.Trace("Attempting to open the application");
            var url = "https://www.cleartrip.com/flights?utm_source=google&utm_medium=cpc&utm_campaign=BR_Cleartrip-Desktab&dxid=CjwKCAjw1JeJBhB9EiwAV612yzfxQhY02yTVG3bDFan2KurX76mSEg65Grm-4JHKkh5H8KHcM6mp-xoCxpMQAvD_BwE&gclid=CjwKCAjw1JeJBhB9EiwAV612yzfxQhY02yTVG3bDFan2KurX76mSEg65Grm-4JHKkh5H8KHcM6mp-xoCxpMQAvD_BwE";
            Driver.Navigate().GoToUrl(url);
            logger.Info($"Opened url => {url}");
            Driver.Manage().Window.Maximize();
        }

        public bool IsVisible 
        {
            get
            {
                return Driver.Title.Contains("Google");
            }
            internal set { }
        }

        public IWebElement searchBox => Driver.FindElement(By.Name("q"));

        internal void fillAndSubmit(testData data)
        {
            /* IWebElement searchBox = Driver.FindElement(By.Name("q"));
             searchBox.SendKeys(v);
             searchBox.SendKeys(Keys.Enter);
             return new searchPage(Driver);*/
            logger.Trace("Attempting to select");
            switch (data.tripType)
            {
                case trip.OneWay:
                    Driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[2]/label[1]/div[1]/span")).Click();
                    logger.Info($"Selected trip type as => {trip.OneWay}");
                    var oneFrom = Driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[3]/div[1]/div[1]/div/div/div/input"));
                    oneFrom.SendKeys(data.oneFrom);
                    logger.Info($"From text box entered => {data.oneFrom}");
                    break;
                case trip.MultiCity:
                    Driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[2]/label[3]/div[1]/span")).Click();
                    var multiFrom = Driver.FindElement(By.XPath("//*[@id='root']/div/div/div[1]/div/div[2]/div/div[3]/div/div[2]/div[1]/div/div/input"));
                    multiFrom.SendKeys(data.multiFrom);
                    break;

                default:
                    break;
            }

        }
    }
}