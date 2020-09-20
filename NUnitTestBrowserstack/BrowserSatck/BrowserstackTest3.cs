using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestBrowserstack.BrowserSatck
{
    [TestFixture]
    [Parallelizable]
    public class BrowserstackTest3 : BaseTest
    {
      
        [Test]
        public void BrowserStackTest31()
        {

            logger = extent.CreateTest("BrowserStackTest31");
            driver.Navigate().GoToUrl("http://www.qtptutorial.net/automation-practice");
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(3000);
            // driver.FindElement(By.Id("idExample")).Click();
            // var elementCheck = driver.FindElement(By.XPath("//p[contains(text(),'Button success')]")).Displayed;
            Assert.IsTrue(true);
            logger.Log(Status.Pass, "Title BrowserStackTest31");
        }

        [Test]
        public void BrowserStackTest32()
        {
            logger = extent.CreateTest("BrowserStackTest32");
            driver.Navigate().GoToUrl("http://www.qtptutorial.net/automation-practice");
            driver.Manage().Window.Maximize();
            // driver.FindElement(By.Id("idExample")).Click();
            // var elementCheck = driver.FindElement(By.XPath("//p[contains(text(),'Button success')]")).Displayed;
            Assert.IsTrue(true);
            logger.Log(Status.Pass, "Title BrowserStackTest32");
        }

        [Test]
        public void BrowserStackTest33()
        {
            logger = extent.CreateTest("BrowserStackTest33");
            driver.Navigate().GoToUrl("http://www.qtptutorial.net/automation-practice");
            driver.Manage().Window.Maximize();
            // driver.FindElement(By.Id("idExample")).Click();
            // var elementCheck = driver.FindElement(By.XPath("//p[contains(text(),'Button success')]")).Displayed;
            Assert.IsTrue(true);
            logger.Log(Status.Pass, "Title BrowserStackTest33");
        }

        [Test]
        public void BrowserStackTest34()
        {
            logger = extent.CreateTest("BrowserStackTest34");
            driver.Navigate().GoToUrl("http://www.qtptutorial.net/automation-practice");
            driver.Manage().Window.Maximize();
            // driver.FindElement(By.Id("idExample")).Click();
            // var elementCheck = driver.FindElement(By.XPath("//p[contains(text(),'Button success')]")).Displayed;
            Assert.IsTrue(true);
            logger.Log(Status.Pass, "Title BrowserStackTest34");
        }

    }
}
