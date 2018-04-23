using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luzti.Business.Rules
{
    public class AlumnoBr
    {
        public int Add(Alumno alumno)
        {
            int id;
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    alumno.IdAlumno = alumnoDao.Add(alumno);
                    alumno.Direccion.IdAlumno = alumno.IdAlumno;
                    id = direccionDao.Add(alumno.Direccion);
                    transactionScope.Complete();
                }
                catch(Exception)
                {
                    throw;
                }
            }
            return id;
        }
    }
}
