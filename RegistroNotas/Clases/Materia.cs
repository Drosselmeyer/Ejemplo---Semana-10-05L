using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroNotas.Clases
{
    public class Materia
    {
        //Propiedades
        public int IdMateria { set; get; }
        public string Nombre { set; get; }
        public string Docente { set; get; }

        //Constructor
        public Materia()
        {
            this.IdMateria = 0;
            this.Nombre = "";
            this.Docente= "";
        }
    }
}