using System.Diagnostics;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

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
            watch1.Reset();
            watch2.Reset();
            watch3.Reset();
            watch4.Reset();
            // the code that you want to measure comes here

            decryptOutput.Text = String.Empty;
            decryptOutput.Update();
            try
            {
                (Int32 code, string result) = MD5Methods.DecryptFromFile(decryptInput.Text, File.OpenRead(keywordsPath.Text), MD5Methods.EncryptMD5);
                switch (code)
                {
                    case 0:
                        decryptOutput.Text = result;
                        break;
                    case 1:
                        decryptOutput.Text = "No Solution Found";
                        break;
                    case 2:
                        decryptOutput.Text = "Invalid Hash";
                        break;
                }
            }
            catch (ArgumentException ex)
            {
                decryptOutput.Text = "No File Path Provided";
            }
            catch (FileNotFoundException ex)
            {
                decryptOutput.Text = "Invalid File Path";
            }
            
            var elapsedMs = watch1.ElapsedMilliseconds;
            Debug.WriteLine(elapsedMs);
            elapsedMs = watch2.ElapsedMilliseconds;
            Debug.WriteLine(elapsedMs);
            elapsedMs = watch3.ElapsedMilliseconds;
            Debug.WriteLine(elapsedMs);
            elapsedMs = watch4.ElapsedMilliseconds;
            Debug.WriteLine(elapsedMs);
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            encryptOutput.Text = MD5Methods.Encrypt(encryptInput.Text, MD5Methods.EncryptMD5);
        }

        private void keywordsBtn_Click(object sender, EventArgs e)
        {
            // Source: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-8.0
            using (OpenFileDialog keywordsOpen = new OpenFileDialog())
            {
                keywordsOpen.Filter = "Text/CSV files (*.txt, *.csv)|*.txt;*.csv|All files (*.*)|*.*";
                keywordsOpen.FilterIndex = 1;
                if (keywordsOpen.ShowDialog() == DialogResult.OK)
                {
                    keywordsPath.Text = keywordsOpen.FileName;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static System.Diagnostics.Stopwatch watch1 = System.Diagnostics.Stopwatch.StartNew();
        public static System.Diagnostics.Stopwatch watch2 = System.Diagnostics.Stopwatch.StartNew();
        public static System.Diagnostics.Stopwatch watch3 = System.Diagnostics.Stopwatch.StartNew();
        public static System.Diagnostics.Stopwatch watch4 = System.Diagnostics.Stopwatch.StartNew();
    }

    
}
