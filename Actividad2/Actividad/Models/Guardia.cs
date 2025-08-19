using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.Models
{
    internal class Guardia
    {
        public int HoraDesde { get; private set; }
        public int HoraHasta { get; private set; }

        public int MinutoDesde { get; private set; }
        public int MinutoHasta { get; private set; }

        public int CantidadMinutos { get; private set; }


        public Policia OficialAsignado { get; private set; }

        public Guardia()
        {
        }

        public void AsignarPolicia(Policia policia, int horaDesde, int minutoDesde, int cantMinutos)
        {
            this.OficialAsignado = policia;
            this.HoraDesde = horaDesde;
            this.MinutoDesde = minutoDesde;
            this.CantidadMinutos = cantMinutos;

        }
            

    }
}
