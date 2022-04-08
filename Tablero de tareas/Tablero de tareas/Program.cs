using System;

namespace Tablero_de_tareas
{
    class Program
    {
        static void Main(string[] args)
        {
            //string titulo;
            //string descripcion;
            //DateTime fechainicioProyeto;

            int codigo;
            string descripción;
            string estado;
            int orden;
            DateTime fechaAlta;
            DateTime realizacion;
            Tablero tablerito = new Tablero("Tablero nuevo", "Tablero de comando", DateTime.Now);
            Validador val = new Validador();
            string opcion;
            int contador = val.pedirInteger("ingrese numero0", 1,100);
            do
            {

                codigo = contador; //tablerito.AsignadorNumeroSecuecial(); debería ser la clase tablero que asigne. Pero no sé.
                descripción = val.pedirString("Ingrese descripción");
                estado = val.pedirString("Estado..");
                orden = val.pedirInteger("Ingrese número", 1, 100);

                opcion = val.pedirString("eliga opción");
                Tarea tarea = new Tarea(codigo, descripción, estado, orden, DateTime.Now, DateTime.Now);
                tablerito.AgregarTarea(tarea);
                contador++;
            } while (opcion != "N");

            Console.WriteLine(tablerito.ListadoDeTareas());
        }
    }
}
