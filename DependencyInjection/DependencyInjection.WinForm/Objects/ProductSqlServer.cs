using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.WinForm.Objects
{
    public sealed class ProductSqlServer : IProduct
    {
        public string GetData()
        {
            ///データベースOpen
            ///SQLの実行
            return "AAA sql server";
        }

        public void Save(string value)
        {
            //save処理
        }
    }
}
