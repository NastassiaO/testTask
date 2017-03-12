using BetclicAutomation.Driver;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetclicAutomation.PageObjectModels
{
    class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(WebDriver.GetDriver(), this);
        }
    }
}
