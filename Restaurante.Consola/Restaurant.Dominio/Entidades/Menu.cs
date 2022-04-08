using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dominio.Entidades
{
   public class Menu
    {
        private int _codigoMenu;
        private string _descripcion;
        private bool _esDelDia;
        private List<PlatoEnMenu> _listaDePlatos;

        public Menu(int codigo, string descripcion, bool esdeldia)
        {
            _codigoMenu = codigo;
            _descripcion = descripcion;
            _esDelDia = esdeldia;
            _listaDePlatos = new List<PlatoEnMenu>(); //¿porque siempre la lista pasaría por el constructor?
        }

        public int CodigoMenu
        {
            get { return _codigoMenu; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
        }

        public bool EsDelDia
        {
            get { return _esDelDia; }
        }
        public string ListadoPlatos()
        {
            string retorno = "";
            foreach (PlatoEnMenu plato in _listaDePlatos)
            {
                retorno = retorno + plato.MostrarPlato();
            }
            return retorno;
        }

        public void AgregarPlato(PlatoEnMenu plato)
        {
            _listaDePlatos.Add(plato);
        }

        public void EliminarPlato(int codigoPlato)
        {
            int indice = 0;

            
                foreach (PlatoEnMenu plato in _listaDePlatos)
                {
                    if (plato.CodigoPlato == codigoPlato)
                    {
                        indice = _listaDePlatos.IndexOf(plato);
                        //Si llegara a pasar que el código no coincide arrojará una excepción.

                        //Si lo hacemos con la validación del tipo "ingrese la correcta", me quedo atrapado.
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            
            _listaDePlatos.RemoveAt(indice);
        }

        public PlatoEnMenu BuscarPlato(int codigo)
        {
            PlatoEnMenu _platoBuscado;
            int indice = 0;
            foreach (PlatoEnMenu plato in _listaDePlatos)
            {
                if (plato.CodigoPlato == codigo)
                {
                    indice = _listaDePlatos.IndexOf(plato);
                }
                else
                {
                    throw new Exception();
                }
            }

            _platoBuscado = _listaDePlatos[indice];

            return _platoBuscado;
        }
    }
}
