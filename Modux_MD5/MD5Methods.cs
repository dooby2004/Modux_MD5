using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Modux_MD5
{
    public class MD5Methods
    {
        public static string Encrypt(string input)
        {
            // Source: https://stackoverflow.com/questions/11454004/calculate-a-md5-hash-from-a-string
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes);
            }
        }
        public static (Int32, string) DecryptFromList(string input, string[] keywords)
        {
            // Remove Whitespace Source: https://code-maze.com/replace-whitespaces-string-csharp/
            string hash = Regex.Replace(input.ToUpper(), @"\s", String.Empty);
            if (hash.Length == 32)
            {
                for (int i = 0; i < keywords.Length; i++)
                {
                    if (Encrypt(keywords[i]) == hash)
                    {
                        return (0, keywords[i]);
                    }
                }
                return (1, String.Empty);
            }
            else
            {
                return (2, String.Empty);
            }
        }

        public static (Int32, string) DecryptFromFile(string input, Stream fileStream)
        {
            // Remove Whitespace Source: https://code-maze.com/replace-whitespaces-string-csharp/
            string hash = Regex.Replace(input.ToUpper(), @"\s", String.Empty);
            if (hash.Length == 32)
            {
                // Source: https://stackoverflow.com/questions/8037070/whats-the-fastest-way-to-read-a-text-file-line-by-line
                using (StreamReader streamReader = new StreamReader(fileStream, true))
                {
                    String keyword;
                    while ((keyword = streamReader.ReadLine()) != null)
                    {
                        if (Encrypt(keyword) == hash)
                        {
                            return (0, keyword);
                        }
                    }
                    return (1, String.Empty);
                }
            }
            else
            {
                return (2, String.Empty);
            }
        }
    }
}
