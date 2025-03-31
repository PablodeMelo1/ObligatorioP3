using ExcepcionesPropias.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    class Comun : Envio
    {
        public Agencia agenciaDestino { get; set; }

        public Comun(int id, int numTracking, Usuario empleado, Usuario cliente, tipoEstadoPack estado, double peso, Agencia agenciaDestino) : base(id, numTracking, empleado, cliente, estado, peso)
        {
            this.agenciaDestino = agenciaDestino;
        }


    }
}
