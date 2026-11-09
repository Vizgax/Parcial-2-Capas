using System;
using System.Collections.Generic;
using Parcial_2.Entidades;

namespace Parcial_2.Vistas
{
    /// <summary>Contrato de la VISTA de la página del administrador (patrón MVP).</summary>
    public interface IAdminView
    {
        /// <summary>Se dispara cuando el formulario terminó de cargar.</summary>
        event EventHandler VistaCargada;

        /// <summary>Se dispara cuando se abre/refresca la sección de productos.</summary>
        event EventHandler ProductosSolicitados;

        /// <summary>Se dispara cuando se abre/refresca la sección de usuarios.</summary>
        event EventHandler UsuariosSolicitados;

        /// <summary>Muestra quién inició sesión (parte inferior del menú lateral).</summary>
        /// <param name="usuario">Usuario con la sesión activa.</param>
        void MostrarUsuarioSesion(Usuario usuario);

        /// <summary>Muestra los productos en la cuadrícula.</summary>
        /// <param name="productos">Lista de productos.</param>
        void MostrarProductos(IList<Producto> productos);

        /// <summary>Muestra los usuarios en la cuadrícula (sin hashes).</summary>
        /// <param name="usuarios">Lista de usuarios.</param>
        void MostrarUsuarios(IList<Usuario> usuarios);

        /// <summary>Muestra un mensaje informativo o de error.</summary>
        /// <param name="mensaje">Texto a mostrar.</param>
        /// <param name="esError">true si es un error.</param>
        void MostrarMensaje(string mensaje, bool esError);
    }
}
