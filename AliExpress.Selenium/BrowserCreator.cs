namespace AliExpress.Selenium
{
    using PageObject.Interfaces;

    public abstract class BrowserCreator
    {
        public abstract IDriver CreateChromeDriver();
    }
}
