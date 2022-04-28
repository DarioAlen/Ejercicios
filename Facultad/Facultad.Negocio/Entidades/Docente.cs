using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Negocio.Entidades
{
   public class Docente : Empleado
    {
        public Docente(int legajo, string nombre, DateTime fechaNacimiento, string apellido, DateTime fechaingreso) : base(legajo, nombre, fechaNacimiento, apellido, fechaingreso)
        {

        }
        public override string GetNombreCompleto()
        {
            return base.GetNombreCompleto();
        }
    }
}
