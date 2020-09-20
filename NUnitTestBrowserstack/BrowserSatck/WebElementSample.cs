using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestBrowserstack.BrowserSatck
{
    class WebElementSample
    {

        public IWebDriver driver;

        public WebElementSample(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void waitPageLoad()
        {
            string x=driver.Url;
        }


    }
}
