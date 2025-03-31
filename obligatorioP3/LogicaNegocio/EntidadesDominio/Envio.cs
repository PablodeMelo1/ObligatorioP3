using ExcepcionesPropias.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    class Envio
    {
        public int id { get; set; }
        public int numTracking { get; set; }
        public Usuario empleado { get; set; }
        public Usuario cliente { get; set; }
        public tipoEstadoPack estado { get; set; }
        public double peso { get; set; }

        public Envio(int id, int numTracking, Usuario empleado, Usuario cliente, tipoEstadoPack estado, double peso)
        {
            this.id = id;
            this.numTracking = numTracking;
            this.empleado = empleado;
            this.cliente = cliente;
            this.estado = estado;
            this.peso = peso;
        }

        public void cambiarEstado()
        {
            if (estado == tipoEstadoPack.EnProceso)
            {
                estado = tipoEstadoPack.Finalizado;
            }
            else
            {
                throw new Exception("El paquete no se encuentra en estado de entrega");
            }
            
        }

    }
}
