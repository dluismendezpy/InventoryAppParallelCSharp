using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertAppParallel
{
    public class EntradaInventario
    {

        public void Entrada()
        {
            Console.WriteLine("ENTRADA AL INVENTARIO");
            ProductList();
            Console.WriteLine("\nIntroduce el ID del producto al que quiera dar entrada...");
            int opcInventario = int.Parse(Console.ReadLine());

            Console.WriteLine($"Que cantidad quieres entrar en el inventario?");
            int newAmountInventary = int.Parse(Console.ReadLine());

            using (var db = new InverAppHomeworkDBContext())
            {
                var data = db.Products.First(d => d.ProductId == opcInventario);
                data.ProductAmount += newAmountInventary;

                db.SaveChanges();
            }
            Console.WriteLine("\n\nLos cambios se han realizado de forma exitosa!" + 
                              " Presiona cualquier techa para continuar...");
            Console.ReadKey();
        }

        private void ProductList()
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
