using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Modux_MD5
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            decryptOutput.Text = String.Empty;
            decryptOutput.Update();
            try
            {
                // Remove Whitespace Source: https://code-maze.com/replace-whitespaces-string-csharp/
                string hash = Regex.Replace(decryptInput.Text.ToUpper(), @"\s", string.Empty);
                if (hash.Length == 32)
                {
                    string[] keywords = File.ReadAllLines(keywordsPath.Text);
                    for (int i = 0; i < keywords.Length; i++)
                    {
                        if (CreateMD5(keywords[i]) == hash)
                        {
                            decryptOutput.Text = keywords[i];
                            break;
                        }
                    }
                }
                else
                {
                    decryptOutput.Text = "Invalid Hash";
                }
            }
            catch (ArgumentException ex)
            {
                decryptOutput.Text = "No Keywords Provided";
            }
            catch (FileNotFoundException ex)
            {
                decryptOutput.Text = "Invalid File Path";
            }
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            encryptOutput.Text = CreateMD5(encryptInput.Text);
        }

        public static string CreateMD5(string input)
        {
            // Source: https://stackoverflow.com/questions/11454004/calculate-a-md5-hash-from-a-string
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes);
            }
        }

        private void keywordsBtn_Click(object sender, EventArgs e)
        {
            keywordsOpen = new OpenFileDialog();
            if (keywordsOpen.ShowDialog() == DialogResult.OK) // Test result.
            {
                keywordsPath.Text = keywordsOpen.FileName;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
