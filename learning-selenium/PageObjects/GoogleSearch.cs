namespace learning_selenium.PageObjects
{
    public class GoogleSearch
    {
        public void IrPara()
        {
            //Pages.PesquisaGoogle.IrPara();
        }

        public bool EstaEm()
        {
            return Browser.Title.Contains("Google");
        }

    }
}
