using System;
using System.Collections.Generic;
using System.Text;

namespace Tablero_de_tareas
{
    class Tablero
    {
        private string _titulo;
        private string _descripcion;
        private List<Tarea> _tareas;
        private DateTime _fechainicioProyeto;
        private Tarea _tarea_concreta;

        public Tablero(string titulo, string descripcion, DateTime fechainicioProyeto)
        {

            _titulo = titulo;
            _descripcion = descripcion;
            _tareas = new List<Tarea>();
            _fechainicioProyeto = fechainicioProyeto;
        }

        public bool TareaFinalizada()
        {
            return true;
        }

        public int AsignadorNumeroSecuecial()
        {
            int contador = 100;
            return contador++; ;
        }

        public void AgregarTarea(Tarea a)
        {
            _tareas.Add(a);
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
    }
}
