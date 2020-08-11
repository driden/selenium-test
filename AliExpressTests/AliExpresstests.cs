namespace AliExpressTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using AliExpress.PageObject;

    [TestClass]
    public class AliExpressTests: BaseTest
    {
        [TestMethod]
        public void ICanBuyAnIphoneFromSecondAd()
        {
            var landingPage = new LandingPage(driver);
            landingPage.Visit();
            landingPage.ClosePopUp();

            ResultsPage resultsPage = landingPage.Search.For("iPhone");
            AdPage secondAdPage = resultsPage.SelectAdByIndex(2);

            Assert.IsTrue(secondAdPage.Quantity.AmountLeft > 0, "There are not enough phones");
        }
    }
}
