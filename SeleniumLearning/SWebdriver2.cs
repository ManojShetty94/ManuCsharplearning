using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using OpenQA.Selenium.Firefox;

namespace SeleniumLearning
{
 public class SWebdriver2
    {
        
IWebDriver driver;

        [SetUp]

        public void SetupBrowser()
        {

            // new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig()); // for chrome driver

            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            //driver = new ChromeDriver();

            driver = new FirefoxDriver();

        }

        [Test]

        public void Test()
        {

            driver.Url = "https://rahulshettyacademy.com/";
            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Url);
            System.Threading.Thread.Sleep(10000);

        }

        [TearDown]

        public void TearDown()

        {
            driver.Quit();
        }

    }
}
