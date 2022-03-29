using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaContactoV1
{
    class Validador
    {
        public string pedirOpcionDeMenu()
        {
            string menu = "";
            string opcionMenu = "";
            const string opcionL = "L";
            const string opcionC = "C";
            const string opcionE = "E";
            const string opcionA = "A";

            do
            {
                Console.WriteLine("Menu Principal");
                menu = menu + "L - Listar" + "\n";
                menu = menu + "C - Consultar" + "\n";
                menu = menu + "E - Editar" + "\n";
                menu = menu + "A - Agregar" + "\n";
                menu = menu + "S - Salir" + "\n";
                opcionMenu = pedirString(menu);
                if (opcionMenu != opcionL && opcionMenu != opcionC && opcionMenu != opcionE && opcionMenu != opcionA)
                {
                    Console.WriteLine("Debe ingresar una opción válida");
                }
            } while (opcionMenu != opcionC && opcionMenu != opcionE && opcionMenu != opcionA);

            return opcionMenu;
        }


        public string pedirString(string mensaje)
        {
            string almacen = "";

            do
            {
                Console.WriteLine(mensaje);
                almacen = (Console.ReadLine()).ToUpper();

                if (almacen == "")
                {
                    Console.WriteLine("Ingrese opción válida");
                }
            } while (almacen == "");
            return almacen;
        }
        public int pedirInteger(string mensaje, int minimo, int maximo)
        {
            int numero = minimo - 1;
            bool pudeConvertir;

            do
            {
                Console.WriteLine(mensaje);
                pudeConvertir = Int32.TryParse(Console.ReadLine(), out numero);
                if (pudeConvertir)
                {
                    if (numero < minimo || numero > maximo)
                    {
                        Console.WriteLine(mensaje);
                    }
                }
                else
                {
                    Console.WriteLine("Debe ingresar un valor numerico");
                    numero = minimo - 1;
                }
            } while (numero < minimo || numero > maximo);

            return numero;
        }
    }
}
