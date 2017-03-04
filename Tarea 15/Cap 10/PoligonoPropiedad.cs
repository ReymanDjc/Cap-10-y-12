using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea_15.Cap_10
{
    class PoligonoPropiedad
    {
        public Double Perimet { get; set; }
        public Double Apot { get; set; }
        public PoligonoPropiedad()
        {

        }
        public PoligonoPropiedad(Double Perimet, Double Apot)

        {
            this.Perimet = Perimet;
            this.Apot = Apot;
        }

        public double Area
        {
            get { return Perimet * Apot / 2; }
            set { Perimet = 15; Apot = 3.25; }
        }
    }
}
