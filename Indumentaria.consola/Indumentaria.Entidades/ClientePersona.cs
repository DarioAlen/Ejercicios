using System;
using System.Collections.Generic;
using System.Text;

namespace Indumentaria.Entidades
{
   public class ClientePersona : Persona
    {
        private string _direccion;
        private bool _clienteFrecuente;
        public ClientePersona(int dni, string direccion, string nombre, string apellido, bool clienteFrecuente) : base(dni, nombre, apellido)
        {
            _direccion = direccion;
            _clienteFrecuente = clienteFrecuente;
        }

        public string Direccion
        {
            get { return _direccion; }
        }

        public bool ClienteFrecuente
        {
            get { return _clienteFrecuente; }
        }
        public override string MostrarEntidad()
        {
            return Dni.ToString() + " "
                + Nombre + " " + Apellido + " "
                + Direccion + " " + ClienteFrecuente;
        }
    }
}
