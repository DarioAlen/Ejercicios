using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Negocio.Entidades
{
    public class Salario
    {
        private double _bruto;
        private string _codigoTransferencia;
        private double _descuento;
        private DateTime _fecha;

        public double Bruto
        {
            get { return _bruto; }
        }

        public string CodigoTransferencia
        {
            get { return _codigoTransferencia; }
        }

        public double Descuento
        {
            get { return _descuento; }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
        }

        public double GetSalarioNeto()
        {
            double resultado = _bruto - _descuento;
            return resultado;
        }

        public double GetSalario()
        {
            return _bruto;
        }
    }
}
