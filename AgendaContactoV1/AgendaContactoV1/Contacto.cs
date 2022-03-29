using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaContactoV1
{
    class Contacto
    {
        private int _codigo = 100;
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _direccion;
        private DateTime _fechaNacimiento;
        private int _llamadas;

        public Contacto(string nombre, string apellido, string telefono, string direccion, DateTime fechaNacimiento)
        {
            _codigo = AutoIncrementar();
            _nombre = nombre;
            _apellido = apellido;
            _telefono = telefono;
            _direccion = direccion;
            _fechaNacimiento = fechaNacimiento;

        }

        public int Codigo
        {
            get
            {
                return _codigo;
            }
        }
        
        public int Edad()
        {
            double edad = (DateTime.Now - _fechaNacimiento).Days / 365;
            return Convert.ToInt32(edad);
        }

        public void llamar()
        {
            _llamadas++;
        }

        public int AutoIncrementar()
        {
            return _codigo = _codigo + 1;
        }

        public int MostrarAgenda()
        {
            return _codigo; //+  _nombre.ToString() + "/n" + _apellido.ToString() + "/n" + _telefono + "/n" + _direccion + _fechaNacimiento.ToString();
        }
    }
}
