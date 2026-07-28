using System;
using System.Globalization;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        double sayi1 = 0;
        string islem = "";

        public Form1()
        {
            InitializeComponent();
        }

      private void btnSayi_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtEkran.Text += btn.Text;
        }

       private void btnVirgul_Click(object sender, EventArgs e)
        {
            if (!txtEkran.Text.Contains(","))
            {
                txtEkran.Text += ",";
            }
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(txtEkran.Text);
            islem = "+";
            txtEkran.Clear();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(txtEkran.Text);
            islem = "-";
            txtEkran.Clear();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(txtEkran.Text);
            islem = "*";
            txtEkran.Clear();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(txtEkran.Text);
            islem = "/";
            txtEkran.Clear();
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtEkran.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out double sayi2))
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double sonuc = 0;

            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    if (sayi2 != 0)
                        sonuc = sayi1 / sayi2;
                    else
                    {
                        MessageBox.Show("Bir sayı sıfıra bölünemez!", "Matematiksel Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
            }

            txtEkran.Text = sonuc.ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtEkran.Clear();
            sayi1 = 0;
            islem = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text.Length > 0)
            {
                txtEkran.Text = txtEkran.Text.Substring(0, txtEkran.Text.Length - 1);
            }
        }
    }
}
