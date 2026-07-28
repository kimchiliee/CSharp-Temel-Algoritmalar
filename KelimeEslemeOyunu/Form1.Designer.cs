namespace KelimeEslemeOyunu

{

    partial class Form1

    {

        /// <summary>

        ///Gerekli tasarımcı değişkeni.

        /// </summary>

        private System.ComponentModel.IContainer components = null;



        /// <summary>

        ///Kullanılan tüm kaynakları temizleyin.

        /// </summary>

        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>

        protected override void Dispose(bool disposing)

        {

            if (disposing && (components != null))

            {

                components.Dispose();

            }

            base.Dispose(disposing);

        }



        #region Windows Form Designer üretilen kod



        /// <summary>

        /// Tasarımcı desteği için gerekli metot - bu metodun 

        ///içeriğini kod düzenleyici ile değiştirmeyin.

        /// </summary>

        private void InitializeComponent()

        {

            this.listBoxEng = new System.Windows.Forms.ListBox();

            this.listBoxTr = new System.Windows.Forms.ListBox();

            this.btnYukle = new System.Windows.Forms.Button();

            this.btnKontrol = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 

            // listBoxEng

            // 

            this.listBoxEng.FormattingEnabled = true;

            this.listBoxEng.Location = new System.Drawing.Point(226, 158);

            this.listBoxEng.Name = "listBoxEng";

            this.listBoxEng.Size = new System.Drawing.Size(120, 95);

            this.listBoxEng.TabIndex = 0;

            this.listBoxEng.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);

            // 

            // listBoxTr

            // 

            this.listBoxTr.FormattingEnabled = true;

            this.listBoxTr.Location = new System.Drawing.Point(401, 158);

            this.listBoxTr.Name = "listBoxTr";

            this.listBoxTr.Size = new System.Drawing.Size(120, 95);

            this.listBoxTr.TabIndex = 1;

            this.listBoxTr.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);

            // 

            // btnYukle

            // 

            this.btnYukle.Location = new System.Drawing.Point(401, 259);

            this.btnYukle.Name = "btnYukle";

            this.btnYukle.Size = new System.Drawing.Size(75, 23);

            this.btnYukle.TabIndex = 2;

            this.btnYukle.Text = " ";

            this.btnYukle.UseVisualStyleBackColor = true;

            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);

            // 

            // btnKontrol

            // 

            this.btnKontrol.Location = new System.Drawing.Point(401, 289);

            this.btnKontrol.Name = "btnKontrol";

            this.btnKontrol.Size = new System.Drawing.Size(75, 23);

            this.btnKontrol.TabIndex = 3;

            this.btnKontrol.Text = "button2";

            this.btnKontrol.UseVisualStyleBackColor = true;

            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);

            // 

            // Form1

            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(800, 465);

            this.Controls.Add(this.btnKontrol);

            this.Controls.Add(this.btnYukle);

            this.Controls.Add(this.listBoxTr);

            this.Controls.Add(this.listBoxEng);

            this.Name = "Form1";

            this.Text = "Form1";

            this.ResumeLayout(false);



        }



        #endregion



        private System.Windows.Forms.ListBox listBoxEng;

        private System.Windows.Forms.ListBox listBoxTr;

        private System.Windows.Forms.Button btnYukle;

        private System.Windows.Forms.Button btnKontrol;

    }

} 

