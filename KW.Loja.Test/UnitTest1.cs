using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KW.Loja.Test
{
    [TestClass]
    public class UnitTesKesWin
    {
        [TestMethod]

        public void TestMethod1()
        {

            // Operador Take

            int[] numeros = { 5, 4, 1, 3, 9, 12, 8, 7 };

            var resultado = from num in numeros.Take(5) select num;
            int[] teste = { 5, 4, 1, 3, 9 };

            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }


        [TestMethod]

        public void Skip()
        {
            //o operador Skip ignora os primeiros objetos de uma coleção.

            int[] numeros = { 5, 4, 1, 3, 9, 12, 8, 7 };

            var resultado = from num in numeros.Take(5).Skip(2) select num;

            int[] teste = { 1, 3, 9 };

            CollectionAssert.AreEqual(resultado.ToArray(), teste);


        }


    }
}
