using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWEB.Clases
{
    public class HotelEntidad
    {
        private int _estrellas;
        private string _nombre;
        private string _direccion;
        private bool _amenities;
        private int _id;

        public HotelEntidad(int estrellas, string nombre, string direccion, bool amenities)
        {
            _estrellas = estrellas;
            _nombre = nombre;
            _direccion = direccion;
            _amenities = amenities;
            //_id = id;
        }

        public int Id { get => _id; set => _id = value; }
        public int Estrellas { get => _estrellas; set => _estrellas = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public bool Amenities { get => _amenities; set => _amenities = value; }
        public int ID { get => _id; set => _id = value; }

        public override string ToString()
        {
            return this.Estrellas + " " + this.Nombre + " " + this.Direccion + " " + this.Amenities + " " + this.ID;
        }
    }
}
