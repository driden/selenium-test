using System;

namespace AliExpress.Selenium
{
    using PageObject.Interfaces;

    public class ChromeCreator: BrowserCreator
    {
        public override IDriver CreateChromeDriver()
        {
            throw new NotImplementedException();
        }
    }
}
