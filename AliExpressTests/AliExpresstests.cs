using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AliExpressTests
{
    [TestClass]
    public class AliExpressTests
    {
        [TestMethod]
        public void ICanBuyAnIphoneFromSecondAd()
        {
            var landingPage = new LandingPage();
            var resultsPage = landingPage.Search.For("iPhone");
            var secondAdPage = resultsPage.Results(2).Click();

            Assert.IsTrue(secondAdPage.Quantity.AmountLeft > 0, "There are not enough phones");
        }
    }
}
