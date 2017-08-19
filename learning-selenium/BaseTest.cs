using NUnit.Framework;

namespace learning_selenium
{
    [TestFixture]
    public class BaseTest
    {
        [OneTimeSetUp]
        public static void Initialize()
        {
            Browser.Initialize();
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            Browser.Close();
        }
        
        public static void TearDown()
        {

            //TO DO: Verificar se possui login efetuado, se possuir deslogar.
        }
    }
}
