using LogicaNegocio.EntidadesDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesPropias.Excepciones
{
    class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int nroTelefono { get; set; }
        public string email { get; set; }
        public string contra { get; set; }
        public rolUsuario rol { get; set; }

        public Usuario(string nombre, int nroTelefono, string email, string contra, rolUsuario rol)
        {
            this.id = id++;
            this.nombre = nombre;
            this.nroTelefono = nroTelefono;
            this.email = email;
            this.contra = contra;
            this.rol = rol;
        }
    }
}
