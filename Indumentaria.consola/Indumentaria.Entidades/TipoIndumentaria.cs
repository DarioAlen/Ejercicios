using System;
using System.Collections.Generic;
using System.Text;

namespace Indumentaria.Entidades
{
   public class TipoIndumentaria
    {
        private int _codigoTipoIndumentaria;
        private string _descripcion;

        public TipoIndumentaria(int codigoTipoIndumentaria, string descripcion)
        {
            _codigoTipoIndumentaria = codigoTipoIndumentaria;
            _descripcion = descripcion;
        }

        public int CodigoTipoIndumentaria
        {
            get { return _codigoTipoIndumentaria; }
            set { _codigoTipoIndumentaria = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
    }
}
