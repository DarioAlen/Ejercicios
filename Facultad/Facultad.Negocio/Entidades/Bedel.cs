using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Negocio.Entidades
{
    public class Bedel : Empleado
    {
        private string _apodo;

        public Bedel(int legajo,string nombre, string apodo, DateTime fechaNacimiento, string apellido,DateTime fechaingreso) : base(legajo,nombre,fechaNacimiento,apellido,fechaingreso)
        {
            _apodo = apodo;
        }
        public string Apodo
        {
            get { return _apodo; }
        }

        public override string GetNombreCompleto()
        {
            return base.Apellido + base.Nombre;
        }
    }
}
