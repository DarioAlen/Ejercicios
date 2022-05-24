using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Entidades
{
   public abstract class Contacto : ContactoBase
    {
        public Contacto(int codigo, string nombre, string apellido, string telefono, string direccion)
            : base(codigo, nombre, apellido)
        {
            _telefono = telefono;
            _direccion = direccion;

        }

        protected string _telefono;
        protected string _direccion;
        protected string _log;
        protected DateTime _fechaNacimiento;
        protected int _llamadas;


        public string Telefono
        {
            get
            {
                return _telefono;
            }
        }
        public string Direccion
        {
            get
            {
                return _direccion;
            }
        }

        //public string Nombre2
        //{
        //    get => _nombre;
        //    set => _nombre = value;
        //}


        public void AgregarLog(string nuevoEvento)
        {
            _log = _log + nuevoEvento;
        }
        public int Edad()
        {
            double edad = (DateTime.Now - _fechaNacimiento).Days / 365;
            return Convert.ToInt32(edad);
        }

        public void LLamar()
        {


            _llamadas++;

        }
    }
}
