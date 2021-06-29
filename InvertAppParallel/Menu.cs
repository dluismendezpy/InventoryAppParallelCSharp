using System;
using System.Collections.Generic;
using System.Text;

namespace InvertAppParallel
{
    public class Menu
    {

        Category categoria = new Category();

        public void mantenimientoCategorias()
        {
            Console.WriteLine("InverApp - Categorias" +
                              "\n\nIntroduce el numero con la opcion deseada... " +
                              "\n\n1. Agregar categoria" +
                              "\n2. Editar categoria" +
                              "\n3. Eliminar categoria" +
                              "\n4. Listar categorias" +
                              "\n5. Volver atras");
            int opcCategoria = int.Parse(Console.ReadLine());

            switch (opcCategoria)
            {
                case 1:
                    Console.Clear();
                    categoria.AgregarCategoria();
                    break;
                case 2:
                    Console.Clear();
                    categoria.EditarCategoria();
                    break;
                case 3:
                    Console.Clear();
                    break;
                case 4:
                    Console.Clear();
                    categoria.ListarCategoria();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Adios, espero que vuelvas pronto. Presiona cualquier tecla para salir...");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }

        }

        public void mantenimientoProductos()
        {

        }

        public void entradaInventario()
        {

        }

        public void salidaInventario()
        {

        }

    }
}
