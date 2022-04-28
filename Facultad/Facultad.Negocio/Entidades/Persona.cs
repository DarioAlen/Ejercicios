using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Negocio.Entidades
{
   public abstract class Persona
    {
        protected string _apellido;
        protected DateTime _fechaNac;
        protected string _nombre;

        public Persona(string apellido, DateTime fechaNac, string nombre)
        {
            _apellido = apellido;
            _fechaNac = fechaNac;
            _nombre = nombre;
        }

        public string Apellido
        {
            get { return _apellido; }
        }

        public DateTime FechaNac
        {
            get { return _fechaNac; }
        }

        public string Nombre
        {
            get { return _nombre; }
        }
        internal abstract string GetCredencial();

        public override string ToString()
        {
            return this.GetCredencial();
        }
    }
}
