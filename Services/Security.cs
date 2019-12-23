using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Services
{
    public class Security
    {
        public static string Encrypt(string text)
        {
            try
            {
                string key = "qualityinfosolutions";
                byte[] keyArray;
                byte[] encrypt_array = UTF8Encoding.UTF8.GetBytes(text);

                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tdes.CreateEncryptor();
                byte[] result = cTransform.TransformFinalBlock(encrypt_array, 0, encrypt_array.Length);
                tdes.Clear();

                text = Convert.ToBase64String(result, 0, result.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return text;
        }
    }
}
