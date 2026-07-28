using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosyaIslemleriUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0; 
            
            timer1.Interval = 100;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya_sec = new OpenFileDialog
            dosya_sec.Filter = "Word Dosyası (*.docx)|*.docx|PDF Dosyası (*.pdf)|*.pdf|Metin Belgesi (*.txt)|*.txt";
            dosya_sec.Title = "Açmak için bir dosya seçin";
            
            if (dosya_sec.ShowDialog() == DialogResult.OK)
            {
                string dosya_yolu = dosya_sec.FileName;
                if (File.Exists(dosya_yolu))
                {
                    Process.Start(new ProcessStartInfo()
                    {
                        FileName = dosya_yolu,
                        UseShellExecute = true
                    });
                }
                else
                {
                    MessageBox.Show("Dosya Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value + 5 <= 100)
            {
                progressBar1.Value += 5;
            }
            else
            {
                progressBar1.Value = 100; 
                timer1.Stop(); 
                MessageBox.Show("Sistem Hazır!", "Bilgi"); // "blabla" yerine daha profesyonel bir mesaj :)
            }
        }
    }
}
