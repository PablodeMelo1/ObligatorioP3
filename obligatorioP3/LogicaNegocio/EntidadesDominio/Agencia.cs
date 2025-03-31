using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    class Agencia
    {
        public string nombre { get; set; }
        public string direccionPostal { get; set; }
        public int latitud { get; set; }
        public int longitud { get; set; }
        public Agencia(string nombre, string direccionPostal, int latitud, int longitud)
        {
            this.nombre = nombre;
            this.direccionPostal = direccionPostal;
            this.latitud = latitud;
            this.longitud = longitud;
        }
    }
}
