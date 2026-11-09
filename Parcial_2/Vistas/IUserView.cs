using System;
using System.Collections.Generic;
using Parcial_2.Entidades;

namespace Parcial_2.Vistas
{
    /// <summary>Contrato de la VISTA de la página del usuario estándar (patrón MVP).</summary>
    public interface IUserView
    {
        /// <summary>Se dispara cuando el formulario terminó de cargar.</summary>
        event EventHandler VistaCargada;

        /// <summary>Se dispara cuando se pide buscar/refrescar productos.</summary>
        event EventHandler BuscarProductos;

        /// <summary>Se dispara cuando se pulsa "Actualizar Contraseña".</summary>
        event EventHandler CambiarPassword;

        /// <summary>Texto escrito en el buscador de productos.</summary>
        string TextoBusqueda { get; }

        /// <summary>Contraseña nueva escrita por el usuario.</summary>
        string NuevaPassword { get; }

        /// <summary>Confirmación de la contraseña nueva.</summary>
        string ConfirmacionPassword { get; }

        /// <summary>Muestra quién inició sesión (parte inferior del menú lateral y perfil).</summary>
        /// <param name="usuario">Usuario con la sesión activa.</param>
        void MostrarUsuarioSesion(Usuario usuario);

        /// <summary>Muestra los productos en la cuadrícula.</summary>
        /// <param name="productos">Lista de productos a mostrar.</param>
        void MostrarProductos(IList<Producto> productos);

        /// <summary>Muestra un mensaje informativo o de error.</summary>
        /// <param name="mensaje">Texto a mostrar.</param>
        /// <param name="esError">true si es un error o validación fallida.</param>
        void MostrarMensaje(string mensaje, bool esError);

        /// <summary>Vacía los campos de contraseña y oculta el panel de cambio.</summary>
        void FinalizarCambioPassword();
    }
}
