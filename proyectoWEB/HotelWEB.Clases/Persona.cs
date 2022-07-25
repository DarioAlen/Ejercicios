using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWEB.Clases
{
   public abstract class Persona
    {
        string _nombre;
        string _apellido;
        string _direccion;
        string _telefono;
        string _email;
        long _dni;
        DateTime _fechaNacimiento;

        public Persona(string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaNacimiento)
        {
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _telefono = telefono;
            _email = email;
            _fechaNacimiento = fechaNacimiento;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Email { get => _email; set => _email = value; }
        public long Dni { get => _dni; set => _dni = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }

    }
}
