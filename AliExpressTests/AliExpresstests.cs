using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AliExpressTests
{
    using System.ComponentModel;
    using AliExpress.PageObject;
    using AliExpress.PageObject.Interfaces;
    using AliExpress.Selenium;

    [TestClass]
    public class AliExpressTests
    {
        [TestMethod]
        public void ICanBuyAnIphoneFromSecondAd()
        {
            var browser = new BrowserInitializer();
            var driver = browser.New();
            var landingPage = new LandingPage(driver);

            driver.Quit();
            ResultsPage resultsPage = landingPage.Search.For("iPhone");
            AdPage secondAdPage = resultsPage.Ads(2).Click();

            Assert.IsTrue(secondAdPage.Quantity.AmountLeft > 0, "There are not enough phones");
        }
    }
}
