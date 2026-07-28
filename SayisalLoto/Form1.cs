using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayısal_Loto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> lotoSayilari = new List<int>();

            while (lotoSayilari.Count < 6)
            {
                int rastgeleSayi = rnd.Next(1, 50); // 1 dahil, 50 dahil değil (yani 49'a kadar)
                
                if (!lotoSayilari.Contains(rastgeleSayi))
                {
                    lotoSayilari.Add(rastgeleSayi);
                }
            }
            
            lotoSayilari.Sort();
           
            label1.Text = string.Join(" - ", lotoSayilari);

               label1.Text = lotoSayilari[0].ToString();
               label2.Text = lotoSayilari[1].ToString();
               label3.Text = lotoSayilari[2].ToString();
              
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
    }
}
