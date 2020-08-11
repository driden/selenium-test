namespace AliExpress.PageObject.Interfaces
{
    public interface IElement
    {
        void Type(string text);

        void Click();

        string Text { get; }

        IElement FindByCss(string selector);
    }
}
