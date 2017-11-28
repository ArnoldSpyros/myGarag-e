using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myGarag_e_MAINPROJECT;
namespace UnitTestProject1
{
    
    [TestClass]
    public class TestAutokinito
    {
        [TestMethod]
        public void TestDefaultConstructor()
        {
            Autokinito obj = new Autokinito();
            Assert.IsNull(obj.Type_of_fuel);
        }
    }
}
