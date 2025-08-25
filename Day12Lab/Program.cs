using System.Security.Cryptography;
using System.Text;

namespace Day12Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             	Implementing Symmetric Encryption
	            Implementing Asymmetric Encryption

                Implementing Symmetric Encryption
                ----------------------------
                uses the same key for both encryption and decryption. In C#, the System.Security.
                Cryptography namespace provides classes to perform symmetric encryption and decryption.

                Here's an example using the Aes class for symmetric encryption and decryption:

             */
            Console.WriteLine("Hello, World!");

            string original = "Sayed Hawas";

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = GenerateRandomKey();
                aesAlg.IV = GenerateRandomIV();

                byte[] encrypted = EncryptStringToBytes_Aes(original, aesAlg.Key, aesAlg.IV);
                string decrypted = DecryptStringFromBytes_Aes(encrypted, aesAlg.Key, aesAlg.IV);

                Console.WriteLine("Original:   {0}", original);
                Console.WriteLine("Encrypted:  {0}", Convert.ToBase64String(encrypted));
                Console.WriteLine("Decrypted:  {0}", decrypted);
            }
            string original1 = "Sensitive data that needs encryption";
            using (RSA rsa = RSA.Create())
            {
                // Generate public and private keys
                RSAParameters publicKey = rsa.ExportParameters(false);
                RSAParameters privateKey = rsa.ExportParameters(true);

                byte[] encrypted = EncryptData(Encoding.UTF8.GetBytes(original1), publicKey);
                string decrypted = Encoding.UTF8.GetString(DecryptData(encrypted, privateKey));

                Console.WriteLine("Original:   {0}", original1);
                Console.WriteLine("Encrypted:  {0}", Convert.ToBase64String(encrypted));
                Console.WriteLine("Decrypted:  {0}", decrypted);
            }


            Console.ReadLine();

        }

        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException(nameof(plainText));
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException(nameof(Key));
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException(nameof(IV));

            byte[] encrypted;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return encrypted;
        }

        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException(nameof(cipherText));
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException(nameof(Key));
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException(nameof(IV));

            string plaintext = null;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

        static byte[] GenerateRandomKey()
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.GenerateKey();
                return aesAlg.Key;
            }
        }

        static byte[] GenerateRandomIV()
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.GenerateIV();
                return aesAlg.IV;
            }
        }


        static byte[] EncryptData(byte[] data, RSAParameters publicKey)
        {
            using (RSA rsa = RSA.Create())
            {
                rsa.ImportParameters(publicKey);
                return rsa.Encrypt(data, RSAEncryptionPadding.OaepSHA256);
            }
        }

        static byte[] DecryptData(byte[] data, RSAParameters privateKey)
        {
            using (RSA rsa = RSA.Create())
            {
                rsa.ImportParameters(privateKey);
                return rsa.Decrypt(data, RSAEncryptionPadding.OaepSHA256);
            }
        }
    }
}
