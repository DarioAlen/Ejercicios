using System;
using System.Collections.Generic;
using System.Text;

namespace Indumentaria.Entidades
{
   public class Orden //Esta clase es contenedora de clientes y marcas.
    {
        private int _codigoOrden;
        private Persona _persona; 
        private int _cantidadPrendas;
        private Prenda _prenda;
        private double _totalPedido;

        private TiendaRopa local;
        public Orden(Persona persona, int cantidadPrendas, Prenda prenda, double totalPedido)
        {
           // _codigoOrden = codigoOrden; Lo maneja la clase TiendaRopa.
            _persona = Convertidor(persona); //llamar al método que hace que castee. Segun si es cliente persona o cliente empresa
            _cantidadPrendas = cantidadPrendas;
            _prenda = prenda;
            _totalPedido = totalPedido;
        }

        public int CodigoOrden
        {
            get { return _codigoOrden; }
            set { _codigoOrden = value; }
        }

        public Persona Persona
        {
            get { return _persona; }
        }

        public int CantidadPrendas
        {
            get { return _cantidadPrendas; }
        }

        public Prenda Prenda
        {
            get { return _prenda; }
        }

        public double TotalPedido
        {
            get { return _totalPedido; }
        }

        private Persona Convertidor(Persona p)
        {
            ClienteEmpresa clienteEmpresa;
            ClientePersona clientePersona;
            if (p is ClienteEmpresa)
            {
                clienteEmpresa = (ClienteEmpresa)p; //castear..
                return clienteEmpresa;
            }
            else
            {
                clientePersona = (ClientePersona)p;
                return clientePersona;
            }

        }

    }
}
