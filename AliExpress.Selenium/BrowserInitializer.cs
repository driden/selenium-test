using AliExpress.PageObject.Interfaces;

namespace AliExpress.Selenium
{
    public class BrowserInitializer
    {
        // this could be made so the strategy is picked from reading from a config file
        private readonly BrowserCreator creator = new ChromeCreator();

        public IDriver New()
        {
            return creator.CreateChromeDriver();
        }
    }
}
