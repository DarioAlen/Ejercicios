using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Negocio.Entidades
{
    public class Empleado : Persona
    {
        private DateTime _fechaIngreso;
        private int _legajo;
        private List<Salario> _salarios;

        public Empleado(int legajo, string nombre, DateTime fechaNacimiento, string apellido, DateTime fechaingreso) : base(apellido, fechaNacimiento, nombre)
        {
            _fechaIngreso = fechaingreso;
            _legajo = legajo;
            _salarios = new List<Salario>();
        }

        //public int Antiguedad
        //{
        //    get { return datetime.now - fechaingreso} double edad = (DateTime.Now - _fechaNacimiento).Days / 365;
        //}

        public int Antiguedad
        {
            get { return (DateTime.Now - _fechaIngreso).Days; }
        }

        public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
        }

        public DateTime FechaNacimiento
        {
            get { return _fechaNac; }
        }
       
        public int Legajo
        {
            get { return _legajo; }
        }

        public List<Salario> Salarios
        {
            get { return _salarios; }
        }

        public Salario UltimoSalario
        {
            get { return _salarios.First();}
        }
        internal override string GetCredencial()
        {
            return string.Format("{0} - {1} - {2} - {3}", this._legajo, this._nombre, this._apellido, this.UltimoSalario);
        }

        public virtual string GetNombreCompleto()
        {
            return string.Format("{0} - {1}", this._nombre, this._apellido);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void AgregarSalario(Salario s)
        {
            _salarios.Add(s); //ver si agregamos exception acá;
        }

        
        public override bool Equals(object obj)
        {
            if (!(obj is Empleado))
                return false;

            Empleado emp = (Empleado)obj;
            if (emp.FechaIngreso == this.FechaIngreso && emp.Legajo == this.Legajo)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
