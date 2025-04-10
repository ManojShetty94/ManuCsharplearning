using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace SeleniumLearning
{
 public class SWebdriver2
    {
        
IWebDriver driver;

        [SetUp]

        public void SetupBrowser()
        { 
        
        new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

              }

        [Test]

        public void Test()
        {

            driver.Url = "https://chatgpt.com/";
        }

        [TearDown]

        public void TearDown() 
        
        {
            driver.Quit();
        }

    }
}
