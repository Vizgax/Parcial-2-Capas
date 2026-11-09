using System.Collections.Generic;
using Parcial_2.Entidades;

namespace Parcial_2.Negocio
{
    /// <summary>Contrato de las operaciones de negocio sobre usuarios.</summary>
    public interface IUsuarioService
    {
        /// <summary>Lista los usuarios del sistema.</summary>
        /// <exception cref="NegocioException">Si falla el acceso a datos.</exception>
        IList<Usuario> Listar();

        /// <summary>Valida y cambia la contraseña de un usuario.</summary>
        /// <param name="idUsuario">Usuario al que se le cambia la contraseña.</param>
        /// <param name="nuevaPassword">Contraseña nueva en texto plano.</param>
        /// <param name="confirmacion">Repetición de la contraseña nueva.</param>
        /// <exception cref="NegocioException">Si no cumple las reglas o falla el acceso a datos.</exception>
        void CambiarPassword(int idUsuario, string nuevaPassword, string confirmacion);
    }
}
