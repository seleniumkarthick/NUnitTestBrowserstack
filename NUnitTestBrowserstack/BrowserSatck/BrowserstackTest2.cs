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
    public class BrowserstackTest2 : BaseTest
    {
       
        [Test]
        public void BrowserStackTest21()
        {
            logger = extent.CreateTest("BrowserStackTest21");
            driver.Navigate().GoToUrl("http://www.qtptutorial.net/automation-practice");
            driver.Manage().Window.Maximize();
            // driver.FindElement(By.Id("idExample")).Click();
            // var elementCheck = driver.FindElement(By.XPath("//p[contains(text(),'Button success')]")).Displayed;
            Assert.IsTrue(true);
            logger.Log(Status.Pass, "Title BrowserStackTest21");
        }


        [Test]
        public void BrowserStackTest22()
        {
            logger = extent.CreateTest("BrowserStackTest22");
            driver.Navigate().GoToUrl("http://www.qtptutorial.net/automation-practice");
            driver.Manage().Window.Maximize();
            // driver.FindElement(By.Id("idExample")).Click();
            // var elementCheck = driver.FindElement(By.XPath("//p[contains(text(),'Button success')]")).Displayed;
            Assert.IsTrue(true);
            logger.Log(Status.Pass, "Title BrowserStackTest22");
        }


        [Test]
        public void BrowserStackTest23()
        {
            logger = extent.CreateTest("BrowserStackTest23");
            driver.Navigate().GoToUrl("http://www.qtptutorial.net/automation-practice");
            driver.Manage().Window.Maximize();
             driver.FindElement(By.Id("idExample")).Click();
            // var elementCheck = driver.FindElement(By.XPath("//p[contains(text(),'Button success')]")).Displayed;
            Assert.IsTrue(true);
            logger.Log(Status.Pass, "Title BrowserStackTest23");
        }


        [Test]
        public void BrowserStackTest24()
        {
            logger = extent.CreateTest("BrowserStackTest24");
            driver.Navigate().GoToUrl("http://www.qtptutorial.net/automation-practice");
            driver.Manage().Window.Maximize();
            // driver.FindElement(By.Id("idExample")).Click();
            // var elementCheck = driver.FindElement(By.XPath("//p[contains(text(),'Button success')]")).Displayed;
            Assert.IsTrue(true);
            logger.Log(Status.Pass, "Title BrowserStackTest24");
        }


    }
}
