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
}
