using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroNotas.Clases
{
    public class Notas
    {
        //Propiedades
        public int IdNotas { set; get; }
        public int IdAlumno { set; get; }
        public int IdMateria { set; get; }
        public double Nota { set; get; }

        //Constructor
        public Notas()
        {
            this.IdNotas = 0;
            this.IdAlumno = 0;
            this.IdMateria = 0;
            this.Nota = 0;
        }
    }
}