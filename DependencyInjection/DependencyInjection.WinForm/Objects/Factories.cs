using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.WinForm.Objects
{
    public static class Factories
    {
        public static IProduct CreateProduct()
        {
            return new ProductFake();
            //return new ProductSqlServer();
        }
    }
}
