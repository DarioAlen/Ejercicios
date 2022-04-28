using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dominio.Entidades
{
    public class PlatoEnMenu : PlatoBase
    {
        private int _codigoPlato;
        //private string _descripcion;
        private double _precio;
        

        public PlatoEnMenu(int codigoPlato, string descripcion, double precio) : base(codigoPlato, descripcion)
        {
            _precio = precio;
            
        }

        public override string MostrarPlato()
        {
            return base.CodigoPlato + base.Descripcion + " " + _precio.ToString();
        }
        //Lo que no entiendo es como se iplementa esto. Es como si los datos se fueran llenando pero en cascada.

        public double Precio
        {
            get {return _precio; }
        }
        
    }
}
