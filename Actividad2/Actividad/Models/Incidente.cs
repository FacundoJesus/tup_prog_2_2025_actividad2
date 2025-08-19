using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.Models
{
    internal class Incidente
    {
        public string Motivo;

        public int Hora;

        public int Minuto;

        public int TipoIncidente { get; private set; }

        public Persona Sujeto { get; private set; }
        public Policia OficialACargo { get; private set; }

        public Incidente(Policia oficial, Persona sujeto, int tipoIncidente, int hora, int minuto, string motivo) {
            
            this.OficialACargo = oficial;
            this.Sujeto = sujeto;
            this.TipoIncidente = tipoIncidente;
            this.Hora = hora;
            this.Minuto = minuto;
            this.Motivo = motivo;
        }

        public string VerDescripcion()
        {
            string resultado = "";
            if (this.TipoIncidente == 1)
            {
                resultado = $@"Denuncia Policial. Emitida a las {this.Hora} : {this.Minuto}
                               Motivo: {this.Motivo},
                               Agente Policial: {this.OficialACargo},
                               Sujeto denunciante: {this.Sujeto}
                            ";
            }
            else
            {
                resultado = $@"Arresto Policial. Emitida a las {this.Hora} : {this.Minuto}
                               Motivo: {this.Motivo},
                               Agente Policial: {this.OficialACargo},
                               Sujeto denunciante: {this.Sujeto}
                            ";
            }
            return resultado;
        }

    }
}
