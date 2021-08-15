using System;

namespace Actividad3EstructuraDeControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            principal();
        }
        static void principal()
        {
            int repMEnu;

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("\t\t\t\t\t*************************************************");
            Console.WriteLine("\t\t\t\t\t**   Estructuras de control en Visual C#       **");
            Console.WriteLine("\t\t\t\t\t**                                             **");
            Console.WriteLine("\t\t\t\t\t**                                             **");
            Console.WriteLine("\t\t\t\t\t**  1. Menú                                    **");
            Console.WriteLine("\t\t\t\t\t**  2. Salir                                   **");
            Console.WriteLine("\t\t\t\t\t**                                             **");
            Console.WriteLine("\t\t\t\t\t**                                             **");

            Console.WriteLine("\t\t\t\t\t**  Ingrese 1 para mostrar menú o 2 para salir.**");
            Console.WriteLine("\t\t\t\t\t**                                             **");
            Console.WriteLine("\t\t\t\t\t*************************************************");
            var cprompt = "\t\t\t\t\t\t   Opcion:";
            Console.Write(string.Format("{0," + ((Console.WindowWidth / 1) + (cprompt.Length / 1)) + "}", cprompt));
            repMEnu = Int32.Parse(Console.ReadLine());

            if (repMEnu == 1)
            {
                while (repMEnu == 1)
                {
                    Console.Clear();
                    opciones();
                }
            }
            else if (repMEnu == 2)
            {
                Environment.Exit(2);
            }
            else
            {
                Console.WriteLine("La opcion seleccionada no es valida");
            }
        }
        static void opciones()
        {
            int opcion, repMenu;
            Console.WriteLine("\t\t\t\t\t*************************************************");
            Console.WriteLine("\t\t\t\t\t**      Ejemplos de estructura de control      **");
            Console.WriteLine("\t\t\t\t\t**  1-- Programa 1                            **");
            Console.WriteLine("\t\t\t\t\t**  2-- Programa 2                            **");
            Console.WriteLine("\t\t\t\t\t**  3-- Programa 3                            **");
            Console.WriteLine("\t\t\t\t\t**  4-- Programa 4                            **");
            var cprompt = "\t\t\t\t        **  Ingrese una opción:";
            Console.Write(string.Format("{0," + ((cprompt.Length / 1)) + "}", cprompt));
            opcion = Int32.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    programa1();
                    break;

                case 2:
                    programa2();
                    break;

                case 3:
                    programa3();
                    break;

                case 4:
                    programa4();
                    break;
                default:
                    System.Console.WriteLine("La opción que a seleccionado es incorrecta");
                    break;
            }
            Console.WriteLine("Presiona 1 para seguir o 2 para salir");
            repMenu = Int32.Parse(Console.ReadLine());
            if (repMenu == 1)
            {
                Console.Clear();
                principal();
            }
            else if (repMenu == 2)
            {
                Environment.Exit(2);
            }
            else
            {
                Console.WriteLine("La opcion seleccionada no es valida");
            }
            static void programa1()
            {
                System.Console.WriteLine("\t\t\t\t\t**  Programa 1                                 **");
                Console.WriteLine("\t\t\t\t\t**                                             **");
                Console.WriteLine("\t\t\t\t\t**                                             **");
                Console.WriteLine("\t\t\t\t\t*************************************************");
            }
            static void programa2()
            {
                System.Console.WriteLine("\t\t\t\t\t**  Programa 2                                 **");
                Console.WriteLine("\t\t\t\t\t**                                             **");
                Console.WriteLine("\t\t\t\t\t**                                             **");
                Console.WriteLine("\t\t\t\t\t*************************************************");
            }
            static void programa3()
            {
                System.Console.WriteLine("\t\t\t\t\t**  Programa 3                                 **");
                Console.WriteLine("\t\t\t\t\t**                                             **");
                Console.WriteLine("\t\t\t\t\t**                                             **");
                Console.WriteLine("\t\t\t\t\t*************************************************");
            }
            static void programa4()
            {
                System.Console.WriteLine("\t\t\t\t\t**  Programa 4                                 **");
                Console.WriteLine("\t\t\t\t\t**                                             **");
                Console.WriteLine("\t\t\t\t\t**                                             **");
                Console.WriteLine("\t\t\t\t\t*************************************************");
            }

        }
    }
}
