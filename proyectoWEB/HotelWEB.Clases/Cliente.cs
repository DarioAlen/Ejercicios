using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWEB.Clases
{
    public class Cliente : Persona
    {
        int _id;
        DateTime _fechaAlta;
        bool _activo;

        public Cliente(int id, DateTime fechaAlta, bool activo, string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaNacimiento)
            : base(nombre, apellido, direccion, telefono, email, fechaNacimiento)
        {
            _id = id;
            _fechaAlta = fechaAlta;
            _activo = activo;
        }

        public int ID { get => _id; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public bool Activo { get => _activo; set => _activo = value; }

        public override string ToString()
        {
            return this.ID + " " + this.Nombre + " " + this.Apellido + " " + this.Direccion + " " + this.Email + " "
                + this.Telefono + " " + this.FechaNacimiento.ToString() + " " + this.FechaAlta.ToString()
                + this.Activo.ToString();
        }
    }
}
