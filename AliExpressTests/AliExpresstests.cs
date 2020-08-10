using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AliExpressTests
{
    using AliExpress.PageObject;

    [TestClass]
    public class AliExpressTests
    {
        [TestMethod]
        public void ICanBuyAnIphoneFromSecondAd()
        {
            var landingPage = new LandingPage();
            ResultsPage resultsPage = landingPage.Search.For("iPhone");
            AdPage secondAdPage = resultsPage.Ads(2).Click();

            Assert.IsTrue(secondAdPage.Quantity.AmountLeft > 0, "There are not enough phones");
        }
    }
}
