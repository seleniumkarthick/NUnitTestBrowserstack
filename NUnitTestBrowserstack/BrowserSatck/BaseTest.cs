using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace NUnitTestBrowserstack.BrowserSatck
{
    public class BaseTest
    {
        public IWebDriver driver;

        public static ExtentHtmlReporter reporter;
        public static ExtentReports extent;
        public ExtentTest logger;

        //public static ExtentReports extent;
        //public static ExtentTest test;


        public static int x = 1;

        WebElementSample webElementSampleObj;

        [OneTimeSetUp]
        public void BeforeSetup()
        {
            if (x == 1)
            {
               
                string date = DateTime.Now.ToString("MM_dd_yyyy_HH_mm_ss");
                string baseDirPath = "C:\\Users\\Karthick Kumar\\source\\repos\\NUnitTestBrowserstack\\NUnitTestBrowserstack\\BrowserSatck\\Reports\\" + date +"\\test" ;

                reporter = new ExtentHtmlReporter(baseDirPath);
                extent = new ExtentReports();
                extent.AttachReporter(reporter);
               
           }
            x++;

        }


        [SetUp]
        [Obsolete]
        public void Init()
        {

          
         
            //https://www.browserstack.com/automate/capabilities
            //DesiredCapabilities caps = new DesiredCapabilities();

            string browser= "edge";
            Boolean browserStack = true;

            //caps.SetCapability("os", "Windows");
            //caps.SetCapability("os_version", "10");

            string browserstack_user = "karthickkumar15";
            string browserstack_pass = "278oHcHgmLKVbpUzs8NK";

            if (browserStack == true)
            {

           
                    if (browser.Equals("chrome"))
                    {

                        ChromeOptions capability = new ChromeOptions();
                        capability.AddAdditionalCapability("os", "Windows", true);
                        capability.AddAdditionalCapability("os_version", "10", true);
                        capability.AddAdditionalCapability("browser", "Chrome", true);
                        capability.AddAdditionalCapability("browser_version", "84.0", true);
                        capability.AddAdditionalCapability("browserstack.local", "false", true);
                        capability.AddAdditionalCapability("browserstack.selenium_version", "3.14.0", true);
                        capability.AddAdditionalCapability("browserstack.user", browserstack_user, true);
                        capability.AddAdditionalCapability("browserstack.key", browserstack_pass, true);

                        driver = new RemoteWebDriver(
                             new Uri("https://hub-cloud.browserstack.com/wd/hub/"), capability
                        );
                        // caps.SetCapability("browser", "Chrome");
                        //caps.SetCapability("browser_version", "80");

                    }
                    else if (browser.Equals("firefox"))
                    {


                        FirefoxOptions capability = new FirefoxOptions();
                        capability.AddAdditionalCapability("os", "Windows", true);
                        capability.AddAdditionalCapability("os_version", "10", true);
                        capability.AddAdditionalCapability("browser", "Firefox", true);
                        capability.AddAdditionalCapability("browser_version", "latest", true);
                        capability.AddAdditionalCapability("browserstack.local", "false", true);
                        capability.AddAdditionalCapability("browserstack.selenium_version", "3.10.0", true);
                        capability.AddAdditionalCapability("browserstack.user", browserstack_user, true);
                        capability.AddAdditionalCapability("browserstack.key", browserstack_pass, true);


                        driver = new RemoteWebDriver(
                             new Uri("https://hub-cloud.browserstack.com/wd/hub/"), capability
                        );
                        //caps.SetCapability("browser", "Firefox");
                        // caps.SetCapability("browser_version", "latest");

                    }
                    else if (browser.Equals("ie"))
                    {

                        InternetExplorerOptions capability = new InternetExplorerOptions();
                        capability.AddAdditionalCapability("os", "Windows", true);
                        capability.AddAdditionalCapability("os_version", "10", true);
                        capability.AddAdditionalCapability("browser", "IE", true);
                        capability.AddAdditionalCapability("browser_version", "11.0", true);
                        capability.AddAdditionalCapability("browserstack.local", "false", true);
                        capability.AddAdditionalCapability("browserstack.selenium_version", "3.5.2", true);
                        capability.AddAdditionalCapability("browserstack.user", browserstack_user, true);
                        capability.AddAdditionalCapability("browserstack.key", browserstack_pass, true);

                        driver = new RemoteWebDriver(
                             new Uri("https://hub-cloud.browserstack.com/wd/hub/"), capability
                        );
                        //caps.SetCapability("browser", "IE");
                        // caps.SetCapability("browser_version", "11.0");

                    }
                    else if (browser.Equals("edge"))
                    {

                        EdgeOptions capability = new EdgeOptions();
                        capability.AddAdditionalCapability("os", "Windows");
                        capability.AddAdditionalCapability("os_version", "10");
                        capability.AddAdditionalCapability("browser", "Edge");
                        capability.AddAdditionalCapability("browser_version", "84.0");
                        capability.AddAdditionalCapability("browserstack.local", "false");
                        capability.AddAdditionalCapability("browserstack.selenium_version", "3.5.2");
                        capability.AddAdditionalCapability("browserstack.user", browserstack_user);
                        capability.AddAdditionalCapability("browserstack.key", browserstack_pass);

                        driver = new RemoteWebDriver(
                         new Uri("https://hub-cloud.browserstack.com/wd/hub/"), capability
                         );
                        // caps.SetCapability("browser", "Edge");
                        // caps.SetCapability("browser_version", "81.0");

                    }
            }
            else
            {
                driver = new ChromeDriver();
            }

            /*caps.SetCapability("browserstack.user", USERNAME);
            caps.SetCapability("browserstack.key", AUTOMATE_KEY);
            caps.SetCapability("name", "Parallel All Test");
            caps.SetCapability("browserstack.local", "true");
*/




            driver.Url = "http://localhost:81/product";


            webElementSampleObj = new WebElementSample(driver);



        }


        [OneTimeTearDown]
        public void Cleanup()
        {
         

           // extent.Flush();
          




        }


        [TearDown]
        public void AfterClass()
        {
            //StackTrace details for failed Testcases
            var status = TestContext.CurrentContext.Result.Outcome.Status;

            var errorMessage = TestContext.CurrentContext.Result.Message;
            if (status == TestStatus.Failed)
            {
                logger.Log(Status.Fail, "Title failed");
            }

            driver.Quit();

            //End test report
            extent.Flush();

          
        }

       
        


    }
}
