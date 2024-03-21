namespace Uygulama21
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
            this.btnVeriBagla = new System.Windows.Forms.Button();
            this.ListeVeriler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnVeriBagla
            // 
            this.btnVeriBagla.Location = new System.Drawing.Point(197, 166);
            this.btnVeriBagla.Name = "btnVeriBagla";
            this.btnVeriBagla.Size = new System.Drawing.Size(75, 23);
            this.btnVeriBagla.TabIndex = 0;
            this.btnVeriBagla.Text = "Veri Bağla";
            this.btnVeriBagla.UseVisualStyleBackColor = true;
            this.btnVeriBagla.Click += new System.EventHandler(this.btnVeriBagla_Click);
            // 
            // ListeVeriler
            // 
            this.ListeVeriler.FormattingEnabled = true;
            this.ListeVeriler.Location = new System.Drawing.Point(442, 139);
            this.ListeVeriler.Name = "ListeVeriler";
            this.ListeVeriler.Size = new System.Drawing.Size(120, 95);
            this.ListeVeriler.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListeVeriler);
            this.Controls.Add(this.btnVeriBagla);
            this.Name = "Form1";
            this.Text = "Veri Bağlama";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVeriBagla;
        private System.Windows.Forms.ListBox ListeVeriler;
    }
}

