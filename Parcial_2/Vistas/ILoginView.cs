using System;
using Parcial_2.Entidades;

namespace Parcial_2.Vistas
{
    /// <summary>
    /// Contrato de la VISTA de inicio de sesión (patrón MVP).
    /// El formulario solo muestra controles y avisa al Presentador; no conoce hashes ni la base de datos.
    /// </summary>
    public interface ILoginView
    {
        /// <summary>Se dispara cuando el usuario pulsa "Iniciar Sesión".</summary>
        event EventHandler IniciarSesion;

        /// <summary>Texto escrito en el campo de usuario.</summary>
        string NombreUsuario { get; }

        /// <summary>Texto escrito en el campo de contraseña (texto plano, solo en memoria).</summary>
        string Password { get; }

        /// <summary>Muestra un mensaje de validación o de error al usuario.</summary>
        /// <param name="mensaje">Texto a mostrar.</param>
        void MostrarMensaje(string mensaje);

        /// <summary>Borra el campo de contraseña y le devuelve el foco.</summary>
        void LimpiarPassword();

        /// <summary>Abre la página del administrador y cierra el login.</summary>
        /// <param name="usuario">Usuario que inició sesión.</param>
        void AbrirPaginaAdmin(Usuario usuario);

        /// <summary>Abre la página del usuario estándar y cierra el login.</summary>
        /// <param name="usuario">Usuario que inició sesión.</param>
        void AbrirPaginaUsuario(Usuario usuario);
    }
}
