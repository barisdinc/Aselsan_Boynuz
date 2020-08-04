namespace AselsanSegmentGenerator
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSegmentResult = new System.Windows.Forms.TextBox();
            this.txtAcikSegmentler = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 46);
            this.button1.TabIndex = 24;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Sonuç";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Açık Segmentler";
            // 
            // txtSegmentResult
            // 
            this.txtSegmentResult.Location = new System.Drawing.Point(97, 38);
            this.txtSegmentResult.Name = "txtSegmentResult";
            this.txtSegmentResult.Size = new System.Drawing.Size(150, 20);
            this.txtSegmentResult.TabIndex = 21;
            // 
            // txtAcikSegmentler
            // 
            this.txtAcikSegmentler.Location = new System.Drawing.Point(97, 12);
            this.txtAcikSegmentler.Name = "txtAcikSegmentler";
            this.txtAcikSegmentler.Size = new System.Drawing.Size(150, 20);
            this.txtAcikSegmentler.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AselsanSegmentGenerator.Properties.Resources.asellcd;
            this.pictureBox1.Location = new System.Drawing.Point(357, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSegmentResult);
            this.Controls.Add(this.txtAcikSegmentler);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSegmentResult;
        private System.Windows.Forms.TextBox txtAcikSegmentler;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

