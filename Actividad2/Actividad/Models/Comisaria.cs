using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.Models
{
    internal class Comisaria
    {
        public int CantidadIncidentes { 
            get
            {
                return listaIncidentes.Count;
            }
        }

        //Lista de Incidentes
        private List<Incidente> listaIncidentes = new List<Incidente>();
        //Array de Guardias
        private Guardia[] guardias = new Guardia[2];
        //Array de Policias
        private Policia[] agentes = new Policia[2];
        
        public bool AsignarPolicia(Policia policia)
        {
            bool esAsignado = false;
            int i = 0;
            if(agentes.Length < 2)
            {
                agentes[i] = policia;
                esAsignado = true;
                i++;
            }  
            return esAsignado;
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
            Incidente nuevoIncidente = new Incidente(agente, sujeto);

            nuevoIncidente.Hora = hora;
            nuevoIncidente.Minuto = minutos;
            nuevoIncidente.Motivo = motivo;
            nuevoIncidente.TipoIncidente = tipoIncidente;

            listaIncidentes.Add(nuevoIncidente);

        } 

        public void AsignarGuardia(int nroGuardia, int h1, int m1, int tiempoMinutos, Policia agente)
        {
            if ( nroGuardia < 2)
            {
                Guardia guardia = new Guardia();
                guardia.HoraDesde = h1;
                guardia.MinutoDesde = m1;
                guardia.CantidadMinutos = tiempoMinutos;

                guardia.AsignarPolicia(agente,h1,m1,tiempoMinutos);
            }
        }

        public Incidente VerIncidente(int idx)
        {
            Incidente incidente = null;
            if (idx >= 0 && idx < listaIncidentes.Count)
            {
                incidente = listaIncidentes[idx] as Incidente;
            }
            return incidente;
        }
    }
}
