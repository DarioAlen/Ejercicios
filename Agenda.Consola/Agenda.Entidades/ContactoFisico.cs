using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Entidades
{
    class ContactoFisico : Contacto
    {
        public ContactoFisico(int codigo, string nombre, string apellido, string telefono, string direccion, DateTime fechaNaciemento)
        : base(codigo, nombre, apellido, telefono, direccion)
        {
            _fechaNacimiento = fechaNaciemento;
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }
        }
    }
}
