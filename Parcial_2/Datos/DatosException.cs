using System;

namespace Parcial_2.Datos
{
    /// <summary>
    /// Excepción propia de la capa de Datos. Oculta los detalles técnicos de SQL Server
    /// (mensajes de SqlException) para que las capas superiores no dependan de System.Data.SqlClient.
    /// </summary>
    public class DatosException : Exception
    {
        /// <summary>Crea la excepción con un mensaje y la causa original.</summary>
        /// <param name="mensaje">Mensaje descriptivo del problema.</param>
        /// <param name="causa">Excepción original lanzada por el proveedor de datos.</param>
        public DatosException(string mensaje, Exception causa)
            : base(mensaje, causa)
        {
        }

        /// <summary>Crea la excepción solo con un mensaje.</summary>
        /// <param name="mensaje">Mensaje descriptivo del problema.</param>
        public DatosException(string mensaje)
            : base(mensaje)
        {
        }
    }
}
