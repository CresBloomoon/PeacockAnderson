using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.WinForm.Objects
{
    public sealed class ProductFake : IProduct
    {
        public string GetData()
        {
            return "Fake";
        }

        public void Save(string value)
        {
            //save処理
        }
    }
}
