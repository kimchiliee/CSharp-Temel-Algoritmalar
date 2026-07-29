using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KelimeEslemeOyunu
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> kelimeler = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                string ing = textBox1.Text.Trim(); 
                string tr = textBox2.Text.Trim();

                kelimeler[ing] = tr;

                listBox1.Items.Add(ing);
                listBox2.Items.Add(tr);

                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus(); 
            }
            else
            {
                MessageBox.Show("Lütfen her iki kelime kutusunu da doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null && listBox2.SelectedItem != null)
            {
                string ing = listBox1.SelectedItem.ToString();
                string tr = listBox2.SelectedItem.ToString();

                if (kelimeler.ContainsKey(ing) && kelimeler[ing] == tr)
                {
                    listBox3.Items.Add(ing + " - " + tr);
                    
                    listBox1.Items.Remove(ing);
                    listBox2.Items.Remove(tr);
                }
                else
                {
                    MessageBox.Show("Yanlış eşleşme, lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen eşleştirmek için iki listeden de seçim yapın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e) { }
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
    }
}
