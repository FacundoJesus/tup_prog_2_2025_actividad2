using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.Models
{
    internal class Guardia
    {
        public int HoraDesde { get; set; }
        public int MinutoDesde { get; set; }

        public int HoraHasta { 
            get
            {
                int min = HoraDesde * 60 + MinutoDesde + CantidadMinutos;
                return min % 60;
            }
        }

        public int MinutoHasta { 
            get {
                int min = HoraDesde * 60 + MinutoDesde + CantidadMinutos;
                return min / 60;
            }
        }


        public int CantidadMinutos { get; set; }

        public Guardia(){}

        public Policia OficialAsignado { get; set; }
        public void AsignarPolicia(Policia policia, int horaDesde, int minutoDesde, int cantMinutos)
        {
            this.OficialAsignado = policia;
            this.HoraDesde = horaDesde;
            this.MinutoDesde = minutoDesde;
            this.CantidadMinutos = cantMinutos;
        }
    }
}
