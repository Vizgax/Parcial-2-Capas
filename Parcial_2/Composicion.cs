using Parcial_2.Datos;
using Parcial_2.Entidades;
using Parcial_2.Negocio;
using Parcial_2.Presentadores;
using Parcial_2.Vistas;

namespace Parcial_2
{
    /// <summary>
    /// "Raíz de composición": único lugar donde se eligen las implementaciones concretas
    /// (repositorios, servicio de hash) y se arman los Presentadores.
    /// Así las Vistas no crean ni conocen repositorios ni algoritmos de hash.
    /// </summary>
    internal static class Composicion
    {
        // Una sola clase implementa los DOS contratos independientes; cada servicio de negocio
        // recibe únicamente el contrato que necesita.
        private static readonly Pbkdf2PasswordService ServicioPassword = new Pbkdf2PasswordService();

        /// <summary>Arma el presentador del login con sus dependencias.</summary>
        /// <param name="vista">Vista de login.</param>
        public static LoginPresenter CrearLoginPresenter(ILoginView vista)
        {
            IVerificarHashService verificador = ServicioPassword;
            IAutenticacionService autenticacion = new AutenticacionService(new UsuarioRepositorio(), verificador);
            return new LoginPresenter(vista, autenticacion);
        }

        /// <summary>Arma el presentador de la página de usuario.</summary>
        /// <param name="vista">Vista de usuario.</param>
        /// <param name="sesion">Usuario con la sesión activa.</param>
        public static UserPresenter CrearUserPresenter(IUserView vista, Usuario sesion)
        {
            return new UserPresenter(vista, sesion, CrearProductoService(), CrearUsuarioService());
        }

        /// <summary>Arma el presentador de la página de administrador.</summary>
        /// <param name="vista">Vista de administrador.</param>
        /// <param name="sesion">Usuario con la sesión activa.</param>
        public static AdminPresenter CrearAdminPresenter(IAdminView vista, Usuario sesion)
        {
            return new AdminPresenter(vista, sesion, CrearProductoService(), CrearUsuarioService());
        }

        private static IProductoService CrearProductoService()
        {
            return new ProductoService(new ProductoRepositorio());
        }

        private static IUsuarioService CrearUsuarioService()
        {
            IHashService generador = ServicioPassword;
            return new UsuarioService(new UsuarioRepositorio(), generador);
        }
    }
}
