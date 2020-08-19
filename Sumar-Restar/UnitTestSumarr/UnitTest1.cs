using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sumar.Controllers;

namespace UnitTestSumarr
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd1()
        {
            //arrange 
            SumaController sumaController = new SumaController();
            int a = 5;
            int b = 8;
            int esperado = 13;
            //act
            int resultado = sumaController.Add(a,b);

            //assert
            Assert.AreEqual(esperado, resultado);

        }
    }
}
