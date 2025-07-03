using System.Security.Cryptography;
using System.Text;

namespace NewsSite.Security
{
    public static class SiteSecurity
    {
        public static string FixEmail (string email) =>email.Trim ().ToLower().Replace(" " , "");
        public static string EncodePasswordMd5(string password)
        {
            Byte[] originlByte;
            Byte[] encodeedBytes;
            MD5 md5;
            md5 = new MD5CryptoServiceProvider();
            originlByte = ASCIIEncoding.Default.GetBytes(password);
            encodeedBytes = md5.ComputeHash(originlByte);
            return BitConverter.ToString(encodeedBytes);

        }
    }
}
