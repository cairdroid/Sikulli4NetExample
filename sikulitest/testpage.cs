using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace sikulitest
{
    static class Testpage
    {
        public static void MoveToSomePlace(this IWebDriver _driver, By locator)
        {
            new Actions(_driver).MoveToElement(_driver.FindElement(locator))
                .Build()
                .Perform();
        }

    }
}
