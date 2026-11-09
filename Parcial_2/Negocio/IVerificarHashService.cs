namespace Parcial_2.Negocio
{
    /// <summary>
    /// CONTRATO #2 - Única responsabilidad: VERIFICAR si una contraseña en texto plano
    /// coincide con el hash almacenado. Se usa cuando el usuario inicia sesión.
    /// </summary>
    public interface IVerificarHashService
    {
        /// <summary>Comprueba si el texto plano corresponde al hash guardado.</summary>
        /// <param name="textoPlano">Contraseña escrita por el usuario.</param>
        /// <param name="hashAlmacenado">Hash guardado en la base de datos.</param>
        /// <returns><c>true</c> si coinciden; de lo contrario <c>false</c>.</returns>
        bool Verificar(string textoPlano, string hashAlmacenado);
    }
}
