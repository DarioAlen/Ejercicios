using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelWEB.Clases;
using System.Data.SqlClient;

namespace HotelWEB.Datos.Utilidades
{
    public class AccesoDatos
    {
        private SqlConnection conn = new SqlConnection("Data Source=TU EQUIPO\\SQLEXPRESS;Initial Catalog=HotelesRichTexan;Integrated Security=True");

        #region métodos para insertar
        public void InsertarCliente(Cliente cli)
        {
            try
            {
                conn.Open();
                string query = @"INSERT INTO Cliente (fechaAlta, activo, nombre, apellido, direccion, telefono, mail)
                                 VALUES (@fechaAlta, @activo, @nombre, @apellido, @direccion, @telefono, @email)";

                SqlParameter fechaAlta = new SqlParameter("@fechaAlta", cli.FechaAlta);
                SqlParameter activo = new SqlParameter("@activo", cli.Activo);
                SqlParameter nombre = new SqlParameter("@nombre", cli.Nombre);
                SqlParameter apellido = new SqlParameter("@apellido", cli.Apellido);
                SqlParameter direccion = new SqlParameter("@direccion", cli.Direccion);
                SqlParameter telefono = new SqlParameter("@telefono", cli.Telefono);
                SqlParameter email = new SqlParameter("@email", cli.Email);

                SqlCommand commando = new SqlCommand(query, conn);

                commando.Parameters.Add(fechaAlta);
                commando.Parameters.Add(activo);
                commando.Parameters.Add(nombre);
                commando.Parameters.Add(apellido);
                commando.Parameters.Add(direccion);
                commando.Parameters.Add(telefono);
                commando.Parameters.Add(email);

                commando.ExecuteNonQuery();
            }

            catch (Exception)
            {

            }

            finally
            {
                conn.Close();
            }
        }

        public void InsertarReserva(Reserva res)
        {
            try
            {
            }

            catch
            {
            }
        }

        public void InsertarHotel(HotelEntidad ht)
        {
            try
            {
            }

            catch
            {
            }
        }

        public void InsertarHabitacion(Habitacion hb)
        {
            try
            {
            }

            catch
            {
            }
        }
        #endregion

        #region métodos para listar
        public List<Cliente> TraerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                conn.Open();
                string query = @"SELECT id, fechaAlta, activo, nombre, apellido, direccion, telefono, mail, fechaNacimiento
                                 from Cliente";

                SqlCommand seleccion = new SqlCommand(query, conn);

                SqlDataReader reader = seleccion.ExecuteReader();
                //lo que viene es para mapear 57:10

                while (reader.Read())
                {
                    clientes.Add(new Cliente
                        (
                        Convert.ToInt32(reader["id"].ToString()),
                        Convert.ToDateTime(reader["fechaAlta"].ToString()),
                        Convert.ToBoolean(reader["activo"].ToString()),
                        reader["nombre"].ToString(),
                        reader["apellido"].ToString(),
                        reader["direccion"].ToString(),
                        reader["telefono"].ToString(),
                        reader["mail"].ToString(),
                        Convert.ToDateTime(reader["fechaNacimiento"].ToString()
                        )));
                    //Nos quedamos en 59:21
                }
            }

            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }

            return clientes;
        }
        #endregion
    }
}
