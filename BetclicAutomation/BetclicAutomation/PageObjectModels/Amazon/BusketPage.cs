using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BetclicAutomation.PageObjectModels.Amazon
{
    class BusketPage : BaseAmazonPage
    {
        [FindsBy(How = How.ClassName, Using = "sc-list-item-content")]
        private IList<IWebElement> _itemsList;

        /// <summary>
        /// verify is Item present in Busket by title
        /// </summary>
        /// <param name="titleOfItem"></param>
        /// <returns> true if item with current title exists and if size of list of items doesn't equal 0</returns>
        public bool IsItemPresent(string titleOfItem)
        {
            return _itemsList.Any(el => new BusketItemComponent(el).GetTitleText().Equals(titleOfItem));
        }
    }
}
