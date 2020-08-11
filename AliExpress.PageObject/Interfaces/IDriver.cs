namespace AliExpress.PageObject.Interfaces
{
    using System.Collections.Generic;

    public interface IDriver
    {
        void Navigate(string url);

        void Quit();

        IElement FindOneByCss(string selector);

        IReadOnlyCollection<IElement> FindAllByCss(string selector);

        void SwitchToNewTab();
    }
}
