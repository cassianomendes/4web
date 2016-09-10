using System;
using System.Security.Cryptography;

namespace FourWeb.Infrastructure.Helpers
{
    public static class StringHelper
    {
        public static string Encrypt(string value)
        {
            if (string.IsNullOrEmpty(value))
                return "";

            value += "|54be1d80-b6d0-45c0-b8d7-13b3c798729f";

            // Cria uma nova instância do provedor de serviços de criptografia hash
            var hashAlgorithm = SHA512.Create();
            
            // Converte os dados para o hash para um array de bytes
            byte[] byteValue = System.Text.Encoding.UTF8.GetBytes(value);

            // Calcula o hash. Esse processo retorna um array de bytes
            byte[] byteHash = hashAlgorithm.ComputeHash(byteValue);

            return Convert.ToBase64String(byteHash);
        }
    }
}
