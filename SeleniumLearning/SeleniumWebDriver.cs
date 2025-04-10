using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning 
{
    public class SeleniumWebDriver // Declares a class called SeleniumWebDriver.

    {
        IWebDriver driver; // Declares a field of type IWebDriver, which represents the web browser instance.


        [SetUp] // Attribute indicating that the following method should be run before each test (setup phase).


        public void StartBrowser() // The method used to initialize the WebDriver and open a browser.
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig()); // Automatically sets up the ChromeDriver using WebDriverManager.

            driver = new ChromeDriver(); // Initializes a new Chrome browser session by creating an instance of ChromeDriver.

            }



        [Test] // Attribute indicating that the following method is a test method to be run during the test phase.

        public void Test() // The test method where the actual test logic will be written.

        {
            driver.Url = "https://rahulshettyacademy.com/"; // Directs the browser to the given URL (Rahul Shetty Academy).


            }

        [TearDown] // Attribute indicating that the following method should be run after each test (teardown phase).

        public void TearDown() // The method used to close the browser and clean up resources after the test.
        {
            driver.Quit(); // Quits the browser and closes all associated windows, ending the WebDriver session.
        }
    }
}