using System;
using System.Windows.Forms;
using System.Xml; 
namespace TCMBDovizKurlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                
                xml.Load("https://www.tcmb.gov.tr/kurlar/today.xml");

               XmlNode usd = xml.SelectSingleNode("/Tarih_Date/Currency[@Kod='USD']/ForexSelling");
                XmlNode eur = xml.SelectSingleNode("/Tarih_Date/Currency[@Kod='EUR']/ForexSelling");

                 label1.Text = "USD Satış: " + usd.InnerText;
                label2.Text = "EUR Satış: " + eur.InnerText;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Döviz kurları çekilirken bir hata oluştu. Lütfen internet bağlantınızı kontrol edin.\n\nHata Detayı: " + hata.Message, "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
