
using BetclicAutomation.PageObjectModels.Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BetclicAutomation.StepDefinitions
{
    [Binding]
    class CalculatorSteps
    {
        private HomePage _resultsPage;
        [When(@"Search '(.*)'")]
        public void SearchSomeText(string searchRequest)
        {
            _resultsPage = new HomePage().SearchSomeRequest(searchRequest);
        }

        [Then(@"Verify that the calculation result is '(.*)'")]
        public void VerifyCalculationResult(string expectedResult)
        {
            Assert.AreEqual(expectedResult, _resultsPage.GetCalculator().GetInputText(), "calculation result is wrong");
        }
    }
}
