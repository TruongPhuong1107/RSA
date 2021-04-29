using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml;
using System.IO;
using System.Runtime.InteropServices;

namespace RSA
{
    public partial class Form1 : Form
    {
        private int MinOfKeySize = 384;
        private int MaxOfKeySise = 16384;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            int keySize = MinOfKeySize;
            do
            {
                cbbKeySize.Items.Add(keySize.ToString());
                keySize += 8;
            }
            while (keySize <= MaxOfKeySise);

            cbbKeySize.SelectedIndex = 0;

        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            int keySize = int.Parse(cbbKeySize.SelectedItem.ToString());

            CspParameters cspParam = new CspParameters(1);
            RSACryptoServiceProvider rsaCrypto = new RSACryptoServiceProvider(keySize, cspParam);

            String xmlPublicKey = rsaCrypto.ToXmlString(false);
            String xmlPrivateKey = rsaCrypto.ToXmlString(true);

            // Save Keys
            StreamWriter privateKeyWriter = null;
            StreamWriter publicKeyWriter = null;

            saveFileDialog1.Title = "Save Private Key";
            saveFileDialog1.FileName = "PrivateKey.prk";

            bool isPrivateKeySaved = false;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                privateKeyWriter = new StreamWriter(saveFileDialog1.FileName);
                privateKeyWriter.Write(xmlPrivateKey);
                privateKeyWriter.Close();
                privateKeyWriter.Dispose();
                isPrivateKeySaved = true;
            }
            else
            {
                isPrivateKeySaved = false;
            }

            bool isPublicKeySaved = false;
            saveFileDialog1.Title = "Save Public Key";
            saveFileDialog1.FileName = "PublicKey.puk";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                publicKeyWriter = new StreamWriter(saveFileDialog1.FileName);
                publicKeyWriter.Write(xmlPublicKey);
                publicKeyWriter.Close();
                publicKeyWriter.Dispose();
                isPublicKeySaved = true;
            }
            else
            {
                isPublicKeySaved = false;
            }

            String msg = "";
            if (isPrivateKeySaved)
            {
                msg += "Your Private Key has been saved!";
            }
            else
            {
                msg += "Your Private Key has not been saved!";
            }
            if (isPublicKeySaved)
            {
                msg += "\n" + "Your Public Key has been saved!";
            }
            else
            {
                msg += "\n" + "Your Public Key has not been saved!";
            }
            MessageBox.Show(msg);
        }

        private void btnSourceBrowse_Click(object sender, EventArgs e)
        {
            String sourcePath = "";
            openFileDialog1.Title = "Select file";
            openFileDialog1.Filter = "All Files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sourcePath = openFileDialog1.FileName;
                txbSourcePath.Text = sourcePath;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Select target CSP
            CspParameters cspParams = new CspParameters();
            cspParams.ProviderType = 1;
            RSACryptoServiceProvider rsaProvider = new RSACryptoServiceProvider(cspParams);

            // Import public key
            String xmlPublicKey = GetKeyFromFile(txbPulicKeyFilePath.Text);
            rsaProvider.FromXmlString(xmlPublicKey);

            // Get bytes data to encrypt
            byte[] toEncrypt = GetDataFromFileInByte(txbSourcePath.Text);

            // Encryption
            byte[] encrypted = rsaProvider.Encrypt(toEncrypt, true);

            // Save encrypted data
            String outputFileName = txbSourcePath.Text + ".rsa";
            bool result = SaveOutput(outputFileName, encrypted);

            if (result)
            {
                MessageBox.Show("Encryption process completed successful!");
            }
            else
            {
                MessageBox.Show("Encryption process fails!");
            }
        }

        private bool SaveOutput(String outputFileName, byte[] encrypted)
        {
            try
            {
                FileStream fs = File.Open(outputFileName, FileMode.OpenOrCreate, FileAccess.Write);
                BinaryWriter br = new BinaryWriter(fs);
                br.Write(encrypted);

                br.Close();
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private byte[] GetDataFromFileInByte(string sourcePath)
        {
            StreamReader reader = new StreamReader(sourcePath);
            String strData = reader.ReadToEnd();
            byte[] bytesData = Encoding.Unicode.GetBytes(strData);
            reader.Close();
            return bytesData;
        }

        private string GetKeyFromFile(string xmlKeyFileName)
        {
            StreamReader reader = new StreamReader(xmlKeyFileName);
            String xmlPublicKey = "";

            xmlPublicKey = reader.ReadToEnd();


            return xmlPublicKey;

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {

            // Select target CSP
            CspParameters cspParams = new CspParameters();
            cspParams.ProviderType = 1;
            RSACryptoServiceProvider rsaProvider = new RSACryptoServiceProvider(cspParams);

            // Import private key
            String xmlPrivateKey = GetKeyFromFile(txbPrivateKeyFilePath.Text);
            rsaProvider.FromXmlString(xmlPrivateKey);

            // Get bytes data to encrypt
            FileStream fs = File.OpenRead(txbSourcePath.Text);
            byte[] encrypted = new byte[fs.Length];
            fs.Read(encrypted, 0, (int)fs.Length);



            // Decryption
            byte[] decrypted = rsaProvider.Decrypt(encrypted, true);

            // Save decrypted data

            String outputFileName = "";
            string[] strTemp = txbSourcePath.Text.Split('\\');
            for (int i = 0; i < strTemp.Length - 1; i++)
            {
                outputFileName += strTemp[i] + "\\";
            }
            outputFileName += Path.GetFileNameWithoutExtension(txbSourcePath.Text);

            bool result = SaveOutput(outputFileName, decrypted);

            if (result)
            {
                MessageBox.Show("Encryption process completed successful!");
            }
            else
            {
                MessageBox.Show("Encryption process fails!");
            }
        }

        private void btnPublicKeyBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select public key file.";
            openFileDialog1.Filter = "PUK Files (*.puk)|*.puk";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txbPulicKeyFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnPrivateKeyBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select private key file.";
            openFileDialog1.Filter = "PRK Files (*.prk)|*.prk";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txbPrivateKeyFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void txbSourcePath_TextChanged(object sender, EventArgs e)
        {
            String fileName = txbSourcePath.Text;
            if (fileName != "")
            {
                String ext = Path.GetExtension(fileName);
                if (ext.Equals(".rsa"))
                {
                    btnPrivateKeyBrowse.Enabled = true;
                    btnPublicKeyBrowse.Enabled = false;
                    txbPulicKeyFilePath.Text = "";

                    btnDecrypt.Enabled = true;
                    btnEncrypt.Enabled = false;
                }
                else
                {
                    btnPrivateKeyBrowse.Enabled = false;
                    btnPublicKeyBrowse.Enabled = true;
                    txbPrivateKeyFilePath.Text = "";

                    btnEncrypt.Enabled = true;
                    btnDecrypt.Enabled = false;
                }
            }
            else
            {
                btnPrivateKeyBrowse.Enabled = false;
                btnPublicKeyBrowse.Enabled = false;
            }
        }
        
    }
}
