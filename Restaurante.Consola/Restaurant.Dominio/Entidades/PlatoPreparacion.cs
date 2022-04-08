using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dominio.Entidades
{
    public class PlatoPreparacion : PlatoBase
    {
        private string _preaparacion;
        private List<Ingrediente> _ingredientes;

        public PlatoPreparacion (int codigoPlato, string descripcion, string preparacion) : base(codigoPlato, descripcion)
         {
            _preaparacion = preparacion;
            _ingredientes = new List<Ingrediente>();
         }

        public string Preparacion
        {
            get { return _preaparacion; }
        }
        public Ingrediente BuscarPreparacion(int codigo)
        {
            int indice = 0;
            Ingrediente _ingredienteEncontrado = null;
            foreach (Ingrediente ingrediente in _ingredientes)
            {
                if (ingrediente.CodigoIngrediente == codigo)
                {
                    indice = _ingredientes.IndexOf(ingrediente);
                }

                else
                {
                    throw new Exception();
                }
            }

            _ingredienteEncontrado = _ingredientes[indice];

            return _ingredienteEncontrado;

        }

        public string MostrarIngredientes()
        {
            string _salida = "";
            foreach (Ingrediente ingrediente in _ingredientes)
            {
                _salida = _salida + ingrediente.MostrarIngrediente();
            }
            return _salida;
        }
    }
}
