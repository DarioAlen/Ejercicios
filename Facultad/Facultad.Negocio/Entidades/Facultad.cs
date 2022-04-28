using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facultad.Negocio.Exceptions;

namespace Facultad.Negocio.Entidades
{
    public class Facultad
    {
        private List<Alumno> _alumnos;
        private int _cantidadSedes;
        private List<Empleado> _empleados;
        private string _nombre;

        public int CantidadSedes
        {
            get { return _cantidadSedes; }
        }

        public string Nombre
        {
            get { return _nombre; }
        }

        public void AgregarAlumno(Alumno a)
        {
            _alumnos.Add(a);
        }

        public void AgregarEmpleado(Empleado a)
        {
            _empleados.Add(a);
        }

        public void EliminarAlumno(int codigo)
        {
            int posicion = 0;

           
            foreach (Alumno al in _alumnos)
            {
                if (al.Codigo == codigo)
                {
               
                    posicion = _alumnos.IndexOf(al);
                    _alumnos.RemoveAt(posicion);
                }

                else 
                { 
                    throw new AlumnoInexistenteException(); 
                }
            }
        }

        public void EliminarEmpleado(int codigo)
        { //En esta función quiero aplicar el equals pero no sabría como llevarlo a cabo.
            int posicion = 0;
         

            Empleado empladoObtenido;
            foreach (Empleado em in _empleados)
            {
                if (em.Legajo == codigo)
                {
                    empladoObtenido = em;
                    posicion = _empleados.IndexOf(em);
                    _empleados.RemoveAt(posicion);
                }

                else
                {
                    throw new EmpleadoInexistenteException();
                }
            }
        }

        public void ModificarEmpleado(Empleado emp)
        {
            Empleado empleadoAModificado;
            foreach (Empleado em in _empleados)
            {
                if (em.Equals(emp))
                {
                    empleadoAModificado = new Empleado(em.Legajo, emp.Nombre, emp.FechaNac, emp.Apellido, emp.FechaIngreso);

                    EliminarEmpleado(emp.Legajo);

                    AgregarEmpleado(empleadoAModificado);
                }
            }
        }

        public List<Alumno> TraerAlumnos()
        {
            return _alumnos; 
        }

        public Empleado TraerEmpleadoPorLegajo(int legajo)
        {
            Empleado EmpleadoEncontrado = null;

            foreach (Empleado em in _empleados)
            {
                if (em.Legajo == legajo)
                {
                    EmpleadoEncontrado = em;
                }
                else
                {
                    throw new EmpleadoInexistenteException();
                }
            }
            return EmpleadoEncontrado;
        }

        public List<Empleado> TraerEmpleados()
        {
            return _empleados;
        }

        public List<Empleado> TraerEmpleadosPorNombre(string nombre)
        {
            List<Empleado> empleadosEncontrados = new List<Empleado>();
            foreach (Empleado em in _empleados)
            {
                if (em.Nombre == nombre)
                {
                    empleadosEncontrados.Add(em);
                }
                else
                {
                    throw new EmpleadoInexistenteException();
                }
            }
            return empleadosEncontrados;
        }
    }
}
