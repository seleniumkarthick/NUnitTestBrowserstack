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
        public class BrowserstackTest : BaseTest
        {
           
        [Test]
        [Parallelizable]
        public void BrowserStackTest1()
            {
            logger = extent.CreateTest("BrowserStackTest1");
            //  driver.Navigate().GoToUrl("http://www.qtptutorial.net/automation-practice");
            driver.Manage().Window.Maximize();
           
            // driver.FindElement(By.Id("idExample")).Click();
            // var elementCheck = driver.FindElement(By.XPath("//p[contains(text(),'Button success')]")).Displayed;
            Assert.IsTrue(true);
            logger.Log(Status.Pass, "Title BrowserStackTest1");
        }

        [Test]
        [Parallelizable]
        public void BrowserStackTest12()
        {
            logger = extent.CreateTest("BrowserStackTest12");
            // driver.Navigate().GoToUrl("http://www.google.com");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("idExample")).Click();
            // var elementCheck = driver.FindElement(By.XPath("//p[contains(text(),'Button success')]")).Displayed;
            Assert.IsTrue(true);
            logger.Log(Status.Pass, "Title BrowserStackTest12");
        }

        [Test]
        [Parallelizable]
        public void BrowserStackTest13()
        {
            logger = extent.CreateTest("BrowserStackTest13");
            // driver.Navigate().GoToUrl("http://www.facebook.com");
            driver.Manage().Window.Maximize();
            // driver.FindElement(By.Id("idExample")).Click();
            // var elementCheck = driver.FindElement(By.XPath("//p[contains(text(),'Button success')]")).Displayed;
            Assert.IsTrue(true);
            logger.Log(Status.Pass, "Title BrowserStackTest13");
        }

        [Test]
        [Parallelizable]
        public void BrowserStackTest14()
        {
            logger = extent.CreateTest("BrowserStackTest14");
            // driver.Navigate().GoToUrl("http://www.qtptutorial.net/automation-practice");
            driver.Manage().Window.Maximize();
            // driver.FindElement(By.Id("idExample")).Click();
            // var elementCheck = driver.FindElement(By.XPath("//p[contains(text(),'Button success')]")).Displayed;
            Assert.IsTrue(true);
            logger.Log(Status.Pass, "Title BrowserStackTest14");
        }


    }


    
}
