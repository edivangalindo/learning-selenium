using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace learning_selenium.PageObjects
{
    public class TopNavigationPage
    {
        [FindsBy(How = How.LinkText, Using = "Gmail")]
        private IWebElement GmailLink;

        public void Gmail()
        {
            GmailLink.Click();
        }
    }
}
