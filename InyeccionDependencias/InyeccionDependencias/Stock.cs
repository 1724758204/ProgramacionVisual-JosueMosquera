using InyeccionDependencias.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias
{
    class Stock : IStock
    {
        public string disponibleStock(Producto producto)
        {
            return $"el producto {producto.NombreProducto} esta disponible y el precio es {producto.PrecioProducto}";
        }
    }
}
