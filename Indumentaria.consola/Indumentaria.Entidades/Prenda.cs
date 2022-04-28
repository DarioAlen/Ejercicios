using System;
using System.Collections.Generic;
using System.Text;

namespace Indumentaria.Entidades
{
    public class Prenda
    {
        private int _codigoPrenda;
        private int _codigoTipoIndumentaria;
        private string _descripcion;
        private string _genero;
        private string _talle;
        private int _codigoMarca;
        private double _precio;
        private int _stock;

        public Prenda(int codigoTipoIndumentaria, string descripcion, string genero, string talle, int codigoMarca, double precio)
        {
            //_codigoPrenda = codigoPrenda; Lo maneja la clase TiendaRopa.
            _codigoTipoIndumentaria = codigoTipoIndumentaria;
            _descripcion = descripcion;
            _genero = genero;
            _talle = talle;
            _codigoMarca = codigoMarca;
            _precio = precio;
        }

        public int CodigoPrenda
        {
            get { return _codigoPrenda; }
            set { _codigoPrenda = value; } 
        }

        public int CodigoTipoIndumentaria
        {
            get { return _codigoTipoIndumentaria; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
        }

        public string Genero
        {
            get { return _genero; }
        }

        public string Talle
        {
            get { return _talle; }
        }

        public int CodigoMarca
        {
            get { return _codigoMarca; }
        }

        public double Precio
        {
            get { return _precio; }
        }

        public int Stock
        {
            get { return _stock; }
        }
        public string getDatalle()
        {
            return CodigoPrenda.ToString() + " " + CodigoTipoIndumentaria.ToString()
                + " " + Descripcion + " " + Genero + " " + Talle + " " + _codigoMarca
                + " " + Precio;
            //habría que hacer una especie de join con marca.
        }

    }
}
