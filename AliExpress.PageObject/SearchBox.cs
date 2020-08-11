namespace AliExpress.PageObject
{
    using Interfaces;

    public class SearchBox : BasePage
    {
        private IElement searchBox => Driver.FindOneByCss("input#search-key");
        private IElement submitButton => Driver.FindOneByCss("input[type='submit']");
        public SearchBox(IDriver driver) : base(driver) { }

        public ResultsPage For(string productName)
        {
            searchBox.Type(productName);
            submitButton.Click();

            return new ResultsPage(Driver);
        }
    }
}
