using NUnit.Framework;

namespace EasyFinanceApiTests
{
    public class Tests
    {
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