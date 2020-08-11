namespace AliExpress.Selenium
{
    using OpenQA.Selenium.Chrome;
    using PageObject.Interfaces;

    public class ChromeCreator : BrowserCreator
    {
        public override IDriver CreateChromeDriver()
        {
            var chromeService = ChromeDriverService.CreateDefaultService(CallingAssemblyDirectory);
            var opts = new ChromeOptions();
            opts.AddArgument("disable-notifications");

            var driver = new ChromeDriver(chromeService,opts);
            driver.Manage().Timeouts().PageLoad = PageLoad;
            driver.Manage().Timeouts().ImplicitWait = ImplicitWait;
            driver.Manage().Window.Maximize();
            return new WebDriverAdapter(driver);
        }
    }
}
