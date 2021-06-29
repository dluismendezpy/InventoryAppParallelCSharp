using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertAppParallel
{
    public class Products
    {

        public void AgregarProducto()
        {
            Console.WriteLine("AGREGAR PRODUCTOS" +
                              "\n\nIntroduce el nombre del nuevo producto...");
            string NombreProducto = Console.ReadLine();

            Console.WriteLine("Introduce el precio...");
            int precioProducto = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la cantidad...");
            int cantidadProducto = int.Parse(Console.ReadLine());

            using (var db = new InverAppHomeworkDBContext())
            {
                var data = db.Products;

                data.Add(new Product
                {
                    ProductName = NombreProducto,
                    ProductPrice = precioProducto,
                    ProductAmount = cantidadProducto
                });

                db.SaveChanges();
            }
        }

        public void ListarProductos()
        {
            using (var db = new InverAppHomeworkDBContext())
            {
                var data2 = db.Products.ToList();

                Parallel.ForEach(data2, producto =>
                {
                    Console.WriteLine($"ID: {producto.ProductId} --- " +
                                      $"Nombre: {producto.ProductName} --- " +
                                      $"Precio: {producto.ProductPrice} --- " +
                                      $"Cantidad: {producto.ProductAmount}");
                });
            }
        }
    
    }
}
