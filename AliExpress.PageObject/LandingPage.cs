namespace AliExpress.PageObject
{
    using System;
    using Interfaces;

    public class LandingPage : BasePage
    {

        public SearchBox Search => new SearchBox(Driver);

        public LandingPage(IDriver driver) : base(driver) { }

        public void Visit()
        {
            Driver.Navigate("https://www.aliexpress.com/");
        }

    }
}
