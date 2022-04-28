using System;
using System.Collections.Generic;
using System.Text;

namespace Indumentaria.Entidades
{
   public class Marca
    {
        private int _codigoMarca;
        private string _descripcion;

        public Marca(int codigoMarca, string descripcion)
        {
            _codigoMarca = codigoMarca;
            _descripcion = descripcion;
        }
    }
}
