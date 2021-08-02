using Microsoft.AspNetCore.Mvc;
using ModuloNotificacionesPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloNotificacionesPI.Controllers
{
    public class ConsultasController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ConsultasController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable Index()
        {
            var consulta = from usuario in _context.Usuario
                           join producto in _context.Producto on usuario.UsuarioId equals producto.ProductoId
                           select $"La ultima compra registrada al usuario {usuario.Nombre} fue la fecha: {producto.FechaRegistro}";
            return consulta;
        }

    }
}
