namespace Timer_ile_Trafik_lambası
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
            this.components = new System.ComponentModel.Container();
            this.btnkırmızı = new System.Windows.Forms.Button();
            this.btnsarı = new System.Windows.Forms.Button();
            this.btnyesıl = new System.Windows.Forms.Button();
            this.btnbaslat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnkırmızı
            // 
            this.btnkırmızı.Location = new System.Drawing.Point(106, 63);
            this.btnkırmızı.Name = "btnkırmızı";
            this.btnkırmızı.Size = new System.Drawing.Size(103, 38);
            this.btnkırmızı.TabIndex = 0;
            this.btnkırmızı.Text = "Kırmızı";
            this.btnkırmızı.UseVisualStyleBackColor = true;
            // 
            // btnsarı
            // 
            this.btnsarı.Location = new System.Drawing.Point(106, 119);
            this.btnsarı.Name = "btnsarı";
            this.btnsarı.Size = new System.Drawing.Size(103, 39);
            this.btnsarı.TabIndex = 1;
            this.btnsarı.Text = "sarı";
            this.btnsarı.UseVisualStyleBackColor = true;
            // 
            // btnyesıl
            // 
            this.btnyesıl.Location = new System.Drawing.Point(106, 176);
            this.btnyesıl.Name = "btnyesıl";
            this.btnyesıl.Size = new System.Drawing.Size(103, 36);
            this.btnyesıl.TabIndex = 3;
            this.btnyesıl.Text = "Yesil";
            this.btnyesıl.UseVisualStyleBackColor = true;
            // 
            // btnbaslat
            // 
            this.btnbaslat.Location = new System.Drawing.Point(106, 232);
            this.btnbaslat.Name = "btnbaslat";
            this.btnbaslat.Size = new System.Drawing.Size(130, 65);
            this.btnbaslat.TabIndex = 2;
            this.btnbaslat.Text = "Başlat";
            this.btnbaslat.UseVisualStyleBackColor = true;
            this.btnbaslat.Click += new System.EventHandler(this.btnbaslat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnyesıl);
            this.Controls.Add(this.btnbaslat);
            this.Controls.Add(this.btnsarı);
            this.Controls.Add(this.btnkırmızı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkırmızı;
        private System.Windows.Forms.Button btnsarı;
        private System.Windows.Forms.Button btnyesıl;
        private System.Windows.Forms.Button btnbaslat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

