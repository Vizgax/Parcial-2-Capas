using Parcial_2.Datos;
using Parcial_2.Entidades;

namespace Parcial_2.Negocio
{
    /// <summary>
    /// Regla de negocio del inicio de sesión: busca al usuario y verifica la contraseña
    /// usando únicamente el contrato <see cref="IVerificarHashService"/>.
    /// </summary>
    public class AutenticacionService : IAutenticacionService
    {
        private readonly IUsuarioRepositorio _usuarios;
        private readonly IVerificarHashService _verificador;

        /// <summary>Crea el servicio con sus dependencias (inyección por constructor).</summary>
        /// <param name="usuarios">Repositorio de usuarios.</param>
        /// <param name="verificador">Servicio que compara texto plano contra hash.</param>
        public AutenticacionService(IUsuarioRepositorio usuarios, IVerificarHashService verificador)
        {
            _usuarios = usuarios;
            _verificador = verificador;
        }

        /// <inheritdoc />
        public Usuario Autenticar(string nombreUsuario, string password)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrEmpty(password))
            {
                return null;
            }

            Usuario usuario;
            try
            {
                usuario = _usuarios.ObtenerPorNombre(nombreUsuario.Trim());
            }
            catch (DatosException ex)
            {
                throw new NegocioException(
                    "No fue posible conectar con la base de datos. Verifique que SQL Server esté en ejecución y la configuración de App.config.", ex);
            }

            // Mismo resultado (null) si no existe, está inactivo o la contraseña no coincide:
            // así no se revela cuál de los datos fue el incorrecto.
            if (usuario == null || !usuario.Activo)
            {
                return null;
            }

            if (!_verificador.Verificar(password, usuario.PasswordHash))
            {
                return null;
            }

            // El hash ya cumplió su función; no se conserva en la sesión.
            usuario.PasswordHash = null;
            return usuario;
        }
    }
}
