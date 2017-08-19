using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace learning_selenium.PageObjects
{
    public class Gmail
    {
        public void IrPara()
        {
            Pages.TopNavigation.Gmail();
        }

        public bool EstaEm()
        {
            return Browser.Title.Contains("Gmail");
        }
    }
}
