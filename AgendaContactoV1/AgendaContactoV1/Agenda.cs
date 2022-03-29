using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaContactoV1
{
    class Agenda
    {
        private string _nombre;
        private string _tipo;
        private int _cantidadContactos;
        private List<Contacto> _contactos;
        private Contacto ContactoABuscar;

        public Agenda(string nombre, string tipo, int maximo)
        {
            _nombre = nombre;
            _tipo = tipo;
            _cantidadContactos = maximo;
            _contactos = new List<Contacto>(); 

        }
        public void AgregarContacto(Contacto c)
        {
            if (CantidadDeRegistros() < _cantidadContactos)
            {
                _contactos.Add(c);
            }
            else
            {
                //avisar de que esto no funcionó
                //Si pongo un booleano, eso es un flag. Como hicimos varias veces antes.
            }
        }

        public bool AgregarContatoFlag(Contacto c)
        {
            if (CantidadDeRegistros() < _cantidadContactos)
            {
                _contactos.Add(c);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void EliminarContacto(int codigo)
        {
            int indice = 0;


            foreach (Contacto contactoabuscar in _contactos)
            {
                if (contactoabuscar.Codigo == codigo)
                {
                    indice = _contactos.IndexOf(contactoabuscar);
                }
            }

            _contactos.RemoveAt(indice);
        }

        public Agenda TraerContactoFrecuente() 
        { 
            return null; //A que se refiere. 
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public string Tipo
        {
            get { return _tipo; }
        }

        public int CantidadMaximaContactos
        {
            get { return _cantidadContactos; }
        }

        public int CantidadDeRegistros()
        {
            return _contactos.Count;
        }

        public string ListadoDeContactos()
        {
            string retorno = "";
            foreach (Contacto agenda in _contactos)
            {
                retorno = retorno + agenda.MostrarAgenda();
            }
            return retorno;
        }
    }
}
