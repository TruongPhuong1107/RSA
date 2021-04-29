namespace RSA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbKeySize = new System.Windows.Forms.ComboBox();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrivateKeyBrowse = new System.Windows.Forms.Button();
            this.txbPrivateKeyFilePath = new System.Windows.Forms.TextBox();
            this.btnPublicKeyBrowse = new System.Windows.Forms.Button();
            this.txbPulicKeyFilePath = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnSourceBrowse = new System.Windows.Forms.Button();
            this.txbSourcePath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbKeySize);
            this.groupBox1.Controls.Add(this.btnGenerateKeys);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 208);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate keys";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Key size";
            // 
            // cbbKeySize
            // 
            this.cbbKeySize.FormattingEnabled = true;
            this.cbbKeySize.Location = new System.Drawing.Point(21, 73);
            this.cbbKeySize.Name = "cbbKeySize";
            this.cbbKeySize.Size = new System.Drawing.Size(121, 24);
            this.cbbKeySize.TabIndex = 4;
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.Location = new System.Drawing.Point(21, 130);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(121, 26);
            this.btnGenerateKeys.TabIndex = 3;
            this.btnGenerateKeys.Text = "Generate Keys";
            this.btnGenerateKeys.UseVisualStyleBackColor = true;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnPrivateKeyBrowse);
            this.groupBox2.Controls.Add(this.txbPrivateKeyFilePath);
            this.groupBox2.Controls.Add(this.btnPublicKeyBrowse);
            this.groupBox2.Controls.Add(this.txbPulicKeyFilePath);
            this.groupBox2.Controls.Add(this.btnDecrypt);
            this.groupBox2.Controls.Add(this.btnEncrypt);
            this.groupBox2.Controls.Add(this.btnSourceBrowse);
            this.groupBox2.Controls.Add(this.txbSourcePath);
            this.groupBox2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(201, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 208);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RSA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Private Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Public Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Source file";
            // 
            // btnPrivateKeyBrowse
            // 
            this.btnPrivateKeyBrowse.Enabled = false;
            this.btnPrivateKeyBrowse.Location = new System.Drawing.Point(382, 113);
            this.btnPrivateKeyBrowse.Name = "btnPrivateKeyBrowse";
            this.btnPrivateKeyBrowse.Size = new System.Drawing.Size(75, 25);
            this.btnPrivateKeyBrowse.TabIndex = 23;
            this.btnPrivateKeyBrowse.Text = "Browse";
            this.btnPrivateKeyBrowse.UseVisualStyleBackColor = true;
            this.btnPrivateKeyBrowse.Click += new System.EventHandler(this.btnPrivateKeyBrowse_Click);
            // 
            // txbPrivateKeyFilePath
            // 
            this.txbPrivateKeyFilePath.Location = new System.Drawing.Point(104, 113);
            this.txbPrivateKeyFilePath.Name = "txbPrivateKeyFilePath";
            this.txbPrivateKeyFilePath.ReadOnly = true;
            this.txbPrivateKeyFilePath.Size = new System.Drawing.Size(256, 26);
            this.txbPrivateKeyFilePath.TabIndex = 22;
            // 
            // btnPublicKeyBrowse
            // 
            this.btnPublicKeyBrowse.Enabled = false;
            this.btnPublicKeyBrowse.Location = new System.Drawing.Point(382, 73);
            this.btnPublicKeyBrowse.Name = "btnPublicKeyBrowse";
            this.btnPublicKeyBrowse.Size = new System.Drawing.Size(75, 25);
            this.btnPublicKeyBrowse.TabIndex = 21;
            this.btnPublicKeyBrowse.Text = "Browse";
            this.btnPublicKeyBrowse.UseVisualStyleBackColor = true;
            this.btnPublicKeyBrowse.Click += new System.EventHandler(this.btnPublicKeyBrowse_Click);
            // 
            // txbPulicKeyFilePath
            // 
            this.txbPulicKeyFilePath.Location = new System.Drawing.Point(104, 73);
            this.txbPulicKeyFilePath.Name = "txbPulicKeyFilePath";
            this.txbPulicKeyFilePath.ReadOnly = true;
            this.txbPulicKeyFilePath.Size = new System.Drawing.Size(256, 26);
            this.txbPulicKeyFilePath.TabIndex = 20;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Location = new System.Drawing.Point(243, 152);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(117, 26);
            this.btnDecrypt.TabIndex = 19;
            this.btnDecrypt.Text = "Decryption";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Location = new System.Drawing.Point(104, 152);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(117, 26);
            this.btnEncrypt.TabIndex = 18;
            this.btnEncrypt.Text = "Encryption";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnSourceBrowse
            // 
            this.btnSourceBrowse.Location = new System.Drawing.Point(382, 30);
            this.btnSourceBrowse.Name = "btnSourceBrowse";
            this.btnSourceBrowse.Size = new System.Drawing.Size(75, 25);
            this.btnSourceBrowse.TabIndex = 17;
            this.btnSourceBrowse.Text = "Browse";
            this.btnSourceBrowse.UseVisualStyleBackColor = true;
            this.btnSourceBrowse.Click += new System.EventHandler(this.btnSourceBrowse_Click);
            // 
            // txbSourcePath
            // 
            this.txbSourcePath.Location = new System.Drawing.Point(104, 31);
            this.txbSourcePath.Name = "txbSourcePath";
            this.txbSourcePath.ReadOnly = true;
            this.txbSourcePath.Size = new System.Drawing.Size(256, 26);
            this.txbSourcePath.TabIndex = 16;
            this.txbSourcePath.TextChanged += new System.EventHandler(this.txbSourcePath_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 248);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RSA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbKeySize;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrivateKeyBrowse;
        private System.Windows.Forms.TextBox txbPrivateKeyFilePath;
        private System.Windows.Forms.Button btnPublicKeyBrowse;
        private System.Windows.Forms.TextBox txbPulicKeyFilePath;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnSourceBrowse;
        private System.Windows.Forms.TextBox txbSourcePath;
    }
}

