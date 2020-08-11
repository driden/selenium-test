namespace AliExpress.Selenium
{
    using System;
    using PageObject;
    using PageObject.Interfaces;

    public class PopUp : BasePage
    {
        public PopUp(IDriver driver) : base(driver) { }

        public void Close()
        {
            try
            {
                if (Driver.IsVisible("a.close-layer", 2))
                {
                    Driver.FindOneByCss("a.close-layer").Click();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Timed out waiting for pop up");
            }
        }

    }
}
