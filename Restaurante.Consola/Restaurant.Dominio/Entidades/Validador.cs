using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dominio.Entidades
{
   public class Validador
    {
        public string pedirString(string mensaje)
        {

            string retorno;

            Console.WriteLine(mensaje);
            retorno = Console.ReadLine().ToUpper();

            do
            {
                Console.WriteLine(mensaje);
                if (retorno == "")
                {
                    Console.WriteLine("Es inválido. No puede ser vacío");
                }
            } while (retorno == "");

            return retorno;
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
