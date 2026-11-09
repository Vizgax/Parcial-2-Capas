using System.Collections.Generic;
using Parcial_2.Datos;
using Parcial_2.Entidades;

namespace Parcial_2.Negocio
{
    /// <summary>Reglas de negocio para la consulta de productos del almacén.</summary>
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepositorio _productos;

        /// <summary>Crea el servicio con su repositorio (inyección por constructor).</summary>
        /// <param name="productos">Repositorio de productos.</param>
        public ProductoService(IProductoRepositorio productos)
        {
            _productos = productos;
        }

        /// <inheritdoc />
        public IList<Producto> Listar()
        {
            try
            {
                return _productos.Listar();
            }
            catch (DatosException ex)
            {
                throw new NegocioException("No fue posible obtener los productos.", ex);
            }
        }

        /// <inheritdoc />
        public IList<Producto> Buscar(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return Listar();
            }

            try
            {
                return _productos.BuscarPorNombre(texto.Trim());
            }
            catch (DatosException ex)
            {
                throw new NegocioException("No fue posible buscar los productos.", ex);
            }
        }
    }
}
