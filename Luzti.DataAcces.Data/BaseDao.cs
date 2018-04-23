using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luzti.DataAcces.Data
{
    public abstract class BaseDao<T> : IDao<T>
    {
        public abstract int Add(T t);
        public abstract System.Data.SqlClient.SqlConnection.GetConnection();
        
    }
}
