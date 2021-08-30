using OpenQA.Selenium;

namespace SampleApplication
{
    internal class searchPage : BaseSampleApplicationPage
    {
        //private IWebDriver Driver { get; set; }
        public searchPage(IWebDriver driver) : base(driver) { }
        /*{
            Driver = driver;
        }*/

        public string title => Driver.Title;

        public bool IsVisible => title.Contains("testing - Google Search");

        




    }
}