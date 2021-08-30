using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SampleApplication
{
    [TestClass]
    public class SampleApplicationOne
    {
        internal testData ThetestData { get; private set; }
        private IWebDriver Driver { get; set; }
        [TestMethod]
        public void TestMethod1()
        {
            Driver = GetChromeDriver();
            var sampleApplicationPage = new SampleApplicationPage(Driver);
            sampleApplicationPage.GoTo();
           // Assert.IsTrue(sampleApplicationPage.IsVisible, "Google Page is not visible");

          //  var searchPage = sampleApplicationPage.fillAndSubmit();
         //   Assert.IsTrue(searchPage.IsVisible, "Google Search Page is not visible");
        }

        [TestMethod]
        public void TestMethod2()
        {
            ThetestData = new testData();
            ThetestData.oneFrom = "chennai";
            ThetestData.multiFrom = "Chennai";
            ThetestData.tripType = trip.OneWay;
            Driver = GetChromeDriver();
            var sampleApplicationPage = new SampleApplicationPage(Driver);
            sampleApplicationPage.GoTo();
           // Assert.IsTrue(sampleApplicationPage.IsVisible, "Google Page is not visible");

            sampleApplicationPage.fillAndSubmit(ThetestData);
           // Assert.IsTrue(searchPage.IsVisible, "Google Search Page is not visible");
        }

       /* [TestCleanup]
        public void CleanUp()
        {
            Driver.Close();
            Driver.Quit();
        }*/

        private IWebDriver GetChromeDriver()
        {
            return new ChromeDriver();
        }
    }
}
