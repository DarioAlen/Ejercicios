using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Agenda.Entidades
{
    class AgendaContactos
    {
        public AgendaContactos(string nombre, string tipo, int maximo)
        {
            _nombre = nombre;
            _tipo = tipo;
            _cantidadMaximaContactos = maximo;
            _contactos = new List<ContactoBase>();
        }

        private string _nombre;
        private string _tipo;
        private int _cantidadMaximaContactos;
        private List<ContactoBase> _contactos;

        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }
        public string Tipo
        {
            get
            {
                return _tipo;
            }
        }

        public int CantidadRegistros()
        {
            return _contactos.Count;
        }

        public void AgregarContacto(ContactoBase c)
        {

            if (CantidadRegistros() < _cantidadMaximaContactos)
                _contactos.Add(c);
            else
                throw new Exception();
        }
        public void EliminarContacto(int codigo) { }
        public Contacto TraerContactoFrecuente() { return null; }

    }
}
