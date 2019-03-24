using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ordenamiento.Pruebas
{
    [TestClass]
    public class PruebasOrdenamiento
    {
        private int[] salidaEsperada = new int[] {1, 2, 3, 4, 5};
        private Ordenamiento.Burbuja ordenar = new Ordenamiento.Burbuja();
        
        [TestMethod]
        public void PruebaOrdenado()
        {
            int[] entradas = new int[] {1, 2, 3, 4, 5};
            ordenar.Ordenar(entradas);
            CollectionAssert.AreEqual(salidaEsperada, entradas);
        }
    }
}