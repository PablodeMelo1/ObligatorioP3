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
        public List<Comentario> comentarios { get; set; }
        public Envio envio { get; set; }

        public Etapa(int id, string nombre, List<Comentario> comentarios, Envio envio)
        {
            this.id = id;
            this.nombre = nombre;
            this.comentarios = comentarios;
            this.envio = envio;
        }


    }
}
