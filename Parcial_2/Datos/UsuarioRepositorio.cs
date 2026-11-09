using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Parcial_2.Entidades;

namespace Parcial_2.Datos
{
    /// <summary>
    /// Implementación de <see cref="IUsuarioRepositorio"/> para SQL Server.
    /// Solo ejecuta procedimientos almacenados con parámetros (sin SQL concatenado).
    /// </summary>
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        /// <inheritdoc />
        public Usuario ObtenerPorNombre(string nombreUsuario)
        {
            try
            {
                using (SqlConnection cn = ConexionBD.Crear())
                using (SqlCommand cmd = new SqlCommand("dbo.sp_Usuario_ObtenerPorNombre", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 50).Value = nombreUsuario;

                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                        {
                            return null;
                        }
                        return Mapear(dr, true);
                    }
                }
            }
            catch (Exception ex) when (!(ex is DatosException))
            {
                throw new DatosException("Error al consultar el usuario en la base de datos.", ex);
            }
        }

        /// <inheritdoc />
        public IList<Usuario> Listar()
        {
            try
            {
                List<Usuario> lista = new List<Usuario>();

                using (SqlConnection cn = ConexionBD.Crear())
                using (SqlCommand cmd = new SqlCommand("dbo.sp_Usuario_Listar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(Mapear(dr, false));
                        }
                    }
                }
                return lista;
            }
            catch (Exception ex) when (!(ex is DatosException))
            {
                throw new DatosException("Error al listar los usuarios.", ex);
            }
        }

        /// <inheritdoc />
        public bool ActualizarPasswordHash(int idUsuario, string passwordHash)
        {
            try
            {
                using (SqlConnection cn = ConexionBD.Crear())
                using (SqlCommand cmd = new SqlCommand("dbo.sp_Usuario_ActualizarPassword", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = idUsuario;
                    cmd.Parameters.Add("@PasswordHash", SqlDbType.NVarChar, 256).Value = passwordHash;

                    cn.Open();
                    int filas = Convert.ToInt32(cmd.ExecuteScalar());
                    return filas > 0;
                }
            }
            catch (Exception ex) when (!(ex is DatosException))
            {
                throw new DatosException("Error al actualizar la contraseña.", ex);
            }
        }

        /// <summary>Convierte la fila actual del lector en una entidad <see cref="Usuario"/>.</summary>
        /// <param name="dr">Lector posicionado en una fila.</param>
        /// <param name="incluirHash">Si es true, también lee la columna PasswordHash.</param>
        private static Usuario Mapear(SqlDataReader dr, bool incluirHash)
        {
            Usuario u = new Usuario
            {
                IdUsuario = dr.GetInt32(dr.GetOrdinal("IdUsuario")),
                NombreUsuario = dr.GetString(dr.GetOrdinal("NombreUsuario")),
                NombreCompleto = dr.GetString(dr.GetOrdinal("NombreCompleto")),
                Rol = dr.GetString(dr.GetOrdinal("Rol")),
                Activo = dr.GetBoolean(dr.GetOrdinal("Activo")),
                FechaCreacion = dr.GetDateTime(dr.GetOrdinal("FechaCreacion"))
            };

            if (incluirHash)
            {
                u.PasswordHash = dr.GetString(dr.GetOrdinal("PasswordHash"));
            }
            return u;
        }
    }
}
