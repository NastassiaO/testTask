using BetclicAutomation.PageObjectModels.Amazon;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BetclicAutomation.StepDefinitions
{
    [Binding]
    class AmazonSteps
    {
        private ResultListPage _resultPage;
        private string _title;
        private ItemPage _itemPage;
        private BusketPage _busketPage;

        [Then(@"Search for (.*)")]
        public void SearchFor(string searchItem)
        {
            _resultPage = new BaseAmazonPage().GetHeader().SearchFor(searchItem);
        }
        [When(@"Click on (.*) result")]
        public void ClickOnResult(int number)
        {
            ResultComponent result = _resultPage.GetResultItem(number - 1);
            _title = result.GetTextOfTitle();
            _itemPage = result.ClickTitle();
        }

        [Then(@"Add item to the basket")]
        public void AddItemToTheBusket()
        {
            BaseAmazonPage basePage = _itemPage.ClickOnAddToBusketButton();
            _busketPage = basePage.GetHeader().goToBusket();
        }

        [Then(@"Verify that the chosen item is present in the basket")]
        public void VerifyItemsInBusket()
        {
            Assert.IsTrue(_busketPage.IsItemPresent(_title), "item with title " + _title + " is not present in busket");
        }
    }
}
