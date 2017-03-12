using BetclicAutomation.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace BetclicAutomation.PageObjectModels.Amazon
{
    class ItemPage : BaseAmazonPage
    {
        [FindsBy(How = How.Id, Using = "add-to-cart-button")]
        private IWebElement _addToBusketButton;

        /// <summary>
        /// add item to the busket
        /// </summary>
        /// <returns>BaseAmazonPage</returns>
        public BaseAmazonPage ClickOnAddToBusketButton()
        {
            _addToBusketButton.JsClick();
            WebDriverWait wait = new WebDriverWait(WebDriver.GetDriver(), new TimeSpan(0, 0, 5));
            wait.Until(dr => !_addToBusketButton.IsDisplayed());
            return new BaseAmazonPage();
        }

    }
}
