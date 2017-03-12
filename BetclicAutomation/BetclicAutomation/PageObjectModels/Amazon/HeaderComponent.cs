using BetclicAutomation.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace BetclicAutomation.PageObjectModels.Amazon
{
    class HeaderComponent : BasePage
    {
        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        private IWebElement _searchInput;

        [FindsBy(How = How.CssSelector, Using = "input[type = 'submit']")]
        private IWebElement _submitButton;

        [FindsBy(How = How.Id, Using = "nav-cart")]
        private IWebElement _busketLink;

        /// <summary>
        /// send keys with some text to search input
        /// </summary>
        /// <param name="text"></param>
        /// <returns>HeaderComponent</returns>
        public HeaderComponent SetTetxToInputMode(string text)
        {
            _searchInput.SendKeys(text);
            return this;
        }

        /// <summary>
        /// click on search button
        /// </summary>
        /// <returns>ResultListPage</returns>
        public ResultListPage ClickSubmitButton()
        {
            _submitButton.Click();
            return new ResultListPage();
        }

        /// <summary>
        /// search for smth
        /// </summary>
        /// <param name="itemName"></param>
        /// <returns>ResultListPage</returns>
        public ResultListPage SearchFor(string itemName)
        {
            return SetTetxToInputMode(itemName).ClickSubmitButton();
        }

        /// <summary>
        /// click on GoToBusket button
        /// </summary>
        /// <returns>BusketPage</returns>
        public BusketPage goToBusket()
        {
            _busketLink.JsClick();
            return new BusketPage();
        }
    }
}
