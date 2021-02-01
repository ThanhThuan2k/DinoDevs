using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DinoTeam.Modules
{
    public static class DinoStringHasher
    {
        const string COLLECTION_CHARS = @"ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789`~!@#$%^&*()_-+={[}]\|;:""\'<,>.?/abcdefghijklmnopqrstuvwxyzđáàảãạăắằẵẳặâấầẩẫậíìỉĩịúùủũụéèẻẽẹêếềễểệóòỏõọôốồổỗộơớờởỡợưứừửữựýỳỷỹỵĐÁÀẢÃẠĂẮẰẴẲẶÂẤẦẨẪẬÍÌỈĨỊÚÙỦŨỤÉÈẺẼẸÊẾỀỄỂỆÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢƯỨỪỬỮỰÝỲỶỸỴƵƶẐẑĎďĆćĈĉČčḨḩḤḥḪḫṰṱṮṯŦŧȾⱦț";
        public static string Hash(this String plainText)
        {
            var sha512Hash = new SHA512Managed();
            string mixedPassword = plainText + plainText.Length.ToString();
            byte[] crypto = sha512Hash.ComputeHash(Encoding.UTF8.GetBytes(mixedPassword));
            string encodedPassword = string.Empty;
            foreach (byte theByte in crypto)
            {
                encodedPassword += COLLECTION_CHARS[(int)theByte % COLLECTION_CHARS.Length];
            }
            return encodedPassword;
        }

        public static string HashWith(this String plainText, string salt = "")
        {
            var sha512Hash = new SHA512Managed();
            string mixedPassword = plainText + salt + salt.Length.ToString();
            byte[] crypto = sha512Hash.ComputeHash(Encoding.UTF8.GetBytes(mixedPassword));
            string encodedPassword = string.Empty;
            foreach (byte theByte in crypto)
            {
                encodedPassword += COLLECTION_CHARS[(int)theByte % COLLECTION_CHARS.Length];
            }
            return encodedPassword;
        }

        public static string GenerateRandomString()
        {
            Random rand = new Random();
            char[] salt = new char[rand.Next(10, 20)];
            for (int i = 0; i < salt.Length; i++)
            {
                salt[i] = COLLECTION_CHARS[rand.Next(COLLECTION_CHARS.Length)];
            }

            string result = new String(salt);
            return result;
        }
    }
}