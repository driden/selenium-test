namespace AliExpress.PageObject
{
    using Interfaces;

    public abstract class BasePage
    {
        protected IDriver Driver { get; private set; }

        protected BasePage(IDriver driver)
        {
             this.Driver = driver;
        }
    }
}
