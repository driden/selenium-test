namespace AliExpress.Selenium
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using OpenQA.Selenium;
    using PageObject.Interfaces;

    public class WebDriverAdapter : IDriver
    {
        private readonly IWebDriver driver;

        public WebDriverAdapter(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(new Uri(url));
        }

        public void Quit()
        {
            driver.Quit();
        }

        public IElement FindOneByCss(string selector)
        {
            return new ElementAdapter(driver.FindElement(By.CssSelector(selector)));
        }

        public IReadOnlyCollection<IElement> FindAllByCss(string selector)
        {
            return driver.FindElements(By.CssSelector(selector))
                .Select(elem => new ElementAdapter(elem)).ToImmutableList();
        }

        public void SwitchToNewTab()
        {
            var newTabHandle = driver.WindowHandles.Last();
            driver.SwitchTo().Window(newTabHandle);
        }
    }
}
