using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ModuloNotificacionesPI.Entities;

namespace ModuloNotificacionesPI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ModuloNotificacionesPI.Entities.Usuario> Usuario { get; set; }
        public DbSet<ModuloNotificacionesPI.Entities.Producto> Producto { get; set; }
    }
}
