using System;
using System.Threading;

namespace ControlConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Control de Motor - Consola");
            Console.WriteLine("---------------------------");

            string estado = "Detenido";
            string tiempo = DateTime.Now.ToString("HH:mm:ss");

            Console.WriteLine($"Estado: {estado}");
            Console.WriteLine($"Tiempo: {tiempo}");

            while (true)
            {
                Console.WriteLine("\nSeleccione una acción:");
                Console.WriteLine("1. Girar en sentido antihorario");
                Console.WriteLine("2. Detener");
                Console.WriteLine("3. Girar en sentido horario");
                Console.WriteLine("0. Salir");

                Console.Write("Ingrese su opción:");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        estado = "Girando en sentido antihorario";
                        tiempo = DateTime.Now.ToString("HH:mm:ss");
                        Console.WriteLine($"Estado: {estado}");
                        Console.WriteLine($"Hora: {tiempo}"); 
                        break;
                    case "2":
                        estado = "Detenido";
                        tiempo = DateTime.Now.ToString("HH:mm:ss");
                        Console.WriteLine($"Estado: {estado}");
                        Console.WriteLine($"Hora: {tiempo}");                 
                        break;
                    case "3":
                        estado = "Girando en sentido horario";
                        tiempo = DateTime.Now.ToString("HH:mm:ss");
                        Console.WriteLine($"Estado: {estado}");
                        Console.WriteLine($"Hora: {tiempo}");                     
                        break;
                    case "0":
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                        break;
                }
            }
        }
    }
}
