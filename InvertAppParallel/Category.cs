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
            string categoria = Console.ReadLine();

            using (var db = new InverAppHomeworkDBContext())
            {
                var data = db.Categories;

                data.Add(new Database.Models.Category { CategoryName = categoria });

                db.SaveChanges();
            }

        }

        public void EditarCategoria()
        {
            Console.WriteLine("LISTADO DE CATEGORIAS");
            Console.WriteLine("\n");
            ListarCategoria();
            Console.WriteLine("\n\nIntroduce el id de una categoria para editar...");
            int idCategory = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el nombre de la categoria");
            string newNameCategory = Console.ReadLine();

            using (var db = new InverAppHomeworkDBContext())
            {
                var data = db.Categories.First(d => d.CategoryId == idCategory);

                data.CategoryName = newNameCategory;

                db.SaveChanges();
            }
        }

        public void ListarCategoria()
        {
            using (var db = new InverAppHomeworkDBContext())
            {
                var data1 = db.Categories.ToList();

                Parallel.ForEach(data1, categoria =>
                {
                    Console.WriteLine($"ID: {categoria.CategoryId} --- Categoria: {categoria.CategoryName}");
                });
            }
        }

        public void EliminarCategoria()
        {
            Console.WriteLine("LISTADO DE CATEGORIAS");
            Console.WriteLine("\n");
            ListarCategoria();
            Console.WriteLine("\n\nIntroduce el id de una categoria para eliminar...");
            int idCategoryEliminar = int.Parse(Console.ReadLine());

            using (var db = new InverAppHomeworkDBContext())
            {
                Console.WriteLine("Estas seguro que quieres eliminar esta categoria Y/N?");
                string yesNo = Console.ReadLine();

                if (yesNo == "Y" || yesNo == "y")
                {
                    var data1 = db.Categories.First(a => a.CategoryId == idCategoryEliminar);
                    db.Categories.Remove(data1);
                    db.SaveChanges();
                }
                else if (yesNo == "N" || yesNo == "n")
                {
                    Console.Clear();
                    Menu.mantenimientoCategorias();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Has introducido una tecla incorrecta. Vuelve a intentarlo." +
                                       "Presiona cualquier tecla para salir...");
                    Menu.mantenimientoCategorias();
                    Console.ReadKey();
                }

                

            }
        }

    }
}
