using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloNotificaciones.Entities
{
    public class Producto
    {
        [DisplayName("Código de Producto")]
        public int ProductoId { get; set; }
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [DisplayName("Precio")]
        public float Precio { get; set; }
        [DisplayName("Fecha de Registro")]
        public DateTime FechaRegistro { get; set; }
        [ForeignKey("Usuario")]
        [DisplayName("Cédula")]
        public string UsuarioId { get; set; }
        [DisplayName("Cédula")]
        public Usuario Usuario { get; set; }
    }
}
