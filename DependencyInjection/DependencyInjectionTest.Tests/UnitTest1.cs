using DependencyInjection.WinForm.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
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

        [TestMethod]
        public void Moqを使ったテスト()
        {
            var productMock = new Mock<IProduct>();
            var m = new ModuleA(productMock.Object);

            productMock.Setup(x => x.GetData()).Returns("AAA");
            Assert.AreEqual("AAA%", m.GetValue());

            productMock.Setup(x => x.GetData()).Returns("BBBCC");
            Assert.AreEqual("BBBCC", m.GetValue());


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
