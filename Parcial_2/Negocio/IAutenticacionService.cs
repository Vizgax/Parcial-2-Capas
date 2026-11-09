using Parcial_2.Entidades;

namespace Parcial_2.Negocio
{
    /// <summary>Contrato del servicio de inicio de sesión.</summary>
    public interface IAutenticacionService
    {
        /// <summary>Valida las credenciales de un usuario.</summary>
        /// <param name="nombreUsuario">Nombre de usuario escrito en el login.</param>
        /// <param name="password">Contraseña en texto plano escrita en el login.</param>
        /// <returns>El usuario autenticado, o <c>null</c> si las credenciales no son válidas.</returns>
        /// <exception cref="NegocioException">Si no se puede consultar la base de datos.</exception>
        Usuario Autenticar(string nombreUsuario, string password);
    }
}
