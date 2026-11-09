using System.Collections.Generic;
using Parcial_2.Entidades;

namespace Parcial_2.Negocio
{
    /// <summary>Contrato de las operaciones de negocio sobre productos.</summary>
    public interface IProductoService
    {
        /// <summary>Lista todos los productos activos.</summary>
        /// <exception cref="NegocioException">Si falla el acceso a datos.</exception>
        IList<Producto> Listar();

        /// <summary>Busca productos por nombre; si el texto está vacío devuelve todos.</summary>
        /// <param name="texto">Texto a buscar dentro del nombre.</param>
        /// <exception cref="NegocioException">Si falla el acceso a datos.</exception>
        IList<Producto> Buscar(string texto);
    }
}
