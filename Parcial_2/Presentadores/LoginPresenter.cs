using System;
using Parcial_2.Entidades;
using Parcial_2.Negocio;
using Parcial_2.Vistas;

namespace Parcial_2.Presentadores
{
    /// <summary>
    /// PRESENTADOR del login: recibe la acción de la Vista, valida los campos, le pide a la capa
    /// de Negocio que autentique y le devuelve el resultado a la Vista.
    /// </summary>
    public class LoginPresenter
    {
        private readonly ILoginView _vista;
        private readonly IAutenticacionService _autenticacion;

        /// <summary>Crea el presentador y se suscribe a los eventos de la Vista.</summary>
        /// <param name="vista">Vista de login.</param>
        /// <param name="autenticacion">Servicio de negocio que valida credenciales.</param>
        public LoginPresenter(ILoginView vista, IAutenticacionService autenticacion)
        {
            _vista = vista;
            _autenticacion = autenticacion;
            _vista.IniciarSesion += AlIniciarSesion;
        }

        private void AlIniciarSesion(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_vista.NombreUsuario))
            {
                _vista.MostrarMensaje("Escriba su nombre de usuario.");
                return;
            }

            if (string.IsNullOrEmpty(_vista.Password))
            {
                _vista.MostrarMensaje("Escriba su contraseña.");
                return;
            }

            try
            {
                Usuario usuario = _autenticacion.Autenticar(_vista.NombreUsuario, _vista.Password);

                if (usuario == null)
                {
                    _vista.MostrarMensaje("Usuario o contraseña incorrectos.");
                    _vista.LimpiarPassword();
                    return;
                }

                if (usuario.EsAdministrador)
                {
                    _vista.AbrirPaginaAdmin(usuario);
                }
                else
                {
                    _vista.AbrirPaginaUsuario(usuario);
                }
            }
            catch (NegocioException ex)
            {
#if DEBUG
                Exception causa = ex;
                while (causa.InnerException != null) causa = causa.InnerException;
                _vista.MostrarMensaje(ex.Message + "\n\nDetalle técnico:\n" + causa.Message);
#else
    _vista.MostrarMensaje(ex.Message);
#endif
            }
        }
    }
}
