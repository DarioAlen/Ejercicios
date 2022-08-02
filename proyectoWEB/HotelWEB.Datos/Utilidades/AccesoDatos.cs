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
        private SqlConnection _conn = new SqlConnection("Data Source=AR020000934365\\SQLEXPRESS;Initial Catalog=HotelesRichTexan;Integrated Security=True");
        private List<Cliente> _clientes;
        private List<Reserva> _reservas;
        private List<HotelEntidad> _hoteles;
        private List<Habitacion> _habitaciones;

        #region métodos para insertar
        public void InsertarCliente(Cliente cli)
        {
            try
            {
                _conn.Open();
                string query = @"INSERT INTO Cliente (fechaAlta, activo, nombre, apellido, direccion, telefono, mail)
                                 VALUES (@fechaAlta, @activo, @nombre, @apellido, @direccion, @telefono, @email)";

                SqlParameter fechaAlta = new SqlParameter("@fechaAlta", cli.FechaAlta);
                SqlParameter activo = new SqlParameter("@activo", cli.Activo);
                SqlParameter nombre = new SqlParameter("@nombre", cli.Nombre);
                SqlParameter apellido = new SqlParameter("@apellido", cli.Apellido);
                SqlParameter direccion = new SqlParameter("@direccion", cli.Direccion);
                SqlParameter telefono = new SqlParameter("@telefono", cli.Telefono);
                SqlParameter email = new SqlParameter("@email", cli.Email);

                SqlCommand commando = new SqlCommand(query, _conn);

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
                _conn.Close();
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
            _clientes = new List<Cliente>();
            try
            {
                _conn.Open();
                string query = @"SELECT id, fechaAlta, activo, nombre, apellido, direccion, telefono, mail, fechaNacimiento
                                 from Cliente";

                SqlCommand seleccion = new SqlCommand(query, _conn);

                SqlDataReader reader = seleccion.ExecuteReader();
                //lo que viene es para mapear 57:10

                while (reader.Read())
                {
                    _clientes.Add(new Cliente
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
                _conn.Close();
            }

            return _clientes;
        }

        public List<Reserva> TraerReservas()
        {
            _reservas = new List<Reserva>();

            try
            {
                _conn.Open();
                string query = @"SELECT id, idCliente, idHabitacion, catidadHuespedes, fechaIngreso, fechaEgreso
                                from Reserva";

                SqlCommand seleccion = new SqlCommand(query, _conn);

                SqlDataReader reader = seleccion.ExecuteReader();

                while (reader.Read())
                {
                    _reservas.Add(new Reserva(
                        Convert.ToInt32(reader["id"].ToString()),
                        Convert.ToInt32(reader["idCliente"].ToString()),
                        Convert.ToInt32(reader["idHabitcacion"].ToString()),
                        Convert.ToInt32(reader["cantidadHuespedes"].ToString()),
                        Convert.ToDateTime(reader["fechaIngreso"].ToString()),
                        Convert.ToDateTime(reader["fechaEgreso"].ToString())
                        
                        ));
                }
            }

            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return _reservas;
        }

        public List<HotelEntidad> TraerHoteles()
        {
            _hoteles = new List<HotelEntidad>();

            try
            {
                _conn.Open();
                string query = @"SELECT id, nombre, direccion, estrellas, amenities 
                                from Hotel";
                SqlCommand seleccion = new SqlCommand(query, _conn);

                SqlDataReader reader = seleccion.ExecuteReader();

                while (reader.Read())
                {
                    _hoteles.Add(new HotelEntidad(
                        Convert.ToInt32(reader["id"].ToString()),
                        reader["nombre"].ToString(),
                        reader["direccion"].ToString(),
                        Convert.ToInt32(reader["estrellas"].ToString()),
                        Convert.ToBoolean(reader["amenities"].ToString())

                        ));
                                
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                _conn.Close();
            }

            return _hoteles;
        }

        public List<Habitacion> TraerHabitaciones()
        {
            _habitaciones = new List<Habitacion>();

            try
            {
                _conn.Open();
                string query = @"SELECT id, idHotel, categoria, cantidadPlazas, cancelacion, precio
                               FROM Habitacion";

                SqlCommand seleccion = new SqlCommand(query, _conn);

                SqlDataReader reader = seleccion.ExecuteReader();

                while (reader.Read())
                {
                    _habitaciones.Add(new Habitacion(
                        Convert.ToInt32(reader["id"].ToString()),
                        Convert.ToInt32(reader["idHotel"].ToString()),
                        reader["categoria"].ToString(),
                        Convert.ToInt32(reader["cantidadPlazas"].ToString()),
                        Convert.ToBoolean(reader["cancelable"].ToString()),
                        Convert.ToDouble(reader["precio"].ToString()
                        )));
                }
            }
            catch (Exception ex)
            {
            }

            finally
            {
                _conn.Close();
            }
            return _habitaciones;
        }
        #endregion

        #region Métodos para actualizar
        public void ActualizarCliente(Cliente cli)
        {
            try
            {
                _conn.Open();
                string query = @"UPDATE Cliente SET fechaAlta = @fechaAlta,
                                                       activo = @activo,
                                                       nombre = @nombre,
                                                       apellido = @apellido,
                                                       direccion = @direccion,
                                                       telefono = @telefono,
                                                       mail = @mail,
                                                       fechaNacimiento = @fechaNacimiento
                                                       WHERE id = @Id";

                SqlParameter fechaAlta = new SqlParameter("@fechaAlta", cli.FechaAlta);
                SqlParameter activo = new SqlParameter("@activo", cli.Activo);
                SqlParameter nombre = new SqlParameter("@nombre", cli.Nombre);
                SqlParameter apellido = new SqlParameter("@apellido", cli.Apellido);
                SqlParameter direccion = new SqlParameter("@direccion", cli.Direccion);
                SqlParameter telefono = new SqlParameter("@telefono", cli.Telefono);
                SqlParameter email = new SqlParameter("@email", cli.Email);

                SqlCommand commando = new SqlCommand(query, _conn);

                commando.Parameters.Add(fechaAlta);
                commando.Parameters.Add(activo);
                commando.Parameters.Add(nombre);
                commando.Parameters.Add(apellido);
                commando.Parameters.Add(direccion);
                commando.Parameters.Add(telefono);
                commando.Parameters.Add(email);

                commando.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
            }
            finally
            {
                _conn.Close();
            }
        }
        #endregion
    }
}
