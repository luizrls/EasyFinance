using NUnit.Framework;

namespace EasyFinanceApiTests
{
    class UsuariosTeste
    {
        //private readonly TestServer _server;
        //private readonly HttpClient _client;

        private string valor;

        [SetUp]
        public void SetUp()
        {
            valor = "aaaaa";
        }

        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = valor;

            Assert.AreEqual(result, "aaaaab");
        }
    }
}
