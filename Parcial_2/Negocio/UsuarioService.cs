using System.Collections.Generic;
using System.Linq;
using Parcial_2.Datos;
using Parcial_2.Entidades;

namespace Parcial_2.Negocio
{
    /// <summary>
    /// Reglas de negocio de usuarios. Para cambiar la contraseña usa únicamente el contrato
    /// <see cref="IHashService"/> (generar hash) antes de enviar el dato a la capa de Datos.
    /// </summary>
    public class UsuarioService : IUsuarioService
    {
        private const int LongitudMinima = 8;

        private readonly IUsuarioRepositorio _usuarios;
        private readonly IHashService _hash;

        /// <summary>Crea el servicio con sus dependencias (inyección por constructor).</summary>
        /// <param name="usuarios">Repositorio de usuarios.</param>
        /// <param name="hash">Servicio que genera el hash de contraseñas.</param>
        public UsuarioService(IUsuarioRepositorio usuarios, IHashService hash)
        {
            _usuarios = usuarios;
            _hash = hash;
        }

        /// <inheritdoc />
        public IList<Usuario> Listar()
        {
            try
            {
                return _usuarios.Listar();
            }
            catch (DatosException ex)
            {
                throw new NegocioException("No fue posible obtener la lista de usuarios.", ex);
            }
        }

        /// <inheritdoc />
        public void CambiarPassword(int idUsuario, string nuevaPassword, string confirmacion)
        {
            if (string.IsNullOrEmpty(nuevaPassword) || string.IsNullOrEmpty(confirmacion))
            {
                throw new NegocioException("Debe escribir la contraseña nueva y su confirmación.");
            }

            if (nuevaPassword != confirmacion)
            {
                throw new NegocioException("La contraseña nueva y su confirmación no coinciden.");
            }

            if (nuevaPassword.Length < LongitudMinima)
            {
                throw new NegocioException("La contraseña debe tener al menos " + LongitudMinima + " caracteres.");
            }

            if (!nuevaPassword.Any(char.IsLetter) || !nuevaPassword.Any(char.IsDigit))
            {
                throw new NegocioException("La contraseña debe combinar letras y números.");
            }

            string hash = _hash.GenerarHash(nuevaPassword);

            bool actualizado;
            try
            {
                actualizado = _usuarios.ActualizarPasswordHash(idUsuario, hash);
            }
            catch (DatosException ex)
            {
                throw new NegocioException("No fue posible actualizar la contraseña.", ex);
            }

            if (!actualizado)
            {
                throw new NegocioException("No se encontró un usuario activo para actualizar.");
            }
        }
    }
}
