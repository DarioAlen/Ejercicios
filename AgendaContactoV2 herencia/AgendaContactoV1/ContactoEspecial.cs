using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaContactoV1
{
    public class ContactoEspecial : ContactoBase
    {
        public ContactoEspecial(int codigo, string nombre, string apellido) : base(codigo, nombre, apellido)
        {
            //Acá con el this puedo ver las propiedades que hereda. Y los atributos de clase se podía ver solo en la clase. Pero acá Contacto base
            //puso protected. Es decir solo lo ven los hijos. Por eso se ven. Contacto base es el padre.

            //this._codigo
            this._antiguedad = 15;
        }
        private int _antiguedad;

        public int Antiguedad
        {
            get { return _antiguedad; }
        }

        //Contacto especial tiene antiguedad pero no tiene dirección. Esto es a los fines de diferenciarlo.
    }
}
