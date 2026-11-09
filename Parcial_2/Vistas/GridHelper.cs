using System.Drawing;
using System.Windows.Forms;
using Parcial_2.Entidades;

namespace Parcial_2.Vistas
{
    /// <summary>
    /// Utilidades de presentación (solo apariencia) para las cuadrículas DataGridView.
    /// No contiene lógica de negocio ni acceso a datos.
    /// </summary>
    internal static class GridHelper
    {
        /// <summary>Aplica una configuración de solo lectura y estilo uniforme a una cuadrícula.</summary>
        /// <param name="grid">Cuadrícula a configurar.</param>
        public static void Configurar(DataGridView grid)
        {
            grid.AutoGenerateColumns = true;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.RowHeadersVisible = false;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.BackgroundColor = SystemColors.Window;
            grid.BorderStyle = BorderStyle.FixedSingle;
        }

        /// <summary>Oculta las columnas indicadas (si existen).</summary>
        /// <param name="grid">Cuadrícula ya enlazada a datos.</param>
        /// <param name="columnas">Nombres de las propiedades/columnas a ocultar.</param>
        public static void Ocultar(DataGridView grid, params string[] columnas)
        {
            foreach (string nombre in columnas)
            {
                DataGridViewColumn col = grid.Columns[nombre];
                if (col != null)
                {
                    col.Visible = false;
                }
            }
        }

        /// <summary>Da formato a las columnas de productos (precio en moneda, nombre más ancho).</summary>
        /// <param name="grid">Cuadrícula de productos ya enlazada.</param>
        public static void FormatearProductos(DataGridView grid)
        {
            Ocultar(grid, "IdProducto");

            if (grid.Columns["Precio"] != null)
            {
                grid.Columns["Precio"].DefaultCellStyle.Format = "C2";
                grid.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (grid.Columns["Nombre"] != null)
            {
                grid.Columns["Nombre"].FillWeight = 190;
            }
        }

        /// <summary>
        /// Resalta en rojo claro las filas de productos cuyo stock es menor o igual al stock mínimo.
        /// Se registra una sola vez por cuadrícula.
        /// </summary>
        /// <param name="grid">Cuadrícula de productos.</param>
        public static void ResaltarStockBajo(DataGridView grid)
        {
            grid.CellFormatting += (sender, e) =>
            {
                if (e.RowIndex < 0 || e.RowIndex >= grid.Rows.Count)
                {
                    return;
                }

                Producto p = grid.Rows[e.RowIndex].DataBoundItem as Producto;
                if (p != null && p.Stock <= p.StockMinimo)
                {
                    e.CellStyle.BackColor = Color.MistyRose;
                    e.CellStyle.ForeColor = Color.DarkRed;
                }
            };
        }
    }
}
