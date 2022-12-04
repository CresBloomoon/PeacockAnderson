using DependencyInjection.WinForm.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DependencyInjectionTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var product = new ModuleA(new ProductMock());
            Assert.AreEqual("AAA%", product.GetValue());

            var product2 = new ModuleA(new ProductMock2());
            Assert.AreEqual("AAABB", product2.GetValue());
        }
    }

    internal sealed class ProductMock : IProduct
    {
        public string GetData()
        {
            return "AAA";
        }

        public void Save(string value)
        {
            throw new NotImplementedException();
        }
    }

    internal sealed class ProductMock2 : IProduct
    {
        public string GetData()
        {
            return "AAABB";
        }

        public void Save(string value)
        {
            throw new NotImplementedException();
        }
    }
}
