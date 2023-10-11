using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoneyExtension.Tests
{
    [TestClass]
    public class MoneyExtensionTests
    {
        [TestMethod]
        public void DeveConverterDecimalParaIntenrio()
        {
            decimal valor = 279.98M;
            var cents = valor.ToCents();

            Assert.AreEqual(27898, cents);
        }
    }
}
