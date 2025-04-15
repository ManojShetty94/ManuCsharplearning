using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    internal class Locators
    {

       IWebDriver driver;

        [SetUp]

        public void StartBrowser()
        {

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig()); 
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://rahulshettyacademy.com/locatorspractice";

        }

        [Test]
        public void Test()
        {

            driver.FindElement(By.Id("inputUsername")).SendKeys("Manoj");
            driver.FindElement(By.Name("inputPassword")).SendKeys("Shetty123");
            //driver.FindElement(By.CssSelector("button[type='submit']")).Click();
            driver.FindElement(By.XPath("//input[@id='chkboxTwo']")).Click();
            driver.FindElement(By.CssSelector("#chkboxOne")).Click();
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            Thread.Sleep(3000);
            String errorMessage=driver.FindElement(By.ClassName("error")).Text;
            TestContext.Progress.WriteLine(errorMessage);
            
                    }

        [TearDown]

        public void TearDown()
        {
            driver.Quit();
        }

    }
}
    