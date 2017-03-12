using BetclicAutomation.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BetclicAutomation.StepDefinitions
{
    [Binding]
    class NavigationSteps
    {
        Dictionary<string, string> _dict = new Dictionary<string, string>()
        {
            {"google", "https://www.google.com//ncr"},
            {"amazon", "http://www.amazon.co.uk"},
            {"wikipedia", " https://en.wikipedia.org/wiki/Main_Page" }
        };


        [Given(@"Open the (.*) site")]
        public void OpenSite(string siteName)
        {
            WebDriver.GetDriver().Url = _dict[siteName];
        }
    }
}
