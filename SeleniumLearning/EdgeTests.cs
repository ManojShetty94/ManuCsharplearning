using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
   
    public class EdgeTests
    {

        IWebDriver driver;


        [SetUp]

        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();

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
            driver.Close();
        }

    }
    }

