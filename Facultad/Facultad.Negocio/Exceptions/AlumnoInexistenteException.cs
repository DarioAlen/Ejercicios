using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Negocio.Exceptions
{
   public class AlumnoInexistenteException : Exception
    {
        public AlumnoInexistenteException() : base("El alumno no existe")
        {
            
        }
    }
}
