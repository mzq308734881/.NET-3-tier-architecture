using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace MyDbHelper
{
    public class Encrypt
    {
        static string key = "441568140";
        //static MD5 md5 = MD5.Create();
        //默认密钥向量
        static byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
        public Encrypt()
        {
        }

        /*public static string MD5Hash(string strSource) 
        {
            byte[] source = md5.ComputeHash(Encoding.Default .GetBytes(strSource));
            StringBuilder middle = new StringBuilder();
            for (int i = 0; i < source.Length; i++)
                middle.Append(source[i].ToString("X"));
            return middle .ToString ();
        }*/

        // 加密：
        public static string EncryptDES(string pass)
        {
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(key.Substring(0, 8));
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Encoding.UTF8.GetBytes(pass);
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, provider.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch
            {
                return pass;
            }
        }
        public static string DecryptDES(string pass)
        {
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(key.Substring(0, 8));
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Convert.FromBase64String(pass);
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();//存储加后的数据
                CryptoStream cStream = new CryptoStream(mStream, provider.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(mStream.ToArray());
            }
            catch
            {
                return pass;
            }
        }

    }
}

