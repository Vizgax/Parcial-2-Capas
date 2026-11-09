using System;
using System.Security.Cryptography;

namespace Parcial_2.Negocio
{
    /// <summary>
    /// Implementación de los dos contratos usando PBKDF2-HMAC-SHA256 (incluido en .NET Framework,
    /// sin paquetes externos). Cada hash lleva su propio salt aleatorio.
    /// Formato guardado: <c>iteraciones.saltBase64.hashBase64</c>.
    /// Si mañana se cambia a BCrypt/Argon2 solo se reemplaza esta clase; Vista, Presentador y BD no cambian.
    /// </summary>
    public class Pbkdf2PasswordService : IHashService, IVerificarHashService
    {
        private const int Iteraciones = 100000;
        private const int TamanoSalt = 16;
        private const int TamanoHash = 32;

        /// <inheritdoc />
        public string GenerarHash(string textoPlano)
        {
            if (textoPlano == null)
            {
                throw new ArgumentNullException("textoPlano");
            }

            byte[] salt = new byte[TamanoSalt];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            byte[] hash = Derivar(textoPlano, salt, Iteraciones, TamanoHash);

            return Iteraciones + "." + Convert.ToBase64String(salt) + "." + Convert.ToBase64String(hash);
        }

        /// <inheritdoc />
        public bool Verificar(string textoPlano, string hashAlmacenado)
        {
            if (string.IsNullOrEmpty(textoPlano) || string.IsNullOrEmpty(hashAlmacenado))
            {
                return false;
            }

            string[] partes = hashAlmacenado.Split('.');
            if (partes.Length != 3)
            {
                return false;
            }

            int iteraciones;
            if (!int.TryParse(partes[0], out iteraciones) || iteraciones < 1)
            {
                return false;
            }

            byte[] salt;
            byte[] esperado;
            try
            {
                salt = Convert.FromBase64String(partes[1]);
                esperado = Convert.FromBase64String(partes[2]);
            }
            catch (FormatException)
            {
                return false;
            }

            byte[] calculado = Derivar(textoPlano, salt, iteraciones, esperado.Length);
            return ComparacionTiempoConstante(calculado, esperado);
        }

        /// <summary>Deriva la clave con PBKDF2-HMAC-SHA256.</summary>
        private static byte[] Derivar(string texto, byte[] salt, int iteraciones, int longitud)
        {
            using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(texto, salt, iteraciones, HashAlgorithmName.SHA256))
            {
                return pbkdf2.GetBytes(longitud);
            }
        }

        /// <summary>
        /// Compara dos arreglos en tiempo constante para no revelar, por el tiempo de respuesta,
        /// en qué posición empiezan a diferir.
        /// </summary>
        private static bool ComparacionTiempoConstante(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            int diferencia = 0;
            for (int i = 0; i < a.Length; i++)
            {
                diferencia |= a[i] ^ b[i];
            }
            return diferencia == 0;
        }
    }
}
