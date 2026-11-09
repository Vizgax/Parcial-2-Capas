using System;
using System.ComponentModel;

namespace Parcial_2.Entidades
{
    /// <summary>
    /// Entidad que representa a un usuario del sistema de almacén.
    /// Es una clase "pura": solo contiene datos, sin lógica de negocio ni acceso a BD.
    /// </summary>
    public class Usuario
    {
        /// <summary>Identificador único del usuario (llave primaria).</summary>
        [Browsable(false)]
        public int IdUsuario { get; set; }

        /// <summary>Nombre de usuario con el que se inicia sesión.</summary>
        [DisplayName("Usuario")]
        public string NombreUsuario { get; set; }

        /// <summary>Nombre completo de la persona.</summary>
        [DisplayName("Nombre completo")]
        public string NombreCompleto { get; set; }

        /// <summary>Nombre del rol asignado ("Admin" o "Usuario").</summary>
        [DisplayName("Rol")]
        public string Rol { get; set; }

        /// <summary>Indica si la cuenta está habilitada para iniciar sesión.</summary>
        public bool Activo { get; set; }

        /// <summary>Fecha en que se creó la cuenta.</summary>
        [DisplayName("Fecha de creación")]
        public DateTime FechaCreacion { get; set; }

        /// <summary>
        /// Hash de la contraseña (nunca el texto plano). Solo se carga al iniciar sesión
        /// y no se muestra en ninguna cuadrícula.
        /// </summary>
        [Browsable(false)]
        public string PasswordHash { get; set; }

        /// <summary>Devuelve true si el usuario tiene el rol de administrador.</summary>
        [Browsable(false)]
        public bool EsAdministrador
        {
            get { return string.Equals(Rol, "Admin", StringComparison.OrdinalIgnoreCase); }
        }
    }
}
