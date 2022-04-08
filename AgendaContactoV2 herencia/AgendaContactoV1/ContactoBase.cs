using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaContactoV1
{
    public abstract class ContactoBase //Clase de orden superior.
    {
        //A esta clase no tiene sentido hacerle un new. Esto se puede dejar como política. Es decir que no se pueda instanciar contacto base.
        //Por eso el "abstract". Es decir que solo se puede heredarar. Esta clase solo sirve para manejar jerarquía.

        protected int _codigo;
        protected string _nombre;
        protected string _apellido;

        public ContactoBase(int codigo, string nombre, string apellido) 
        {
            _codigo = codigo;//Hereda de contactoBase 
            _nombre = nombre;//Hereda de contactoBase 
            _apellido = apellido;
        }

        //private int Codigo
        //{
        //    get { return _codigo; }
        //}

        //private string Nombre
        //{
        //    get { return _nombre; }
        //}

        //private string Apellido
        //{
        //    get { return _apellido; }
        //}

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
            get { return _apellido; }
        }
    }
}
