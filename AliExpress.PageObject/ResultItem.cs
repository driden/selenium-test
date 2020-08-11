namespace AliExpress.PageObject
{
    using Interfaces;

    public class ResultItem
    {
        private readonly IElement context;

        public ResultItem(IElement context)
        {
            this.context = context;
        }

        public void Click()
        {
            context.FindByCss("a.item-title").Click();
        }
    }
}
