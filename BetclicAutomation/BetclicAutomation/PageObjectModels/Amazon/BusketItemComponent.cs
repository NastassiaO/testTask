using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetclicAutomation.PageObjectModels.Amazon
{
    class BusketItemComponent
    {
        private IWebElement _container { get; set; }
        private By title = By.ClassName("sc-product-title");

        public BusketItemComponent(IWebElement container)
        {
            _container = container;
        }
        /// <summary>
        /// get title of item in Busket
        /// </summary>
        /// <returns></returns>
        public string GetTitleText()
        {
            return GetTitleElement().Text;
        }

        private IWebElement GetTitleElement()
        {
            return _container.FindElement(title);
        }
    }
}
