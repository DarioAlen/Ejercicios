using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaContactoV1
{
   public class ContactoFisico : Contacto   
    {
        public ContactoFisico(int codigo, string nombre, string apellido, string telefono, string direccion, DateTime fechaNacimiento) 
            :base (codigo, nombre, apellido, telefono, direccion)
        {
            _telefono = telefono;
            _direccion = direccion;
            _fechaNacimiento = fechaNacimiento;
        }

        //Esto es propio de él.
        public DateTime FechaNacimiento
        {
            get{ return _fechaNacimiento; }
        }
    }
}
