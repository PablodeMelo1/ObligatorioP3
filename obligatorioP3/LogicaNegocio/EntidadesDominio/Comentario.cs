using ExcepcionesPropias.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    class Comentario
    {
        public Usuario usuario { get; set; }
        public string texto { get; set; }
        public DateTime fecha { get; set; }

        public Comentario(Usuario usuario, string texto, DateTime fecha)
        {
            this.usuario = usuario;
            this.texto = texto;
            this.fecha = fecha;
        }
    }
}
