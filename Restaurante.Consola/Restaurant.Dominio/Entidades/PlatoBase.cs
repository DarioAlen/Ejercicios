using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dominio.Entidades
{
    public abstract class PlatoBase
    {
        private int _codigoPlato;
        private string _descripcion;

        public PlatoBase(int codigoPlato, string descripcion)
        {
            _codigoPlato = codigoPlato;
            _descripcion = descripcion;
        }

        public virtual string MostrarPlato()
        {
            return _codigoPlato.ToString() + " " + _descripcion;
        }

        public int CodigoPlato
        {
            get { return _codigoPlato; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
        }
    }
}
