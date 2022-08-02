using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWEB.Clases
{
   
    public class Habitacion
    
    {
       private int _id;
       private int _idHotel;
       private int _cantidadPlazas;
       private string _categoria;
       private bool _cancelable;
       private double _precio;

        //Primer constructor.
        public Habitacion(int id,int idHotel, string categoria, int cantidadPlazas, bool cancelable, double precio)
        {
            _id = id;
            _idHotel = idHotel;
            _cantidadPlazas = cantidadPlazas;
            _categoria = categoria;
            _cancelable = cancelable;
            _precio = precio;
        }

        //Segundo constructor.
        //public Habitacion(int idHabitacion,int idHotel, int cantidadPlazas, string categoria, bool cancelable, double precio)
        //{
        //    _idHabitacion = idHabitacion;
        //    _idHotel = idHotel;
        //    _cantidadPlazas = cantidadPlazas;
        //    _categoria = categoria;
        //    _cancelable = cancelable;
        //    _precio = precio;
        //}

        public int IdHabitacion { get => _id;}
        public int IdHotel { get => _idHotel; set => _idHotel = value; }
        public int CantidadPlazas { get => _cantidadPlazas; set => _cantidadPlazas = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
        public bool Cancelable { get => _cancelable; set => _cancelable = value; }
        public double Precio { get => _precio; set => _precio = value; }

        public override string ToString()
        {
            return this.IdHabitacion.ToString() + " " + this.IdHotel.ToString() + " " +this.Categoria.ToString() + " " + this.CantidadPlazas.ToString() + this.Cancelable.ToString() +  this.Precio.ToString();
        }
    }
}
