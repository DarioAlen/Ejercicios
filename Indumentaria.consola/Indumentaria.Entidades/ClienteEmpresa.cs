using System;
using System.Collections.Generic;
using System.Text;

namespace Indumentaria.Entidades
{
    public class ClienteEmpresa : Persona
    {

        private int _cuil;
        private string _razonSocial;
        private string _direccion;

        //La persona va a comprar indumentaria es de la empresa, entonces además de brindar sus datos, debe informar la razón social de la empresa
        //a la que pertenece.
        public ClienteEmpresa(int cuil, int dni, string nombre, string apellido, string razonSocial, string direccion) : base (dni ,nombre, apellido)
        {
            _cuil = cuil;
            _razonSocial = razonSocial;
            _direccion = direccion;

        }

        public override string MostrarEntidad()
        {
            throw new NotImplementedException();
        }
    }
}
