using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Parcial_2.Entidades;
using Parcial_2.Presentadores;
using Parcial_2.Vistas;

namespace Parcial_2
{
    /// <summary>
    /// VISTA de la página del usuario estándar (patrón MVP): menú lateral con Productos y Usuario,
    /// hora actual y, en la parte inferior del menú, el usuario que inició sesión.
    /// </summary>
    public partial class FR_User : Form, IUserView
    {
        /// <inheritdoc />
        public event EventHandler VistaCargada;

        /// <inheritdoc />
        public event EventHandler BuscarProductos;

        /// <inheritdoc />
        public event EventHandler CambiarPassword;

        /// <summary>Constructor sin parámetros: lo necesita el diseñador de Visual Studio.</summary>
        public FR_User()
        {
            InitializeComponent();
            GridHelper.Configurar(DGV_Product);
            GridHelper.ResaltarStockBajo(DGV_Product);
        }

        /// <summary>Crea la página para el usuario que inició sesión y conecta su Presentador.</summary>
        /// <param name="usuario">Usuario con la sesión activa.</param>
        public FR_User(Usuario usuario)
            : this()
        {
            // El Presentador se suscribe a los eventos de esta Vista; no hace falta guardarlo.
            Composicion.CrearUserPresenter(this, usuario);
        }

        /// <inheritdoc />
        public string TextoBusqueda
        {
            get { return TB_Item.Text; }
        }

        /// <inheritdoc />
        public string NuevaPassword
        {
            get { return TB_NuevaPass.Text; }
        }

        /// <inheritdoc />
        public string ConfirmacionPassword
        {
            get { return TB_ConfirmaPass.Text; }
        }

        /// <inheritdoc />
        public void MostrarUsuarioSesion(Usuario usuario)
        {
            LB_User.Text = usuario.NombreCompleto;       // parte inferior del menú lateral
            LB_Usuario.Text = usuario.NombreCompleto;    // panel "Usuario"
            LB_Pass.Text = "********";                   // la contraseña nunca se muestra
            Text = "Página Usuario - " + usuario.NombreUsuario;
        }

        /// <inheritdoc />
        public void MostrarProductos(IList<Producto> productos)
        {
            DGV_Product.DataSource = productos;
            GridHelper.FormatearProductos(DGV_Product);
            GridHelper.Ocultar(DGV_Product, "Proveedor");
        }

        /// <inheritdoc />
        public void MostrarMensaje(string mensaje, bool esError)
        {
            MessageBox.Show(this, mensaje, "Almacén", MessageBoxButtons.OK,
                esError ? MessageBoxIcon.Warning : MessageBoxIcon.Information);
        }

        /// <inheritdoc />
        public void FinalizarCambioPassword()
        {
            TB_NuevaPass.Clear();
            TB_ConfirmaPass.Clear();
            PN_Cambio.Visible = false;
            BTN_Cambio_Pass.Visible = true;
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            LB_Time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void FR_User_Load(object sender, EventArgs e)
        {
            PN_Inicio.Visible = false;
            PN_User.Visible = false;
            PN_Cambio.Visible = false;

            LB_Time.Text = DateTime.Now.ToString("hh:mm:ss tt");
            VistaCargada?.Invoke(this, EventArgs.Empty);
        }

        private void BTN_Product_Click(object sender, EventArgs e)
        {
            PN_User.Visible = false;
            PN_Inicio.Visible = true;
            BuscarProductos?.Invoke(this, EventArgs.Empty);   // refresca el stock al entrar
        }

        private void BTN_User_Click(object sender, EventArgs e)
        {
            PN_Inicio.Visible = false;
            PN_User.Visible = true;
        }

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            BuscarProductos?.Invoke(this, EventArgs.Empty);
        }

        private void TB_Item_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BuscarProductos?.Invoke(this, EventArgs.Empty);
            }
        }

        private void BTN_Cambio_Pass_Click(object sender, EventArgs e)
        {
            BTN_Cambio_Pass.Visible = false;
            PN_Cambio.Visible = true;
            TB_NuevaPass.Focus();
        }

        private void BTN_Actualizar_Click(object sender, EventArgs e)
        {
            CambiarPassword?.Invoke(this, EventArgs.Empty);
        }
    }
}
