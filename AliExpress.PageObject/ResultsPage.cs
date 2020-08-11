namespace AliExpress.PageObject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    public class ResultsPage : BasePage
    {
        private IReadOnlyCollection<ResultItem> Results => Driver.FindAllByCss("ul.list-items > li.list-item").Select(x =>new ResultItem(x)).ToList();

        public ResultsPage(IDriver driver) : base(driver) { }

        public AdPage SelectAdByIndex(int adIndex)
        {
            if (Results.Count < adIndex + 1)
            {
                throw new ArgumentException($"There are {Results.Count} items in the results list.");
            }

            Results.ElementAt(adIndex).Click();
            return new AdPage(Driver);
        }
    }
}