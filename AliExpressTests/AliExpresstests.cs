namespace AliExpressTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using AliExpress.PageObject;
    using AliExpress.Selenium;

    [TestClass]
    public class AliExpressTests: BaseTest
    {
        [TestMethod]
        public void ICanBuyAnIphoneFromSecondAd()
        {
            var landingPage = new LandingPage(driver);
            landingPage.Visit();
            var popUp = new PopUp(driver);
            popUp.Close();

            ResultsPage resultsPage = landingPage.Search.For("iPhone");
            popUp.Close();

            AdPage secondAdPage = resultsPage.SelectAdByIndex(2);

            Assert.IsTrue(secondAdPage.Quantity.AmountLeft > 0, "There are not enough phones");
        }
    }
}
