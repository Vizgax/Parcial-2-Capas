using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Parcial_2.Entidades;
using Parcial_2.Presentadores;
using Parcial_2.Vistas;

namespace Parcial_2
{
    /// <summary>
    /// VISTA de la página del administrador (patrón MVP): menú lateral con Productos y Usuarios,
    /// hora actual y, en la parte inferior del menú, el usuario que inició sesión.
    /// </summary>
    public partial class FR_Admin : Form, IAdminView
    {
        /// <inheritdoc />
        public event EventHandler VistaCargada;

        /// <inheritdoc />
        public event EventHandler ProductosSolicitados;

        /// <inheritdoc />
        public event EventHandler UsuariosSolicitados;

        /// <summary>Constructor sin parámetros: lo necesita el diseñador de Visual Studio.</summary>
        public FR_Admin()
        {
            InitializeComponent();
            GridHelper.Configurar(DGV_Product);
            GridHelper.Configurar(DGV_Users);
            GridHelper.ResaltarStockBajo(DGV_Product);
        }

        /// <summary>Crea la página para el administrador que inició sesión y conecta su Presentador.</summary>
        /// <param name="usuario">Usuario con la sesión activa.</param>
        public FR_Admin(Usuario usuario)
            : this()
        {
            // El Presentador se suscribe a los eventos de esta Vista; no hace falta guardarlo.
            Composicion.CrearAdminPresenter(this, usuario);
        }

        /// <inheritdoc />
        public void MostrarUsuarioSesion(Usuario usuario)
        {
            LB_User.Text = usuario.NombreCompleto;       // parte inferior del menú lateral
            Text = "Página Admin - " + usuario.NombreUsuario;
        }

        /// <inheritdoc />
        public void MostrarProductos(IList<Producto> productos)
        {
            DGV_Product.DataSource = productos;
            GridHelper.FormatearProductos(DGV_Product);
        }

        /// <inheritdoc />
        public void MostrarUsuarios(IList<Usuario> usuarios)
        {
            DGV_Users.DataSource = usuarios;
            GridHelper.Ocultar(DGV_Users, "IdUsuario", "PasswordHash", "EsAdministrador");

            if (DGV_Users.Columns["FechaCreacion"] != null)
            {
                DGV_Users.Columns["FechaCreacion"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        /// <inheritdoc />
        public void MostrarMensaje(string mensaje, bool esError)
        {
            MessageBox.Show(this, mensaje, "Almacén", MessageBoxButtons.OK,
                esError ? MessageBoxIcon.Warning : MessageBoxIcon.Information);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LB_Time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void FR_Admin_Load(object sender, EventArgs e)
        {
            PN_Inicio.Visible = false;
            PN_User.Visible = false;

            LB_Time.Text = DateTime.Now.ToString("hh:mm:ss tt");
            VistaCargada?.Invoke(this, EventArgs.Empty);
        }

        private void BTN_Product_Click(object sender, EventArgs e)
        {
            PN_User.Visible = false;
            PN_Inicio.Visible = true;
            ProductosSolicitados?.Invoke(this, EventArgs.Empty);
        }

        private void BTN_User_Click(object sender, EventArgs e)
        {
            PN_Inicio.Visible = false;
            PN_User.Visible = true;
            UsuariosSolicitados?.Invoke(this, EventArgs.Empty);
        }
    }
}
