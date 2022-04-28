using System;
using System.Collections.Generic;
using System.Text;

namespace Indumentaria.Entidades
{
    public abstract class Persona
    {
        private int _dni;
        private string _nombre;
        private string _apellido;

        public Persona(int dni,string nombre, string apellido)
        {
            _dni = dni;
            _nombre = nombre;
            _apellido = apellido;
        }

        public int Dni
        {
            get { return _dni; }
        }
        public string Nombre
        {   
            get { return _nombre; }
        }
        public string Apellido
        {
            get { return _apellido; }
        }

        public abstract string MostrarEntidad(); //Puede ser empresa 
       
    }
}
