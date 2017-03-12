using BetclicAutomation.Driver;
using OpenQA.Selenium;
using System;

namespace BetclicAutomation.PageObjectModels.Amazon
{
    class ResultComponent
    {
        private IWebElement _container;
        private By _titleBy = By.TagName("h2");

        /// <summary>
        /// constuctor
        /// </summary>
        /// <param name="container"></param>
        public ResultComponent(IWebElement container)
        {
            this._container = container;
        }
        /// <summary>
        /// get title of the result item
        /// </summary>
        /// <returns>String</returns>
        public string GetTextOfTitle()
        {
            return GetTitleElement().Text;
        }
        /// <summary>
        /// click on the title of the result title
        /// </summary>
        /// <returns>ItemPage</returns>
        public ItemPage ClickTitle()
        {
            GetTitleElement().JsClick();
            return new ItemPage();
        }

        private IWebElement GetTitleElement()
        {
            return _container.FindElement(_titleBy);
        }

    }
}
