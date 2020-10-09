using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Byte[] Key;
        Byte[] IV;
        Byte[] cipherbytes;

        private void encode_DES_ECB_Click(object sender, EventArgs e)
        {
            DateTime then = DateTime.Now;
            SymmetricAlgorithm sa = DES.Create();
            sa.GenerateKey();
            Key = sa.Key;
            sa.GenerateIV();
            IV = sa.IV;

            String Data = input1.Text;

            try
            {
                MemoryStream mStream = new MemoryStream();

                DES alg = DES.Create();

                CryptoStream cStream = new CryptoStream(mStream,
                    alg.CreateEncryptor(Key, IV),
                    CryptoStreamMode.Write);

                byte[] toEncrypt = new ASCIIEncoding().GetBytes(Data);

                cStream.Write(toEncrypt, 0, toEncrypt.Length);
                cStream.FlushFinalBlock();

                byte[] ret = mStream.ToArray();

                cStream.Close();
                mStream.Close();

                cipherbytes = ret;
                input2.Text = Encoding.UTF8.GetString(cipherbytes);
                delta1.Text = (DateTime.Now - then).TotalSeconds.ToString() + " сек";
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", ex.Message);
                return;
            }
        }

        private void decode_DES_ECB_Click(object sender, EventArgs e)
        {
            DateTime then = DateTime.Now;
            try
            {
                MemoryStream msDecrypt = new MemoryStream(cipherbytes);
                DES alg = DES.Create();
                CryptoStream csDecrypt = new CryptoStream(msDecrypt,
                    alg.CreateDecryptor(Key, IV),
                    CryptoStreamMode.Read);

                byte[] fromEncrypt = new byte[cipherbytes.Length];
                csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);
                input2.Text = new ASCIIEncoding().GetString(fromEncrypt);
                delta1.Text = (DateTime.Now - then).TotalSeconds.ToString() + "сек";

            }
            catch (CryptographicException ex)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", ex.Message);
                return;
            }

        }

        private void encode_DES_CBC_Click(object sender, EventArgs e)
        {
            DateTime then = DateTime.Now;

            SymmetricAlgorithm sa = DES.Create();
            sa.GenerateKey();
            Key = sa.Key;
            sa.GenerateIV();
            IV = sa.IV;
            sa.Mode = CipherMode.CBC;
            sa.Padding = PaddingMode.PKCS7;

            String Data = input3.Text;

            try
            {
                MemoryStream mStream = new MemoryStream();

                DES alg = DES.Create();

                CryptoStream cStream = new CryptoStream(mStream,
                    alg.CreateEncryptor(Key, IV),
                    CryptoStreamMode.Write);

                byte[] toEncrypt = new ASCIIEncoding().GetBytes(Data);

                cStream.Write(toEncrypt, 0, toEncrypt.Length);
                cStream.FlushFinalBlock();

                byte[] ret = mStream.ToArray();

                cStream.Close();
                mStream.Close();

                cipherbytes = ret;

                input4.Text = Encoding.UTF8.GetString(cipherbytes);
                delta2.Text = (DateTime.Now - then).TotalSeconds.ToString() + "сек";


            }
            catch (CryptographicException ex)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", ex.Message);
                return;
            }
        }

        private void decode_DES_CBC_Click(object sender, EventArgs e)
        {
            DateTime then = DateTime.Now;
            try
            {
                MemoryStream msDecrypt = new MemoryStream(cipherbytes);
                DES alg = DES.Create();
                CryptoStream csDecrypt = new CryptoStream(msDecrypt,
                    alg.CreateDecryptor(Key, IV),
                    CryptoStreamMode.Read);
                alg.Mode = CipherMode.CBC;
                alg.Padding = PaddingMode.PKCS7;


                byte[] fromEncrypt = new byte[cipherbytes.Length];
                csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);

                input4.Text = new ASCIIEncoding().GetString(fromEncrypt);
                delta2.Text = (DateTime.Now - then).TotalSeconds.ToString() + " сек";
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", ex.Message);
                return;
            }
        }

        private void encode_Rijndael_EBC_Click(object sender, EventArgs e)
        {

            DateTime then = DateTime.Now;
            String plainText = input5.Text;
            try
            {
                using (Rijndael rijAlg = Rijndael.Create())
                {
                    rijAlg.GenerateKey();
                    Key = rijAlg.Key;
                    rijAlg.GenerateIV();
                    IV = rijAlg.IV;

                    ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {
                                swEncrypt.Write(plainText);
                            }
                            cipherbytes = msEncrypt.ToArray();
                        }
                    }
                }
                input6.Text = Encoding.UTF8.GetString(cipherbytes);
                delta3.Text = (DateTime.Now - then).TotalSeconds.ToString() + "сек";


            }
            catch (CryptographicException ex)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", ex.Message);
                return;
            }
        }

        private void decode_Rijndael_EBC_Click(object sender, EventArgs e)
        {
            DateTime then = DateTime.Now;
            String plaintext = "";
            try
            {
                using (Rijndael rijAlg = Rijndael.Create())
                {
                    rijAlg.Key = Key;
                    rijAlg.IV = IV;

                    ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                    using (MemoryStream msDecrypt = new MemoryStream(cipherbytes))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                plaintext = srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }
                input6.Text = plaintext;
                delta3.Text = (DateTime.Now - then).TotalSeconds.ToString() + " сек";
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", ex.Message);
                return;
            }
        }

        private void encode_RC2_CBF_Click(object sender, EventArgs e)
        {
            DateTime then = DateTime.Now;
            String Data = input7.Text;

            try
            {
                MemoryStream mStream = new MemoryStream();

                RC2 alg = RC2.Create();
                alg.GenerateKey();
                Key = alg.Key;
                alg.GenerateIV();
                IV = alg.IV;

                CryptoStream cStream = new CryptoStream(mStream,
                    alg.CreateEncryptor(Key, IV),
                    CryptoStreamMode.Write);

                byte[] toEncrypt = new ASCIIEncoding().GetBytes(Data);

                cStream.Write(toEncrypt, 0, toEncrypt.Length);
                cStream.FlushFinalBlock();

                byte[] ret = mStream.ToArray();

                cStream.Close();
                mStream.Close();

                cipherbytes = ret;
                input8.Text = Encoding.UTF8.GetString(cipherbytes);
                delta4.Text = (DateTime.Now - then).TotalSeconds.ToString() + " сек";
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", ex.Message);
                return;
            }
        }

        private void decode_RC2_CBF_Click(object sender, EventArgs e)
        {
            DateTime then = DateTime.Now;
            try
            {
                MemoryStream msDecrypt = new MemoryStream(cipherbytes);
                RC2 alg = RC2.Create();
                CryptoStream csDecrypt = new CryptoStream(msDecrypt,
                    alg.CreateDecryptor(Key, IV),
                    CryptoStreamMode.Read);

                byte[] fromEncrypt = new byte[cipherbytes.Length];
                csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);
                input8.Text = new ASCIIEncoding().GetString(fromEncrypt);
                delta4.Text = (DateTime.Now - then).TotalSeconds.ToString() + "сек";

            }
            catch (CryptographicException ex)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", ex.Message);
                return;
            }
        }
    }
}
