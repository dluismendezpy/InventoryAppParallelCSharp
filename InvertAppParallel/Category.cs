using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Models;

namespace InvertAppParallel
{
    public class Category
    {

        public void AgregarCategoria()
        {
            Console.WriteLine("Agregar categoria" +
                              "\n\nIntroduce el nombre de la categoria...");
            String categoria = Console.ReadLine();

            using (var db = new InverAppHomeworkDBContext())
            {
                var data = db.Categories;

                data.Add(new Database.Models.Category { CategoryName = categoria });

                db.SaveChanges();
            }

        }

        public void ListarCategoria()
        {
            using (var db = new InverAppHomeworkDBContext())
            {
                var data1 = db.Categories.ToList();
                Parallel.ForEach(data1, categorias =>
                {
                    Console.WriteLine($"ID: {categorias.CategoryId} --- Categoria: {categorias.CategoryName}");
                });
            }
        }

    }
}
