using System.ComponentModel;

namespace Parcial_2.Entidades
{
    /// <summary>
    /// Entidad que representa un producto del inventario del almacén.
    /// </summary>
    public class Producto
    {
        /// <summary>Identificador único del producto (llave primaria).</summary>
        [Browsable(false)]
        public int IdProducto { get; set; }

        /// <summary>Código interno del producto (ej. HER-001).</summary>
        [DisplayName("Código")]
        public string Codigo { get; set; }

        /// <summary>Nombre descriptivo del producto.</summary>
        public string Nombre { get; set; }

        /// <summary>Nombre de la categoría a la que pertenece.</summary>
        [DisplayName("Categoría")]
        public string Categoria { get; set; }

        /// <summary>Nombre del proveedor que lo suministra.</summary>
        public string Proveedor { get; set; }

        /// <summary>Precio unitario.</summary>
        public decimal Precio { get; set; }

        /// <summary>Unidades disponibles en el almacén.</summary>
        public int Stock { get; set; }

        /// <summary>Cantidad mínima recomendada antes de reabastecer.</summary>
        [DisplayName("Stock mínimo")]
        public int StockMinimo { get; set; }
    }
}
