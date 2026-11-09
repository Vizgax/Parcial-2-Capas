using System;
using Parcial_2.Entidades;
using Parcial_2.Negocio;
using Parcial_2.Vistas;

namespace Parcial_2.Presentadores
{
    /// <summary>
    /// PRESENTADOR de la página del usuario estándar: carga el perfil, consulta/busca productos
    /// y gestiona el cambio de contraseña, siempre a través de la capa de Negocio.
    /// </summary>
    public class UserPresenter
    {
        private readonly IUserView _vista;
        private readonly Usuario _sesion;
        private readonly IProductoService _productos;
        private readonly IUsuarioService _usuarios;

        /// <summary>Crea el presentador y se suscribe a los eventos de la Vista.</summary>
        /// <param name="vista">Vista de la página de usuario.</param>
        /// <param name="sesion">Usuario que inició sesión.</param>
        /// <param name="productos">Servicio de productos.</param>
        /// <param name="usuarios">Servicio de usuarios.</param>
        public UserPresenter(IUserView vista, Usuario sesion, IProductoService productos, IUsuarioService usuarios)
        {
            _vista = vista;
            _sesion = sesion;
            _productos = productos;
            _usuarios = usuarios;

            _vista.VistaCargada += AlCargarVista;
            _vista.BuscarProductos += AlBuscarProductos;
            _vista.CambiarPassword += AlCambiarPassword;
        }

        private void AlCargarVista(object sender, EventArgs e)
        {
            _vista.MostrarUsuarioSesion(_sesion);
            CargarProductos();
        }

        private void AlBuscarProductos(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            try
            {
                _vista.MostrarProductos(_productos.Buscar(_vista.TextoBusqueda));
            }
            catch (NegocioException ex)
            {
                _vista.MostrarMensaje(ex.Message, true);
            }
        }

        private void AlCambiarPassword(object sender, EventArgs e)
        {
            try
            {
                _usuarios.CambiarPassword(_sesion.IdUsuario, _vista.NuevaPassword, _vista.ConfirmacionPassword);
                _vista.FinalizarCambioPassword();
                _vista.MostrarMensaje("La contraseña se actualizó correctamente.", false);
            }
            catch (NegocioException ex)
            {
                _vista.MostrarMensaje(ex.Message, true);
            }
        }
    }
}
