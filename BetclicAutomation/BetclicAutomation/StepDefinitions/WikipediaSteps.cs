using BetclicAutomation.Helper;
using BetclicAutomation.PageObjectModels.Wikipedia;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BetclicAutomation.StepDefinitions
{
    [Binding]
    class WikipediaSteps
    {
        private HomePage _homePage;
        private ArticlePage _articlePage;
        private int _year;

        [Then(@"Verify that the '(.*)' section exists")]
        public void VerifySectionIsExist(string section)
        {
            _homePage = new HomePage();
            Assert.True(_homePage.IsOnThisDaySectionDisplayed(), "section: " + section + " is not displayed");
        }

        [When(@"Select and click the (.*) entry where the year does not have a ‘BC’ suffix")]
        public void SelectAndClickYear(int number)
        {
            _articlePage = _homePage.ClickYearLink(number - 1, out _year);
        }

        [Then(@"Validate that the Roman Numerals match with expected")]
        public void VerifyRomanNumerals()
        {
            Assert.AreEqual(RomanNumberGenerator.ToRoman(_year), _articlePage.getRomanNumeralText());
        }
    }
}
