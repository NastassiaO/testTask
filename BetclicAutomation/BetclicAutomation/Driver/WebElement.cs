using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetclicAutomation.Driver
{
    public static class WebElement
    {
        public static void JsClick(this IWebElement element)
        {
            var executor = (IJavaScriptExecutor)WebDriver.GetDriver();
            executor.ExecuteScript("arguments[0].click();", element);
        }


        public static bool IsDisplayed(this IWebElement element)
        {
            try
            {
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }       
    }
}
