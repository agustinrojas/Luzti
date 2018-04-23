using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luzti.DataAcces.Data
{
    public class AlumnoDao:BaseDao<Alumno>
    {
        public override int Add(Alumno t)
        {
            int id;
            try
            {
                using (SqlConnection cn = GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO ALUMNO (" + "Nombre, Apellidos, Dni) values" + "(@Nombre, @Apellidos, @Dni); SET @ID=SCOPE_IDENTITY()", cn))
                    {
                        cmd.Parameters.Add("@Nombre", SqlDbType.Varchar);
                        cmd.Parameters["@Nombre"].Value = alumno.Nombre;
                        cmd.Parameters.Add("@Apellidos", SqlDbType.Varchar);
                        cmd.Parameters["@Apellidos"].Value = alumno.Apellidos;
                        cmd.Parameters.Add("@Dni", SqlDbType.Varchar);
                        cmd.Parameters["@Dni"].Value = alumno.Dni;

                        SqlParameters iDParameter = new SqlParameters("@ID", SqlDbType.Int);
                        iDParameter.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(iDParameter);
                        cmd.ExecuteNonQuery();
                        Notify("Se ha introducido el alumno: " + alumno.Nombre + " " + alumno.Apellidos + " con DNI " + alumno.Dni + " en la tabla Alumno");
                        id = Convert.ToInt32(iDParameter.Value);

                    }
                }
            }
        }


    }
}
