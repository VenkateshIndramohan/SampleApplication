﻿using OpenQA.Selenium;

namespace SampleApplication
{
    internal class BaseSampleApplicationPage 
    {
       protected IWebDriver Driver { get; set; }

        public BaseSampleApplicationPage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}