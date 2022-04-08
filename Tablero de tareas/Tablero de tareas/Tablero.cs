using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Tablero_de_tareas
{
    class Tablero
    {
        private string _titulo;
        private string _descripcion;
        private List<Tarea> _tareas;
        private DateTime _fechainicioProyeto;
        private Tarea _tarea_concreta;
        private int _ultimoNumeroDeTarea;

        public Tablero(string titulo, string descripcion, DateTime fechainicioProyeto)
        {
            _ultimoNumeroDeTarea = 0;
            _titulo = titulo;
            _descripcion = descripcion;
            _tareas = new List<Tarea>();
            _fechainicioProyeto = fechainicioProyeto;
        }

        public bool TareaFinalizada()
        {
            return true;
        }

        private int AsignarCodigoDeTareas()
        {
            
            //Tarea ultima = _tareas
            _ultimoNumeroDeTarea++;

            return _ultimoNumeroDeTarea;
        }

        

        public void AgregarTarea(Tarea a)
        {
            a.codigo_tarea = AsignarCodigoDeTareas();
            _tareas.Add(a);

        }

        public void AgregarTarea(string descripción, string estado, int orden, DateTime realizacion)
        {
            if (estado == "1")
            {
                Tarea t1 = new Tarea(AsignarCodigoDeTareas(), descripción, estado, orden, realizacion);

                _tareas.Add(t1);
            }

            else
            {
                // Acá debo arrojar excepción llamada EstadoIncorrectoException
            }
            


        }

        public void CambiarEstado(int codigo_tarea, string estado)
        {
            int indice = 0;

            foreach (Tarea tareaabuscar in _tareas)
            {
                if (tareaabuscar.codigo_tarea == codigo_tarea)
                {
                    indice = _tareas.IndexOf(tareaabuscar);
                }
            }

            _tarea_concreta = _tareas[indice];

            _tarea_concreta.estado = estado;
        }

        public string ListarTareas()
        {
            string retorno = "";
            foreach (Tarea tarea in _tareas)
            {
                retorno = retorno + tarea.ToString() + "\n";
            }
            return retorno;
        }
        public string ListadoDeTareas()
        {
            string retorno = "";
            foreach (Tarea tarea in _tareas)
            {
                retorno = retorno + tarea.MostrarTarea(); 

            }
            return retorno;
        }

        //+ " " + tarea.descripcion.ToString() + " " + tarea.estado.ToString() + " " + tarea.orden.ToString() + " ";

    }
}
