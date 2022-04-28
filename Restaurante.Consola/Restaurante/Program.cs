using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Dominio.Entidades;

namespace Restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu MenuEjecutivo = new Menu(100, "Variados, parrilla", false);
           // Menu MenuEspecial = new Menu(101, "Con productos de mar", false);
           // Menu MenuSimple = new Menu(102, "Pizzas y empanadas", true);

            PlatoEnMenu MilanesaConPapas = new PlatoEnMenu(100, "milanesa con papas fritas", 300.4);
//            PlatoEnMenu PizzaDeCancha = new PlatoEnMenu(101, "Pizza con salsa de tomate en la superficie y especias", 250.00);
//           PlatoEnMenu Ravioles = new PlatoEnMenu(102, "Ravioles con salsablanca", 230.00);

            MenuEjecutivo.AgregarPlato(MilanesaConPapas);
//            MenuEjecutivo.AgregarPlato(PizzaDeCancha);
//            MenuEjecutivo.AgregarPlato(Ravioles);

            string listadoEnFormatoString = MenuEjecutivo.ListadoPlatos().ToString();
            Console.WriteLine(listadoEnFormatoString);

        }
    }
}
