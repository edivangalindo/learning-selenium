using learning_selenium;
using learning_selenium.PageObjects;
using NUnit.Framework;

namespace learning_selenium_tests
{
    [TestFixture]
    public class SmokeTests : BaseTest
    {
        [Test]
        public void DeveAbrirPesquisaGoogle()
        {
            Assert.IsTrue(Pages.PesquisaGoogle.EstaEm());
        }

        [Test]
        public void DeveAbrirTelaLoginGmail()
        {
            Pages.Gmail.IrPara();
            Assert.IsTrue(Pages.Gmail.EstaEm());
        }

    }
}
