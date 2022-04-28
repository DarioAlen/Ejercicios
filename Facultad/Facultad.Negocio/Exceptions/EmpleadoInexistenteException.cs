using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Negocio.Exceptions
{
    public class EmpleadoInexistenteException : Exception
    {
        public EmpleadoInexistenteException() : base ("El empleado es inexistente")
       {

       }
    }
}
