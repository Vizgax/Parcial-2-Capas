using System.Collections.Generic;
using Parcial_2.Entidades;

namespace Parcial_2.Datos
{
    /// <summary>
    /// Contrato de acceso a datos para la tabla de usuarios.
    /// </summary>
    public interface IUsuarioRepositorio
    {
        /// <summary>Busca un usuario por su nombre de usuario (incluye el hash de la contraseña).</summary>
        /// <param name="nombreUsuario">Nombre de usuario a buscar.</param>
        /// <returns>El usuario encontrado o <c>null</c> si no existe.</returns>
        Usuario ObtenerPorNombre(string nombreUsuario);

        /// <summary>Lista todos los usuarios (sin el hash de la contraseña).</summary>
        IList<Usuario> Listar();

        /// <summary>Reemplaza el hash de la contraseña de un usuario.</summary>
        /// <param name="idUsuario">Identificador del usuario.</param>
        /// <param name="passwordHash">Nuevo hash ya calculado por la capa de Negocio.</param>
        /// <returns><c>true</c> si se actualizó el usuario.</returns>
        bool ActualizarPasswordHash(int idUsuario, string passwordHash);
    }
}
