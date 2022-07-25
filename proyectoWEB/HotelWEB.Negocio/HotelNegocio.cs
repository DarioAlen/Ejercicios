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
        private AccesoDatos accesoDatos;
        private List<Cliente> listadoClientes;
        public HotelNegocio()
        {
            accesoDatos = new AccesoDatos();
        }

        public List<Cliente> RetornarClientes()
        {
            listadoClientes = accesoDatos.TraerClientes();

            return listadoClientes;
        }
    }
}
