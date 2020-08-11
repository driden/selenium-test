namespace AliExpressTests
{
    using AliExpress.PageObject.Interfaces;
    using AliExpress.Selenium;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public abstract class BaseTest
    {
        protected IDriver driver;

        [TestInitialize]
        public void SetUp()
        {
            var browser = new BrowserInitializer();
            driver = browser.New();
        }

        [TestCleanup]
        public void Teardown()
        {
            driver.Quit();
            driver = null;
        }
    }
}
