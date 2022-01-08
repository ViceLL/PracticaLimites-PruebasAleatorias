using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectLimites_PruebasAleatorias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Identificacion.Limites_EntradaAleatoria("Vicente", "Vargas", 20);

        }
    }
}