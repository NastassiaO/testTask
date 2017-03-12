using BetclicAutomation.Driver;
using TechTalk.SpecFlow;

namespace BetclicAutomation.Helper
{
    [Binding]
    public class SpecFlowBeforeAfter
    {
        [BeforeScenario]
        public void Setup()
        {
            WebDriver.CreateDriver();
        }

        [AfterScenario]
        public void TearDown()
        {
            WebDriver.QuitDriver();
        }
    }
}
