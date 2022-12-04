using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.WinForm.Objects
{
    public interface IProduct
    {
        string GetData();
        void Save(string value);
    }
}
