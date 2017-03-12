using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BetclicAutomation.PageObjectModels.Calculator
{
    class HomePage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "input[id= 'lst-ib']")]
        private IWebElement _searchInput;

        /// <summary>
        /// enter text to the search input
        /// </summary>
        /// <param name="text"></param>
        /// <returns>HomePage</returns>
        public HomePage EnterSomeText(string text)
        {
            _searchInput.SendKeys(text);
            return this;
        }

        /// <summary>
        /// submit search
        /// </summary>
        /// <returns>HomePage</returns>
        public HomePage Submit()
        {
            _searchInput.SendKeys(Keys.Enter);
            return this;
        }

        /// <summary>
        /// search some text
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public HomePage SearchSomeRequest(string request)
        {
            return EnterSomeText(request).Submit();
        }

        /// <summary>
        /// get calculator component
        /// </summary>
        /// <returns>CalculatorComponent</returns>
        public CalculatorComponent GetCalculator()
        {
            new CalculatorComponent().WaitForComponent();
            return new CalculatorComponent();
        }
    }
}
