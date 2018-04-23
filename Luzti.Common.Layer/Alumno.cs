using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luzti.Common.Layer
{
    public class Alumno
    {
        private Direccion direccion;

        public Direccion Direccion
        {
            get { return direccion;}
        }
        public Alumno(Direccion direccion)
        {
            this.direccion = direccion;
        }
        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }

    }
}
