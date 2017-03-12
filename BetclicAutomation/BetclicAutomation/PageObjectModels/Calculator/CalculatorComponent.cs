using BetclicAutomation.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace BetclicAutomation.PageObjectModels.Calculator
{
    class CalculatorComponent : BasePage
    {
        [FindsBy(How = How.ClassName, Using = "cwmd")]
        private IWebElement _component;

        [FindsBy(How = How.Id, Using = "cwos")]
        private IWebElement _input;

        /// <summary>
        /// wait for calcilator component is present
        /// </summary>
        public void WaitForComponent()
        {
            WebDriverWait wait = new WebDriverWait(WebDriver.GetDriver(), new TimeSpan(0, 0, 5));
            wait.Until(driver => _component.IsDisplayed());
        }

        /// <summary>
        /// get text of input is calculator component
        /// </summary>
        /// <returns>String</returns>
        public string GetInputText()
        {
            return _input.Text;
        }

    }
}
