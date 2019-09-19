using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Web.Hosting;

namespace HomeStayWCF.Module
{
    public class Cryptography
    {
        private string PublicKeyFile;
        private string PrivateKeyFile;

        public Cryptography() { }
        public Cryptography(string FileName)
        {
            string FolderPath = Path.Combine(Directory.GetCurrentDirectory(), @"My Projects\Cryptography");
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
            PublicKeyFile = Path.Combine(FolderPath, FileName + "_PublicKeyFile");
            PrivateKeyFile = Path.Combine(FolderPath, FileName + "_PrivateKeyFile");
        }
        public byte[] encrypt(string dataEncrypt)
        {
            byte[] encrypted;
            if (File.Exists(PublicKeyFile))
            {
                encrypted = CryptographyModule.Encrypt(PublicKeyFile, Encoding.UTF8.GetBytes(dataEncrypt));
            }
            else
            {
                CryptographyModule.generateKeys(PublicKeyFile, PrivateKeyFile);
                encrypted = CryptographyModule.Encrypt(PublicKeyFile, Encoding.UTF8.GetBytes(dataEncrypt));
            }
            return encrypted;
        }
        public byte[] decrypt(byte[] encrypted)
        {
            byte[] decrypted;
            decrypted = CryptographyModule.Decrypt(PrivateKeyFile, encrypted);
            return decrypted;
        }
        public void DeleteKeys()
        {
            File.Delete(PublicKeyFile);
            File.Delete(PrivateKeyFile);
        }
    }
    public class CryptographyModule
    {
        //private static RSAParameters publicKey;
        //private static RSAParameters privateKey;
        //public static string CONTAINER_NAME = null;
        public enum KeySizes
        {
            SIZE_512 = 512,
            SIZE_1024 = 1024,
            SIZE_2048 = 2048,
            SIZE_952 = 952,
            SIZE_1369 = 1369
        };
        public static void generateKeys(string publicKeyFile, string privateKeyFile)
        {
            using (var rsa = new RSACryptoServiceProvider((int)KeySizes.SIZE_2048))
            {
                rsa.PersistKeyInCsp = false;
                if (File.Exists(privateKeyFile))
                    File.Delete(privateKeyFile);
                if (File.Exists(publicKeyFile))
                    File.Delete(publicKeyFile);
                string publicKey = rsa.ToXmlString(false);
                File.WriteAllText(publicKeyFile, publicKey);
                string privateKey = rsa.ToXmlString(true);
                File.WriteAllText(privateKeyFile, privateKey);
            }
        }

        public static byte[] Encrypt(string publicKeyFile, byte[] plain)
        {
            byte[] encrypted;
            using (var rsa = new RSACryptoServiceProvider((int)KeySizes.SIZE_2048))
            {
                rsa.PersistKeyInCsp = false;
                string publicKey = File.ReadAllText(publicKeyFile);
                rsa.FromXmlString(publicKey);
                encrypted = rsa.Encrypt(plain, true);
            }
            return encrypted;
        }
        public static byte[] Decrypt(string privateKeyFile, byte[] encrypted)
        {
            byte[] decrypted;
            using (var rsa = new RSACryptoServiceProvider((int)KeySizes.SIZE_2048))
            {
                rsa.PersistKeyInCsp = false;
                string privateKey = File.ReadAllText(privateKeyFile);
                rsa.FromXmlString(privateKey);
                decrypted = rsa.Decrypt(encrypted, true);
            }
            return decrypted;
        }
    }
}