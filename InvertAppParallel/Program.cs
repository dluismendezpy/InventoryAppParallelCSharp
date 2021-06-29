using System;

namespace InvertAppParallel
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();

            Console.WriteLine("InverApp" +
                              "\n\nIntroduce el numero con la opcion deseada... " +
                              "\n\n1. Mantenimiento de categorias" +
                              "\n2. Mantenimiento de productos" +
                              "\n3. Entrada de inventario" +
                              "\n4. Salida de inventario" +
                              "\n5. Salir");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.Clear();
                    menu.mantenimientoCategorias();
                    break;
                case 2:
                    Console.Clear();
                    menu.mantenimientoProductos();
                    break;
                case 3:
                    Console.Clear();
                    menu.entradaInventario();
                    break;
                case 4:
                    Console.Clear();
                    menu.salidaInventario();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Adios, espero que vuelvas pronto. PResiona cualquier tecla para salir...");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
