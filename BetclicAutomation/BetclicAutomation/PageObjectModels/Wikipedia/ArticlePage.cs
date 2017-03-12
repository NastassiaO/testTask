using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace BetclicAutomation.PageObjectModels.Wikipedia
{
    class ArticlePage:BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "[title = 'Roman numerals']")]
        private IWebElement _romanNumerals;

        /// <summary>
        /// get Roman Numeral
        /// </summary>
        /// <returns>String</returns>
        public String getRomanNumeralText() {
            return _romanNumerals.Text;
        }
    }
}
