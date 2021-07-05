using System;
using Unity;

namespace InyeccionDependencias
{
    class Program
    {
        
        static StockManage stockManage;
        static void Main(string[] args)
        {
            Init();
            //StockManage stockManage = new StockManage(new Stock());
            Console.WriteLine("Comprobando stock");
            Console.WriteLine(stockManage.MakeStock(new Entidades.Producto { NombreProducto = "lapiz", PrecioProducto = 0.75 }));
           // stockManage = new StockManage(new StockOnline());
            Console.WriteLine(stockManage.MakeStock(new Entidades.Producto { NombreProducto = "manzana", PrecioProducto = 0.50 }));



        }
        static void Init()
        {
            var container = new UnityContainer();
            container.RegisterType<IStock, Stock>();
            stockManage = container.Resolve<StockManage>();
        }
        
    }
}
