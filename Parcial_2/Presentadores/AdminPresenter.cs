using System;
using Parcial_2.Entidades;
using Parcial_2.Negocio;
using Parcial_2.Vistas;

namespace Parcial_2.Presentadores
{
    /// <summary>
    /// PRESENTADOR de la página del administrador: muestra al usuario de la sesión y
    /// carga las listas de productos y de usuarios mediante la capa de Negocio.
    /// </summary>
    public class AdminPresenter
    {
        private readonly IAdminView _vista;
        private readonly Usuario _sesion;
        private readonly IProductoService _productos;
        private readonly IUsuarioService _usuarios;

        /// <summary>Crea el presentador y se suscribe a los eventos de la Vista.</summary>
        /// <param name="vista">Vista de la página de administrador.</param>
        /// <param name="sesion">Usuario (administrador) que inició sesión.</param>
        /// <param name="productos">Servicio de productos.</param>
        /// <param name="usuarios">Servicio de usuarios.</param>
        public AdminPresenter(IAdminView vista, Usuario sesion, IProductoService productos, IUsuarioService usuarios)
        {
            _vista = vista;
            _sesion = sesion;
            _productos = productos;
            _usuarios = usuarios;

            _vista.VistaCargada += AlCargarVista;
            _vista.ProductosSolicitados += AlSolicitarProductos;
            _vista.UsuariosSolicitados += AlSolicitarUsuarios;
        }

        private void AlCargarVista(object sender, EventArgs e)
        {
            _vista.MostrarUsuarioSesion(_sesion);
        }

        private void AlSolicitarProductos(object sender, EventArgs e)
        {
            try
            {
                _vista.MostrarProductos(_productos.Listar());
            }
            catch (NegocioException ex)
            {
                _vista.MostrarMensaje(ex.Message, true);
            }
        }

        private void AlSolicitarUsuarios(object sender, EventArgs e)
        {
            try
            {
                _vista.MostrarUsuarios(_usuarios.Listar());
            }
            catch (NegocioException ex)
            {
                _vista.MostrarMensaje(ex.Message, true);
            }
        }
    }
}
