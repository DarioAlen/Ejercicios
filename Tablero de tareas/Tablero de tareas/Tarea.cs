using System;
using System.Collections.Generic;
using System.Text;

namespace Tablero_de_tareas
{
   public class Tarea
    {
       
        private int _codigo_tarea;
        private string _descripción;
        private string _estado;
        private int _orden;
        private DateTime _fechaAlta;
        private DateTime _realizacion;

        public Tarea(int codigo, string descripción, string estado, int orden, DateTime realizacion)
        {
            _codigo_tarea = codigo;
            _descripción = descripción;
            _estado = estado;
            _orden = orden;
            _fechaAlta = DateTime.Now;
            _realizacion = realizacion;
        }

        internal int codigo_tarea
        {
            get { return _codigo_tarea; }
            set { _codigo_tarea = value; }
        }
        public string descripcion
        {
            get { return _descripción; } 
        }
        public int orden
        {
            get { return _orden; }
        }
        public string estado
        {
            set { _estado = value; }
            get { return _estado; }
        }
        public DateTime fechaAlta
        {
            get { return _fechaAlta; }
        }
        public DateTime realizada
        {
            get { return _realizacion; }
        }

        public string MostrarTarea()
        {
            return _codigo_tarea.ToString() + " " + _descripción.ToString() + " "; 
        }
    }
}
