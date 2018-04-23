using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luzti.DataAcces.Data
{
    public interface IDao<T>
    {
        int Add(T t);
    }
}
