using System;
using System.Collections.Generic;
using System.Text;

namespace AliExpress.PageObject.Interfaces
{
    public interface IDriver
    {
        void Navigate(string url);
        void Quit();
    }
}
