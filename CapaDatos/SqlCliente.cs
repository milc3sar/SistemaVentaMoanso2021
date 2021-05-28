using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class SqlCliente
    {
        public static SqlCliente Instancia { get; } = new SqlCliente();

        public List<Cliente> ListarCliente()
        {
            SqlCommand cmd = null;
            var lista = new List<Cliente>();
            try
            {
                var cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaCliente", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cn.Open();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var cli = new Cliente
                    {
                        IdCliente = Convert.ToInt32(dr["idCliente"]),
                        RazonSocial = dr["razonSocial"].ToString(),
                        IdTipoCliente = Convert.ToInt32(dr["idTipoCliente"]),
                        FechaRegistro = Convert.ToDateTime(dr["fechaRegistro"]),
                        IdCiudad = Convert.ToInt32(dr["idCiudad"]),
                        Estado = Convert.ToBoolean(dr["estado"])
                    };
                    lista.Add(cli);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd?.Connection.Close(); }
            return lista;
        }

        public bool InsertarCliente(Cliente c)
        {
            var exito = false;
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("spInsertarCliente", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@razonSocial", c.RazonSocial);
                cmd.Parameters.AddWithValue("@idTipoCliente", c.IdTipoCliente);
                cmd.Parameters.AddWithValue("@fechaRegistro", c.FechaRegistro);
                cmd.Parameters.AddWithValue("@idCiudad", c.IdCiudad);
                cmd.Parameters.AddWithValue("@estado", c.Estado);
                cn.Open();
                var i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    exito = true;
                }

            }
            catch (Exception e)
            {
                throw e;

            }
            finally { cmd?.Connection.Close(); }
            return exito;

        }

        public bool EditarCliente(Cliente c)
        {
            bool exito = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();

                cmd = new SqlCommand("spEditarCliente", cn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@idCliente", c.IdCliente);
                cmd.Parameters.AddWithValue("@razonSocial", c.RazonSocial);
                cmd.Parameters.AddWithValue("@idTipoCliente", c.IdTipoCliente);
                cmd.Parameters.AddWithValue("@fechaRegistro", c.FechaRegistro);
                cmd.Parameters.AddWithValue("@idCiudad", c.IdCiudad);
                cmd.Parameters.AddWithValue("@estado", c.Estado);
                cn.Open();
                var i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    exito = true;
                }

            }
            catch (Exception e)
            {
                throw e;

            }
            finally { cmd?.Connection.Close(); }

            return exito;
        }
    }
}
