namespace AliExpress.PageObject
{
    using Interfaces;

    public class LandingPage: BasePage
    {

        public SearchBox Search { get; set; }

        public LandingPage(IDriver driver): base(driver) { }

        public void Visit()
        {
            Driver.Navigate("https://www.aliexpress.com/");
        }
    }
}
