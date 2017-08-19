using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace learning_selenium
{
    public static class Browser
    {
        private static string BaseURL = "www.google.com";

        private static IWebDriver webDriver = new ChromeDriver(@"C:\Users\ediva\source\repos\learning-selenium\learning-selenium\");
        
        public static void Initialize()
        {
            IrPara("");
        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static void IrPara(string url)
        {
            webDriver.Navigate().IrParaUrl(BaseURL + url);
        }

        public static void Close()
        {
            webDriver.Close();
        }
    }
}
