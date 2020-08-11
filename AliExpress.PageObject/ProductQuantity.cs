namespace AliExpress.PageObject
{
    using System.Linq;
    using Interfaces;

    public class ProductQuantity
    {
        private readonly IElement context;

        public ProductQuantity(IElement context)
        {
            this.context = context;
        }

        public int AmountLeft => int.Parse(context.FindByCss("div.product-quantity-tip > span").Text.Split().First());
    }
}