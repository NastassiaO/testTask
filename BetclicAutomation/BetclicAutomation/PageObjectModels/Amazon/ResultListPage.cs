using BetclicAutomation.Driver;
using OpenQA.Selenium;
using System;

namespace BetclicAutomation.PageObjectModels.Amazon
{
    class ResultListPage : BaseAmazonPage
    {
        private string resultItem = "result_{0}";

        /// <summary>
        /// get Result item from by number
        /// </summary>
        /// <param name="number">0-based</param>
        /// <returns>ResultComponent</returns>
        public ResultComponent GetResultItem(int number)
        {
            return new ResultComponent(GetItemElement(number));
        }
        private IWebElement GetItemElement(int number)
        {
            return WebDriver.GetDriver().FindElement(By.Id(String.Format(resultItem, number)));
        }

    }
}
