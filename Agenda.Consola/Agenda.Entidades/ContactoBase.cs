using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Entidades
{
    public abstract class ContactoBase
    {
        protected int _codigo;
        protected string _nombre;
        protected string _apellido;

        public ContactoBase(int codigo, string nombre, string apellido)
        {
            _codigo = codigo;
            _nombre = nombre;
            _apellido = apellido;
        }

        public int Codigo
        {
            get
            {
                return _codigo;
            }
        }
        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }
        public string Apellido
        {
            get
            {
                return _apellido;
            }
        }
    }
}
