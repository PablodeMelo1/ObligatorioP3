using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.EntidadesDominio
{
    class Etapa
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Comentario comentario { get; set; }

        public Etapa(int id, string nombre, Comentario comentario)
        {
            this.id = id++;
            this.nombre = nombre;
            this.comentario = comentario;
        }


    }
}
