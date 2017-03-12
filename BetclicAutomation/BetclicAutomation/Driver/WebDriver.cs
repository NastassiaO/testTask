using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace BetclicAutomation.Driver
{
    public class WebDriver
    {
        private static IWebDriver driver;

        public static void CreateDriver()
        {
            try
            {
                driver = new FirefoxDriver();
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
                driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(30));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                throw new SystemException("WebDriver has not been initialised!");
            }
            return driver;
        }

        public static void QuitDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }

    }
}
