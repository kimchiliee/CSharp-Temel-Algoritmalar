using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KelimeEslemeOyunu
{
    public partial class Form1 : Form
    {
        // Kelimeleri anahtar-değer (İngilizce-Türkçe) şeklinde tutmak için Dictionary kullanıyoruz.
        // Bu sektörde çok sık kullanılan profesyonel bir veri yapısıdır.
        Dictionary<string, string> kelimeler = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        // Tasarım kodunda tanımladığın Load/Yükle butonu
        private void btnYukle_Click(object sender, EventArgs e)
        {
            // Yeni oyun başlatıldığında listeleri ve sözlüğü temizle
            listBoxEng.Items.Clear();
            listBoxTr.Items.Clear();
            kelimeler.Clear();

            // Sözlüğe kelime çiftlerimizi ekliyoruz
            kelimeler.Add("Algorithm", "Algoritma");
            kelimeler.Add("Database", "Veritabanı");
            kelimeler.Add("Software", "Yazılım");
            kelimeler.Add("Network", "Ağ");
            kelimeler.Add("Developer", "Geliştirici");

            // İngilizce kelimeleri ilk listeye ekliyoruz
            foreach (var item in kelimeler.Keys)
            {
                listBoxEng.Items.Add(item);
            }

            // Türkçe kelimeleri oyunu zorlaştırmak için karıştırarak ikinci listeye ekliyoruz
            List<string> trKelimeler = kelimeler.Values.ToList();
            Random rnd = new Random();
            trKelimeler = trKelimeler.OrderBy(x => rnd.Next()).ToList();

            foreach (var item in trKelimeler)
            {
                listBoxTr.Items.Add(item);
            }

            // Tasarımda buton isimleri boş veya default kalmış, onları da kodla düzeltelim
            btnYukle.Text = "Yeniden Başlat";
            btnKontrol.Text = "Kontrol Et";
        }

        // Tasarım kodunda tanımladığın Kontrol butonu
        private void btnKontrol_Click(object sender, EventArgs e)
        {
            // Kullanıcının iki listeden de seçim yapıp yapmadığını kontrol edelim
            if (listBoxEng.SelectedItem == null || listBoxTr.SelectedItem == null)
            {
                MessageBox.Show("Lütfen her iki listeden de bir kelime seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string secilenEng = listBoxEng.SelectedItem.ToString();
            string secilenTr = listBoxTr.SelectedItem.ToString();

            // Sözlükteki İngilizce kelimenin karşılığı, seçilen Türkçe kelimeye eşit mi?
            if (kelimeler[secilenEng] == secilenTr)
            {
                MessageBox.Show("Tebrikler, doğru eşleşme!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Doğru bilinen kelimeleri listeden çıkararak oyunu ilerletiyoruz
                listBoxEng.Items.Remove(secilenEng);
                listBoxTr.Items.Remove(secilenTr);

                // Oyun bitti mi kontrolü
                if (listBoxEng.Items.Count == 0)
                {
                    MessageBox.Show("Tüm kelimeleri eşleştirdiniz! Oyun Bitti.", "Tebrikler");
                }
            }
            else
            {
                MessageBox.Show("Yanlış eşleşme, tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tasarım kodunda tetiklenen ancak içi boş olması gereken olaylar (Hata almamak için gereklidir)
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
