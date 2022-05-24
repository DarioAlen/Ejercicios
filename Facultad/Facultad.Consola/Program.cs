using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno juan = new Alumno(1, "Alvarez", DateTime.Now.AddYears(-34), "Juan");
            

            Console.WriteLine("ingrese Alumno");



            int codigo;
            Universidad uba = new Universidad(7, "Filosofía y letras");
            uba.AgregarAlumno(juan);

            string mensaje = "";
            try
            {
                Console.WriteLine("Ahora eliminá");
                codigo = Convert.ToInt32(Console.ReadLine());

                uba.EliminarAlumno(codigo);  //Preguntar porque recurre al Equals si no lo llamo (Aunque funciona bien)


            }
            catch (Exception ex)
            {
                mensaje = ex.Message.ToString();
            }

            Empleado Carlos = new Empleado(22, "Carlos", DateTime.Now.AddYears(-65), "Aleccio", DateTime.Now.AddYears(-20));
            Salario salario = new Salario(120000, "00200", 20.0, DateTime.Now);
            Carlos.AgregarSalario(salario);
            uba.AgregarEmpleado(Carlos);
            
            Empleado CarlosModificated = new Empleado(22, "Carlos", DateTime.Now.AddYears(-65), "Junco", DateTime.Now.AddYears(-20));
            try
            {
                uba.ModificarEmpleado(CarlosModificated);
            }
            catch (Exception ex)
            {
                mensaje = ex.Message.ToString();
            }
        }
    }
}
