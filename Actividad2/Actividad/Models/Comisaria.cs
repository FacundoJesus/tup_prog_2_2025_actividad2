using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.Models
{
    internal class Comisaria
    {
        public int CantidadIncidentes { get; private set; }

        //
        private List<Incidente> incidentes = new List<Incidente>();
        private Guardia[] guardias = new Guardia[2];
        private Policia[] agentes = new Policia[2];
        //

        public bool AsignarPolicia(Policia policia)
        {
            bool asignado = true;
            for (int i = 0; i < agentes.Length; i++)
            {
                if (agentes[i] == null)
                {
                    agentes[i] = policia;
                    return asignado;
                }
            }
            return !asignado;
        }

        public Policia VerAgente(int numeroPlaca)
        {
            Policia agente = null;
            int i = 0;
            int pos = -1;
            while(pos ==-1 && i < agentes.Length) {
                if (agentes[i].NumeroPlaca == numeroPlaca)
                {
                    pos = i;
                }
                i++;
            }
            if (pos != -1) {
                agente = agentes[i];
            }
            return agente;
        }

        public void RegistrarIncidente(Policia agente, Persona sujeto, string motivo, int hora, int minutos, int tipoIncidente)
        {
            Incidente nuevoIncidente = new Incidente(agente, sujeto, tipoIncidente, hora, minutos, motivo);

            incidentes.Add(nuevoIncidente);
            CantidadIncidentes++;

        } 

        public void AsignarGuardia(int numero, int h1, int m1, int tiempoMinutos, Policia agente)
        {
            if (numero > 0 && numero < agentes.Length)
            {
                if (guardias[numero] == null)
                {
                    guardias[numero] = new Guardia();
                }
            }
            guardias[numero].AsignarPolicia(agente, h1, m1, tiempoMinutos);
        }

        public Incidente VerIncidente(int idx)
        {
            Incidente incidente = null;
            if (idx >= 0 && idx < incidentes.Count)
            {
                incidente = incidentes[idx];
            }
            return incidente;
        }
    }
}
