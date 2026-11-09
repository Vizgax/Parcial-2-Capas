using System.Configuration;
using System.Data.SqlClient;

namespace Parcial_2.Datos
{
    /// <summary>
    /// Punto único de creación de conexiones a SQL Server.
    /// Lee la cadena "AlmacenDB" de App.config, que usa el login <c>almacen_app</c>
    /// (privilegios mínimos: solo EXECUTE sobre los procedimientos almacenados necesarios).
    /// </summary>
    public static class ConexionBD
    {
        private const string NombreCadena = "AlmacenDB";

        /// <summary>
        /// Crea una conexión nueva (sin abrir). Quien la use debe abrirla y liberarla con <c>using</c>.
        /// </summary>
        /// <returns>Un <see cref="SqlConnection"/> configurado con la cadena de App.config.</returns>
        /// <exception cref="DatosException">Si la cadena de conexión no existe en App.config.</exception>
        public static SqlConnection Crear()
        {
            ConnectionStringSettings cfg = ConfigurationManager.ConnectionStrings[NombreCadena];

            if (cfg == null || string.IsNullOrWhiteSpace(cfg.ConnectionString))
            {
                throw new DatosException(
                    "No se encontró la cadena de conexión '" + NombreCadena + "' en App.config.");
            }

            return new SqlConnection(cfg.ConnectionString);
        }
    }
}
