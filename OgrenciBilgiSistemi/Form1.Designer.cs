namespace OgrenciBilgiSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtNumara = new TextBox();
            txtSinif = new TextBox();
            txtBolum = new TextBox();
            btnKayitEkle = new Button();
            dgvOgrenciler = new DataGridView();
            colAd = new DataGridViewTextBoxColumn();
            colSoyad = new DataGridViewTextBoxColumn();
            colBolum = new DataGridViewTextBoxColumn();
            colSınıf = new DataGridViewTextBoxColumn();
            colNumara = new DataGridViewTextBoxColumn();
            btnKayitSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 44);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 92);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 1;
            label2.Text = "Öğrenci Soyadı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 137);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 2;
            label3.Text = "Öğrenci Bölümü :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 182);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 3;
            label4.Text = "Öğrenci Sınıfı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 224);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 4;
            label5.Text = "Öğrenci Numarası :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(187, 41);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(187, 85);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 6;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(187, 221);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(125, 27);
            txtNumara.TabIndex = 7;
            // 
            // txtSinif
            // 
            txtSinif.Location = new Point(187, 175);
            txtSinif.Name = "txtSinif";
            txtSinif.Size = new Size(125, 27);
            txtSinif.TabIndex = 8;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(187, 130);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(125, 27);
            txtBolum.TabIndex = 9;
            // 
            // btnKayitEkle
            // 
            btnKayitEkle.Location = new Point(33, 293);
            btnKayitEkle.Name = "btnKayitEkle";
            btnKayitEkle.Size = new Size(94, 55);
            btnKayitEkle.TabIndex = 11;
            btnKayitEkle.Text = "Öğrenci Ekle";
            btnKayitEkle.UseVisualStyleBackColor = true;
            btnKayitEkle.Click += btnKayitEkle_Click;
            // 
            // dgvOgrenciler
            // 
            dgvOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgrenciler.Columns.AddRange(new DataGridViewColumn[] { colAd, colSoyad, colBolum, colSınıf, colNumara });
            dgvOgrenciler.Location = new Point(343, 41);
            dgvOgrenciler.Name = "dgvOgrenciler";
            dgvOgrenciler.RowHeadersWidth = 51;
            dgvOgrenciler.Size = new Size(445, 188);
            dgvOgrenciler.TabIndex = 12;
            // 
            // colAd
            // 
            colAd.HeaderText = "Ad";
            colAd.MinimumWidth = 6;
            colAd.Name = "colAd";
            colAd.Width = 125;
            // 
            // colSoyad
            // 
            colSoyad.HeaderText = "Soyad";
            colSoyad.MinimumWidth = 6;
            colSoyad.Name = "colSoyad";
            colSoyad.Width = 125;
            // 
            // colBolum
            // 
            colBolum.HeaderText = "Bölüm";
            colBolum.MinimumWidth = 6;
            colBolum.Name = "colBolum";
            colBolum.Width = 125;
            // 
            // colSınıf
            // 
            colSınıf.HeaderText = "Sınıf";
            colSınıf.MinimumWidth = 6;
            colSınıf.Name = "colSınıf";
            colSınıf.Width = 125;
            // 
            // colNumara
            // 
            colNumara.HeaderText = "Numara";
            colNumara.MinimumWidth = 6;
            colNumara.Name = "colNumara";
            colNumara.Width = 125;
            // 
            // btnKayitSil
            // 
            btnKayitSil.Location = new Point(187, 293);
            btnKayitSil.Name = "btnKayitSil";
            btnKayitSil.Size = new Size(94, 55);
            btnKayitSil.TabIndex = 13;
            btnKayitSil.Text = "Öğrenci Sil";
            btnKayitSil.UseVisualStyleBackColor = true;
            btnKayitSil.Click += btnKayitSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKayitSil);
            Controls.Add(dgvOgrenciler);
            Controls.Add(btnKayitEkle);
            Controls.Add(txtBolum);
            Controls.Add(txtSinif);
            Controls.Add(txtNumara);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtNumara;
        private TextBox txtSinif;
        private TextBox txtBolum;
        private Button btnKayitEkle;
        private DataGridView dgvOgrenciler;
        private DataGridViewTextBoxColumn colAd;
        private DataGridViewTextBoxColumn colSoyad;
        private DataGridViewTextBoxColumn colBolum;
        private DataGridViewTextBoxColumn colSınıf;
        private DataGridViewTextBoxColumn colNumara;
        private Button btnKayitSil;
    }
}
