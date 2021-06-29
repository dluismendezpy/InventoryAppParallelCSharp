using System;

namespace InvertAppParallel
{
    class Program
    {
        static void Main(string[] args)
        {

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
                    Menu.mantenimientoCategorias();
                    break;
                case 2:
                    Console.Clear();
                    Menu.mantenimientoProductos();
                    break;
                case 3:
                    Console.Clear();
                    Menu.entradaInventario();
                    break;
                case 4:
                    Console.Clear();
                    Menu.salidaInventario();
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
