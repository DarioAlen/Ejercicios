using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaContactoV1
{
    //class Contacto : ContactoBase este era antes
    public abstract class Contacto : ContactoBase //: Object 
    {
        //private int _codigo;
        //private string _nombre;  Al no tener esto, de todas formas hereda de contacto base. Por eso lo usa en el constructor de abajo.
        //private string _apellido;
        protected string _telefono;
        protected string _direccion;
        protected string _log;
        protected DateTime _fechaNacimiento;
        protected int _llamadas;

        // public Contacto(string nombre, string apellido, string telefono, string direccion, DateTime fechaNacimiento) Viejo constructor. Ahora el nuevo abajo.

        // Fijarse que int codigo, nobre  apellido, ni bien llega la manda a base(). La base es ContactoBase. Y no va los tipos de datos. Estos van en donde se 
        //declara, que es clasebase.
        //Cuando me construyo como contacto, llamo a mi padre para que se construya. 1:10:35
        //Las últimas tres (codigo, nombre, apellido) se las mando al padre para que la construya él. Como contacto es también un contacto base, los voy a tener.
        public Contacto(int codigo, string nombre, string apellido, string telefono, string direccion) :base(codigo, nombre, apellido)
        {
            //_codigo = Codigo;//Hereda de contactoBase 
            //_nombre = nombre;//Hereda de contactoBase //Estos tres tiene la responsabilidad el padre. Es decir primero se recibe todos los 
                                                        //parámetros, y luego reparto.
            //_apellido = apellido;//Hereda de contactoBase 
            _telefono = telefono;  
            _direccion = direccion;    // Los que siguen son de la propia clase contacto.  Porque es un contacto base (1:07:37)
            //_fechaNacimiento = fechaNacimiento;

            //Puedo usar this.codigo. Porque me pertencen. Porque yo soy un contactobase también.  
            //this._codigo = codigo; 

        }

        //public int Codigo
        //{
        //    get
        //    {
        //        return _codigo;
        //    }
        //}

        //public string Nombre
        //{
        //    get
        //    {
        //        return _nombre; //TODO ESTO ME LO LLEVO A CONTACTOBASE
        //    }
        //}

        //public string Apellido
        //{
        //    get { return _apellido; }
        //}

        public string Direccion
        {
            get { return _direccion; }
        }

        public string Telefono
        {
            get { return _telefono; }
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
            return _codigo++;
        }

        public string MostrarContacto()
        {
            return _codigo + " " +  _nombre.ToString()+ " " + _apellido.ToString() + " " + _telefono.ToString() + " " +_direccion + " " + _fechaNacimiento.ToString() + " ";
        }
    }
}
