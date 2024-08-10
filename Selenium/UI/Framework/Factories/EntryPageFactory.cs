using OpenQA.Selenium;
using POMTestProject.Selenium.UI.Framework.PageObjects;

namespace Selenium.UI.Framework.Factories
{
    public static class EntryPageFactory
    {
        /// <summary>
        /// Creates an entry page.
        /// </summary>
        public static TPage Create<TPage>(IWebDriver driver) where TPage : PomBase, new()
        {
            var page = new TPage()
            {
                Driver = driver
            };

            return page;
        }
    }
}
