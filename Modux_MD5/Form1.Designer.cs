namespace Modux_MD5
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            encryptBtn = new Button();
            decryptBtn = new Button();
            encryptHeading = new Label();
            decryptHeading = new Label();
            encryptInput = new TextBox();
            encryptOutput = new TextBox();
            decryptOutput = new TextBox();
            decryptInput = new TextBox();
            keywordsOpen = new OpenFileDialog();
            keywordsPath = new TextBox();
            keywordsBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // encryptBtn
            // 
            encryptBtn.Location = new Point(15, 65);
            encryptBtn.Name = "encryptBtn";
            encryptBtn.Size = new Size(75, 23);
            encryptBtn.TabIndex = 1;
            encryptBtn.Text = "Encrypt";
            encryptBtn.UseVisualStyleBackColor = true;
            encryptBtn.Click += encryptBtn_Click;
            // 
            // decryptBtn
            // 
            decryptBtn.Location = new Point(15, 225);
            decryptBtn.Name = "decryptBtn";
            decryptBtn.Size = new Size(75, 23);
            decryptBtn.TabIndex = 6;
            decryptBtn.Text = "Decrypt";
            decryptBtn.UseVisualStyleBackColor = true;
            decryptBtn.Click += decryptBtn_Click;
            // 
            // encryptHeading
            // 
            encryptHeading.AutoSize = true;
            encryptHeading.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            encryptHeading.Location = new Point(15, 15);
            encryptHeading.Name = "encryptHeading";
            encryptHeading.Size = new Size(66, 15);
            encryptHeading.TabIndex = 0;
            encryptHeading.Text = "Encryption";
            // 
            // decryptHeading
            // 
            decryptHeading.AutoSize = true;
            decryptHeading.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            decryptHeading.Location = new Point(15, 150);
            decryptHeading.Name = "decryptHeading";
            decryptHeading.Size = new Size(69, 15);
            decryptHeading.TabIndex = 0;
            decryptHeading.Text = "Decryption";
            // 
            // encryptInput
            // 
            encryptInput.Location = new Point(95, 36);
            encryptInput.Name = "encryptInput";
            encryptInput.Size = new Size(300, 23);
            encryptInput.TabIndex = 0;
            // 
            // encryptOutput
            // 
            encryptOutput.BorderStyle = BorderStyle.None;
            encryptOutput.Location = new Point(30, 120);
            encryptOutput.Name = "encryptOutput";
            encryptOutput.ReadOnly = true;
            encryptOutput.Size = new Size(228, 16);
            encryptOutput.TabIndex = 2;
            // 
            // decryptOutput
            // 
            decryptOutput.BorderStyle = BorderStyle.None;
            decryptOutput.Location = new Point(30, 280);
            decryptOutput.Name = "decryptOutput";
            decryptOutput.ReadOnly = true;
            decryptOutput.Size = new Size(228, 16);
            decryptOutput.TabIndex = 7;
            // 
            // decryptInput
            // 
            decryptInput.Location = new Point(115, 196);
            decryptInput.Name = "decryptInput";
            decryptInput.Size = new Size(280, 23);
            decryptInput.TabIndex = 5;
            // 
            // keywordsOpen
            // 
            keywordsOpen.FileName = "openFileDialog1";
            keywordsOpen.Filter = "\"txt files (*.txt)|*.txt|All files (*.*)|*.*\"";
            keywordsOpen.InitialDirectory = "%HOMEPATH%";
            // 
            // keywordsPath
            // 
            keywordsPath.Location = new Point(115, 171);
            keywordsPath.Name = "keywordsPath";
            keywordsPath.Size = new Size(233, 23);
            keywordsPath.TabIndex = 3;
            // 
            // keywordsBtn
            // 
            keywordsBtn.Location = new Point(350, 171);
            keywordsBtn.Name = "keywordsBtn";
            keywordsBtn.Size = new Size(45, 23);
            keywordsBtn.TabIndex = 4;
            keywordsBtn.Text = "Open";
            keywordsBtn.UseVisualStyleBackColor = true;
            keywordsBtn.Click += keywordsBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 40);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 8;
            label1.Text = "Input Text";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 200);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 9;
            label2.Text = "Input Text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 95);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 10;
            label3.Text = "Output Text";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 255);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 11;
            label4.Text = "Output Text";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 175);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 12;
            label5.Text = "Keywords File";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 311);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(keywordsBtn);
            Controls.Add(keywordsPath);
            Controls.Add(decryptInput);
            Controls.Add(decryptOutput);
            Controls.Add(encryptOutput);
            Controls.Add(encryptInput);
            Controls.Add(decryptHeading);
            Controls.Add(encryptHeading);
            Controls.Add(decryptBtn);
            Controls.Add(encryptBtn);
            Name = "Form";
            Text = "MD5 Encrypt/Decrypt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button encryptBtn;
        private Button decryptBtn;
        private Label encryptHeading;
        private Label decryptHeading;
        private TextBox encryptInput;
        private TextBox encryptOutput;
        private TextBox decryptOutput;
        private TextBox decryptInput;
        private OpenFileDialog keywordsOpen;
        private TextBox keywordsPath;
        private Button keywordsBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
