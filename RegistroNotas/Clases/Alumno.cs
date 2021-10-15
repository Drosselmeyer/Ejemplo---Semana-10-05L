using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroNotas.Clases
{
    public class Alumno
    {
        //Declarar las propiedades
        public int IdAlumno { set; get; }
        public string Nombre { set; get; }
        public string Grado { set; get; }
        public string Seccion { set; get; }

        //Constructor
        public Alumno()
        {
            this.IdAlumno = 0;
            this.Nombre = "";
            this.Grado = "";
            this.Seccion = "";
        }
    }
}