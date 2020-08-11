namespace AliExpress.PageObject
{
    using Interfaces;

    public class AdPage : BasePage
    {
        public AdPage(IDriver driver) : base(driver)
        {
            driver.SwitchToNewTab();
        }

        public ProductQuantity Quantity => new ProductQuantity(Driver.FindOneByCss("div.product-quantity"));

        public AdPage Click()
        {
            throw new System.NotImplementedException();
        }

    }
}