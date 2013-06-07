using DAO.House;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para ProductoRepositoryTest y se pretende que
    ///contenga todas las pruebas unitarias ProductoRepositoryTest.
    ///</summary>
    [TestClass()]
    public class ProductoRepositoryTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de la prueba que proporciona
        ///la información y funcionalidad para la ejecución de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        // 
        //Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas:
        //
        //Use ClassInitialize para ejecutar código antes de ejecutar la primera prueba en la clase 
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup para ejecutar código después de haber ejecutado todas las pruebas en una clase
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize para ejecutar código antes de ejecutar cada prueba
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup para ejecutar código después de que se hayan ejecutado todas las pruebas
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Una prueba de GetAllFromProducto
        ///</summary>
        [TestMethod()]
        public void GetAllFromProductoTest()
        {
            ProductoRepository target = new ProductoRepository(); // TODO: Inicializar en un valor adecuado
            //List<Producto> expected = null; // TODO: Inicializar en un valor adecuado
            List<ProductoDTO> actual;
            actual = target.GetAllFromProducto();
            Assert.IsTrue(actual.Count > 0);
            //Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }
    }
}
