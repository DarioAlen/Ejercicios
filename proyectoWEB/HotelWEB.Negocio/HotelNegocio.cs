using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelWEB.Datos.Utilidades;
using HotelWEB.Clases;
namespace HotelWEB.Negocio
{
    public class HotelNegocio
    {
        private AccesoDatos _accesoDatos;
        private List<Cliente> _listadoClientes;
        private List<Reserva> _listadoReservas;
        private List<HotelEntidad> _listadoHoteles;
        private List<Habitacion> _listadoHabitaciones;
        public HotelNegocio()
        {
            _accesoDatos = new AccesoDatos();
        }

        public List<Cliente> RetornarClientes()
        {
            _listadoClientes = _accesoDatos.TraerClientes();

            return _listadoClientes;
        }

        public List<Reserva> RetornarReservas()
        {
            _listadoReservas = _accesoDatos.TraerReservas();

            return _listadoReservas;
        }

        public List<HotelEntidad> RetornarHoteles()
        {
            _listadoHoteles = _accesoDatos.TraerHoteles();

            return _listadoHoteles;
        }

        public List<Habitacion> TraerHabitaciones()
        {
            _listadoHabitaciones = _accesoDatos.TraerHabitaciones();

            return _listadoHabitaciones;
        }
    }
}
