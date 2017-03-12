using BetclicAutomation.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BetclicAutomation.PageObjectModels.Wikipedia
{
    class HomePage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "(//*[@id ='On_this_day...']/ancestor::tr)[2]/following-sibling::tr")]
        private IWebElement _section;

        private By _linksListBy = By.TagName("a");
        /// <summary>
        /// verify is On This Day... section displayed
        /// </summary>
        /// <returns></returns>
        public bool IsOnThisDaySectionDisplayed()
        {
            return _section.IsDisplayed();
        }

        /// <summary>
        /// click on preassigned yearsLink by number
        /// </summary>
        /// <param name="linkNumber">0-based</param>
        /// <param name="year">int - choosen number</param>
        /// <returns>ArticlePage </returns>
        public ArticlePage ClickYearLink(int linkNumber, out int year)
        {
            IWebElement yearLink = GetYearsLinksList()[linkNumber];
            int.TryParse(yearLink.GetAttribute("title"), out year);
            yearLink.Click();
            return new ArticlePage();
        }

        private List<IWebElement> GetLinksList()
        {
            return _section.FindElements(_linksListBy).ToList();
        }

        private List<IWebElement> GetYearsLinksList()
        {
            int a;
            return GetLinksList().FindAll(el => int.TryParse(el.GetAttribute("title"), out a));
        }
    }
}
