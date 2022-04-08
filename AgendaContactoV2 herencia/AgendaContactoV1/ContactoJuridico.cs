using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaContactoV1
{
   public class ContactoJuridico : Contacto
    {
        private DateTime _fechaConstitucion;
        private string _razonSocial;
        public ContactoJuridico(int codigo, string nombre, string apellido, string telefono, string direccion, string razonSocial ,DateTime fechaConstitucion)
           : base(codigo, nombre, apellido, telefono, direccion)
        {
            _fechaConstitucion = fechaConstitucion;
            _razonSocial = razonSocial;
        }

        public string RazonSocial
        {
            get { return _razonSocial; }
        }
    }
}
