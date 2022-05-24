using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Entidades
{
   public class ContactoEspecial : ContactoBase
    {
        public ContactoEspecial(int codigo, string nombre, string apellido) : base(codigo, nombre, apellido)
        {
            this._antiguedad = 15;
        }
        private int _antiguedad;

        public int Antiguedad
        {
            get
            {
                return _antiguedad;
            }
        }
    }
}
