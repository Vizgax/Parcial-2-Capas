namespace Parcial_2.Negocio
{
    /// <summary>
    /// CONTRATO #1 - Única responsabilidad: GENERAR el hash de una contraseña.
    /// Se usa cuando el usuario cambia su contraseña (o al registrarla).
    /// </summary>
    public interface IHashService
    {
        /// <summary>Genera el hash (con salt aleatorio incluido) de un texto plano.</summary>
        /// <param name="textoPlano">Contraseña en texto plano.</param>
        /// <returns>Cadena lista para guardar en la columna PasswordHash.</returns>
        string GenerarHash(string textoPlano);
    }
}
