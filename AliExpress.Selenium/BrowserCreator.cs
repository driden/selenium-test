namespace AliExpress.Selenium
{
    using System;
    using System.IO;
    using System.Reflection;
    using PageObject.Interfaces;

    public abstract class BrowserCreator
    {
        protected TimeSpan PageLoad => TimeSpan.FromSeconds(5);
        protected TimeSpan ImplicitWait = TimeSpan.FromSeconds(1);

        protected string CallingAssemblyDirectory
        {
            get { return new FileInfo(Assembly.GetExecutingAssembly().Location).DirectoryName; }
        }

        public abstract IDriver CreateChromeDriver();
    }
}
