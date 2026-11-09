using System;

namespace Parcial_2.Negocio
{
    /// <summary>
    /// Error de la capa de Negocio con un mensaje apto para mostrarse al usuario
    /// (validaciones incumplidas o fallas de acceso a datos ya "traducidas").
    /// </summary>
    public class NegocioException : Exception
    {
        /// <summary>Crea la excepción con un mensaje para el usuario.</summary>
        /// <param name="mensaje">Mensaje amigable.</param>
        public NegocioException(string mensaje)
            : base(mensaje)
        {
        }

        /// <summary>Crea la excepción con un mensaje y la causa técnica original.</summary>
        /// <param name="mensaje">Mensaje amigable.</param>
        /// <param name="causa">Excepción original.</param>
        public NegocioException(string mensaje, Exception causa)
            : base(mensaje, causa)
        {
        }
    }
}
