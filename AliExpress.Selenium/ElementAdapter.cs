namespace AliExpress.Selenium
{
    using OpenQA.Selenium;
    using PageObject.Interfaces;

    public class ElementAdapter : IElement
    {
        private readonly IWebElement element;

        public ElementAdapter(IWebElement element)
        {
            this.element = element;
        }

        public void Type(string text) => element.SendKeys(text);

        public void Click() => element.Click();

        public string Text => element.Text;

        public IElement FindByCss(string selector)
        {
            return new ElementAdapter(element.FindElement(By.CssSelector(selector)));
        }
    }
}
