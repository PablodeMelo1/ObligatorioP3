using ExcepcionesPropias.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    class Urgente : Envio
    {
        public int direPostalDestino { get; set; }
        public bool eficiente { get; set; }

        public Urgente(int id, int numTracking, Usuario empleado, Usuario cliente, tipoEstadoPack estado, double peso, int direPostalDestino, bool eficiente) : base(id, numTracking, empleado, cliente, estado, peso)
        {
            this.direPostalDestino = direPostalDestino;
            this.eficiente = eficiente;
        }
        public void calcularEficiencia()
        {
            throw new NotImplementedException();
        }
    }
}
