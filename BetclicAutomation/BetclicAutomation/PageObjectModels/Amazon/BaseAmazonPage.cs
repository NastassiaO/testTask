using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetclicAutomation.PageObjectModels.Amazon
{
    class BaseAmazonPage: BasePage
    {
        /// <summary>
        /// method for getting Header component
        /// </summary>
        /// <returns> HeaderComponent </returns>
        public HeaderComponent GetHeader()
        {
            return new HeaderComponent();        
        }
    }
}
