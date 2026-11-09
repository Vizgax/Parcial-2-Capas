using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Parcial_2.Entidades;

namespace Parcial_2.Datos
{
    /// <summary>
    /// Implementación de <see cref="IProductoRepositorio"/> para SQL Server
    /// (solo procedimientos almacenados parametrizados).
    /// </summary>
    public class ProductoRepositorio : IProductoRepositorio
    {
        /// <inheritdoc />
        public IList<Producto> Listar()
        {
            return Ejecutar("dbo.sp_Producto_Listar", null);
        }

        /// <inheritdoc />
        public IList<Producto> BuscarPorNombre(string nombre)
        {
            SqlParameter p = new SqlParameter("@Nombre", SqlDbType.NVarChar, 120) { Value = nombre ?? string.Empty };
            return Ejecutar("dbo.sp_Producto_BuscarPorNombre", p);
        }

        /// <summary>Ejecuta un procedimiento que devuelve productos y los convierte a entidades.</summary>
        /// <param name="procedimiento">Nombre del procedimiento almacenado.</param>
        /// <param name="parametro">Parámetro opcional del procedimiento (puede ser null).</param>
        private static IList<Producto> Ejecutar(string procedimiento, SqlParameter parametro)
        {
            try
            {
                List<Producto> lista = new List<Producto>();

                using (SqlConnection cn = ConexionBD.Crear())
                using (SqlCommand cmd = new SqlCommand(procedimiento, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parametro != null)
                    {
                        cmd.Parameters.Add(parametro);
                    }

                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Producto
                            {
                                IdProducto = dr.GetInt32(dr.GetOrdinal("IdProducto")),
                                Codigo = dr.GetString(dr.GetOrdinal("Codigo")),
                                Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                Categoria = dr.GetString(dr.GetOrdinal("Categoria")),
                                Proveedor = dr.GetString(dr.GetOrdinal("Proveedor")),
                                Precio = dr.GetDecimal(dr.GetOrdinal("Precio")),
                                Stock = dr.GetInt32(dr.GetOrdinal("Stock")),
                                StockMinimo = dr.GetInt32(dr.GetOrdinal("StockMinimo"))
                            });
                        }
                    }
                }
                return lista;
            }
            catch (Exception ex) when (!(ex is DatosException))
            {
                throw new DatosException("Error al consultar los productos.", ex);
            }
        }
    }
}
