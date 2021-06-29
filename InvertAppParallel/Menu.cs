using System;
using System.Collections.Generic;
using System.Text;

namespace InvertAppParallel
{
    public class Menu
    {
        private static Category categoria = new Category();
        private static Products producto = new Products();

        public static void mantenimientoCategorias()
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
                    categoria.EliminarCategoria();
                    break;
                case 4:
                    Console.Clear();
                    categoria.ListarCategoria();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Adios, espero que vuelvas pronto. Presiona cualquier tecla para volver...");
                    Console.ReadKey();
                    mantenimientoCategorias();
                    break;
            }

        }

        public static void mantenimientoProductos()
        {
            Console.WriteLine("InverApp - Productos" +
                              "\n\nIntroduce el numero con la opcion deseada... " +
                              "\n\n1. Agregar producto" +
                              "\n2. Editar producto" +
                              "\n3. Eliminar producto" +
                              "\n4. Listar producto" +
                              "\n5. Volver atras");
            int opcProducto = int.Parse(Console.ReadLine());

            switch (opcProducto)
            {
                case 1:
                    Console.Clear();
                    producto.AgregarProducto();
                    break;
                case 2:
                    Console.Clear();
                    producto.EditarProducto();
                    break;
                case 3:
                    Console.Clear();
                    producto.EliminarProducto();
                    break;
                case 4:
                    Console.Clear();
                    producto.ListarProductos();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Adios, espero que vuelvas pronto. Presiona cualquier tecla para volver...");
                    Console.ReadKey();
                    mantenimientoProductos();
                    break;
            }
        }

        public static void entradaInventario()
        {

        }

        public static void salidaInventario()
        {

        }

    }
}
