using System;
using System.Windows.Forms;
using Parcial_2.Entidades;
using Parcial_2.Presentadores;
using Parcial_2.Vistas;

namespace Parcial_2
{
    /// <summary>
    /// VISTA de inicio de sesión (patrón MVP). Solo muestra los controles y avisa al
    /// <see cref="LoginPresenter"/>; no conoce el algoritmo de hash ni toca la base de datos.
    /// </summary>
    public partial class FR_Login : Form, ILoginView
    {
        /// <inheritdoc />
        public event EventHandler IniciarSesion;

        /// <summary>Inicializa el formulario y conecta su Presentador.</summary>
        public FR_Login()
        {
            InitializeComponent();

            AcceptButton = BTN_Log;      // Enter = Iniciar Sesión
            TB_user.MaxLength = 50;
            TB_pass.MaxLength = 100;

            // El Presentador se suscribe a los eventos de esta Vista; no hace falta guardarlo.
            Composicion.CrearLoginPresenter(this);
        }

        /// <inheritdoc />
        public string NombreUsuario
        {
            get { return TB_user.Text; }
        }

        /// <inheritdoc />
        public string Password
        {
            get { return TB_pass.Text; }
        }

        /// <inheritdoc />
        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(this, mensaje, "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <inheritdoc />
        public void LimpiarPassword()
        {
            TB_pass.Clear();
            TB_pass.Focus();
        }

        /// <inheritdoc />
        public void AbrirPaginaAdmin(Usuario usuario)
        {
            AbrirYOcultar(new FR_Admin(usuario));
        }

        /// <inheritdoc />
        public void AbrirPaginaUsuario(Usuario usuario)
        {
            AbrirYOcultar(new FR_User(usuario));
        }

        /// <summary>Muestra la página principal, oculta el login y cierra la aplicación cuando ella se cierre.</summary>
        private void AbrirYOcultar(Form principal)
        {
            TB_pass.Clear();
            TB_user.Clear();
            principal.FormClosed += (s, e) => Application.Exit();
            Hide();
            principal.Show();
        }

        private void CB_pass_CheckedChanged(object sender, EventArgs e)
        {
            TB_pass.UseSystemPasswordChar = !CB_pass.Checked;
        }

        private void BTN_Log_Click(object sender, EventArgs e)
        {
            IniciarSesion?.Invoke(this, EventArgs.Empty);
        }
    }
}
