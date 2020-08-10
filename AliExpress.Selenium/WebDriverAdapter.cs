namespace AliExpress.Selenium
{
    using System;
    using OpenQA.Selenium;
    using PageObject.Interfaces;

    public class WebDriverAdapter: IDriver
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
    }
}
