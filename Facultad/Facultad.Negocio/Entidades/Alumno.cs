using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Negocio.Entidades
{
    public class Alumno : Persona
    {
        private int _codigo;

        public Alumno(int codigo, string apellido, DateTime fechaNac, string nombre) : base(apellido, fechaNac, nombre)
        {
            _codigo = codigo;
        }

        public int Codigo
        {
            get { return _codigo; }
        }

        internal override string GetCredencial()
        {
            return string.Format("{0} - {1} - {2}", this._codigo, this._apellido, this._nombre);
        }

        public override string ToString()
        {
            return base.Nombre;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Alumno))
                return false;

            Alumno alu = (Alumno)obj;
            if  (alu.Codigo == this.Codigo && alu.Nombre == this.Nombre && alu.Apellido == this.Apellido)
                return true;

            return false;
        }

    }
}
