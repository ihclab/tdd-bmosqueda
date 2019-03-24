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

        [TestMethod]
        public void PruebaUnoDesordenado()
        {
            int[] entradas = new int[] {1, 3, 2, 4, 5};
            ordenar.Ordenar(entradas);
            CollectionAssert.AreEqual(salidaEsperada, entradas);
        }

        [TestMethod]
        public void PruebaPrimero()
        {
            int[] entradas = new int[] {2, 3, 4, 5, 1};
            ordenar.Ordenar(entradas);
            CollectionAssert.AreEqual(salidaEsperada, entradas);
        }

        [TestMethod]
        public void PruebaFinal()
        {
            int[] entradas = new int[] {5, 1, 2, 3, 4};
            ordenar.Ordenar(entradas);
            CollectionAssert.AreEqual(salidaEsperada, entradas);
        }

        [TestMethod]
        public void PruebaInvertido()
        {
            int[] entradas = new int[] {5, 4, 3, 2, 1};
            ordenar.Ordenar(entradas);
            CollectionAssert.AreEqual(salidaEsperada, entradas);
        }
    }
}