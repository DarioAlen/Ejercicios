using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.consola
{
    class Program
    {
        static void Main(string[] args)
        {
            TiendaRopa tienda1 = new TiendaRopa("El ropero", "Los Incas 1234");
            ClienteEmpresa juanseSA = new ClienteEmpresa(2034343443, 2423324, "Juan", "Se", "cucho", "Avenida Larga 3546");
            ClientePersona Ximena = new ClientePersona(29897999, "Av del tejar", "Ximena", "Alvarez", false);
            Prenda pantalon = new Prenda("Pantalón de vestir", "Masculino", "L", 2, 800.00);
            Prenda camisa = new Prenda("Camisa Estampada", "Masculino", "L", 3, 900.43);
            TipoIndumentaria deportivo = new TipoIndumentaria("Deportivo");
            TipoIndumentaria casual = new TipoIndumentaria("Casual");

            tienda1.AgregarPrenda(pantalon);
            tienda1.AgregarPrenda(camisa);
            tienda1.AgregarTipoIndumentaria(deportivo);
            tienda1.AgregarTipoIndumentaria(casual);

            Orden ord1 = new Orden(juanseSA, 3, pantalon, 30000);
            Orden ord2 = new Orden(Ximena, 4, camisa, 4000);
            tienda1.AgregarOrden(ord1);
            tienda1.AgregarOrden(ord2);

            TiendaRopa tienda2 = new TiendaRopa("Bestirse bien","Avenida alguna");

            tienda2.AgregarPrenda(pantalon);
            tienda2.AgregarPrenda(camisa);

            Orden nueva = new Orden(juanseSA, 3, pantalon, 300);

            tienda2.AgregarOrden(nueva);
        }
    }
}
