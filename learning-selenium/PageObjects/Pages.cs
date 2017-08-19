using OpenQA.Selenium.Support.PageObjects;

namespace learning_selenium.PageObjects
{
    public static class Pages
    {
        private static T ObterPagina<T>() where T : new()
        {
            var Page = new T();
            PageFactory.InitElements(Browser.Driver, Page);
            return Page;
        }

        public static TopNavigationPage TopNavigation
        {
            get { return ObterPagina<TopNavigationPage>(); }
        }

        public static GoogleSearch PesquisaGoogle
        {
            get { return ObterPagina<GoogleSearch>(); }
        }

        public static Gmail Gmail
        {
            get { return ObterPagina<Gmail>(); }
        }


    }
}
