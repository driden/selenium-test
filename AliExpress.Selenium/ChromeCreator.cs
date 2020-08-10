namespace AliExpress.Selenium
{
    using OpenQA.Selenium.Chrome;
    using PageObject.Interfaces;

    public class ChromeCreator : BrowserCreator
    {
        public override IDriver CreateChromeDriver()
        {
            var chromeService = ChromeDriverService.CreateDefaultService(CallingAssemblyDirectory);
            var driver = new ChromeDriver(chromeService);
            driver.Manage().Timeouts().PageLoad = PageLoad;
            driver.Manage().Timeouts().ImplicitWait = ImplicitWait;
            return new WebDriverAdapter(driver);
        }
    }
}
