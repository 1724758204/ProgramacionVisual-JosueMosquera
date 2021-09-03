using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloNotificaciones.Entities
{
    public class Usuario
    {
        [DisplayName("Cédula")]
        public string UsuarioId { get; set; }
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [DisplayName("Correo")]
        public string Correo { get; set; }
        [DisplayName("Producto")]
        public List<Producto> Productos { get; set; }
        [NotMapped]
        public string CedulaNombre
        {
            get { return $"{UsuarioId} {"-"} {Nombre}"; }
        }
    }
}
