using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.Models
{
    internal class Incidente
    {
        public string Motivo { get; set; }

        public int Hora { get; set; }

        public int Minuto { get; set; }

        public int TipoIncidente { get; set; }


        public Persona Sujeto { get; private set; }

        public Policia OficialACargo { get; private set; }

        public Incidente(Policia oficial, Persona sujeto) {
            
            this.OficialACargo = oficial;
            this.Sujeto = sujeto;  
        }

        public string VerDescripcion()
        {
            string resultado = "";
            if (this.TipoIncidente == 0)
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
