using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Daily.Register
{
    class UserSave
    {
        private string input;
        public UserSave(string input,bool choose)
        {
            string encrypteData;
            this.input = input;
            if (choose)
            {
                //send mail 
                
                encrypteData = Encrypt();
                Save(encrypteData);
            }
            else
            {
                encrypteData = Load();
                if (encrypteData !=null)
                {
                    this.input = encrypteData;
                }
                
                string decryptedData = Decrypt();

            }
            
        }

        private string Load()
        {
            try
            {
                string contents = File.ReadAllText(Environment.CurrentDirectory + @"\reg.txt");
                return contents;
            }
            catch
            {
                return null;
            }
            
            return null;
        }
        private void Save(string input)
        {
            string path = Environment.CurrentDirectory + @"\reg.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(input);
            }
        }

        //encrypte sign in data
        public string Encrypt()
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(input);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes("xd"));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        //decrypte saved data
        public string Decrypt()
        {
            byte[] data = Convert.FromBase64String(input);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes("xd"));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(results);
                }
            }
        }
    }
}
