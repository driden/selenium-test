using System;

namespace AliExpress.PageObject
{
    public class ResultsPage
    {
        public AdPage Ads(int adIndex)
        {
            return new AdPage();
        }
    }
}