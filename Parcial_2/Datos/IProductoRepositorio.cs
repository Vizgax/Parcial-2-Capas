using System.Collections.Generic;
using Parcial_2.Entidades;

namespace Parcial_2.Datos
{
    /// <summary>
    /// Contrato de acceso a datos para los productos del almacén.
    /// </summary>
    public interface IProductoRepositorio
    {
        /// <summary>Devuelve todos los productos activos.</summary>
        IList<Producto> Listar();

        /// <summary>Devuelve los productos activos cuyo nombre contiene el texto indicado.</summary>
        /// <param name="nombre">Texto a buscar dentro del nombre del producto.</param>
        IList<Producto> BuscarPorNombre(string nombre);
    }
}
