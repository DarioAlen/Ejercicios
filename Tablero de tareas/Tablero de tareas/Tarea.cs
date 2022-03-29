using System;
using System.Collections.Generic;
using System.Text;

namespace Tablero_de_tareas
{
    class Tarea
    {
        Tablero tableroconcreto;
        private int _codigo_tarea;
        private string _descripción;
        private string _estado;
        private int _orden;
        private DateTime _fechaAlta;
        private DateTime _realizacion;

        public Tarea(string descripción, string estado, int orden, DateTime fechaAlta, DateTime realizacion)
        {
            _codigo_tarea = tableroconcreto.AsignadorNumeroSecuecial();
            _descripción = descripción;
            _estado = estado;
            _orden = orden;
            _fechaAlta = fechaAlta;
            _realizacion = realizacion;
        }

        public int codigo_tarea
        {
            get { return _codigo_tarea; }
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
    }
}
