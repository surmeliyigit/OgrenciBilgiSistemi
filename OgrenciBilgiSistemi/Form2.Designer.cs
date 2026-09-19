namespace OgrenciBilgiSistemi
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblOgrenci = new Label();
            lblOgrenciAdi = new Label();
            lblNumara = new Label();
            lblOgrenciNo = new Label();
            lblDers = new Label();
            label4 = new Label();
            txtDers = new TextBox();
            txtVize = new TextBox();
            btnDersEkle = new Button();
            btnDersSil = new Button();
            dgvDersler = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            lblOrtalama = new Label();
            lblGenelOrtalama = new Label();
            txtFinal = new TextBox();
            label2 = new Label();
            txtAkts = new TextBox();
            lblAkts = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDersler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(128, 18);
            label1.Name = "label1";
            label1.Size = new Size(296, 35);
            label1.TabIndex = 0;
            label1.Text = "DERS VE NOT BİLGİLERİ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOgrenci
            // 
            lblOgrenci.AutoSize = true;
            lblOgrenci.Location = new Point(45, 66);
            lblOgrenci.Name = "lblOgrenci";
            lblOgrenci.Size = new Size(95, 20);
            lblOgrenci.TabIndex = 1;
            lblOgrenci.Text = "Öğrenci Adı :";
            // 
            // lblOgrenciAdi
            // 
            lblOgrenciAdi.AutoSize = true;
            lblOgrenciAdi.Location = new Point(146, 66);
            lblOgrenciAdi.Name = "lblOgrenciAdi";
            lblOgrenciAdi.Size = new Size(27, 20);
            lblOgrenciAdi.TabIndex = 2;
            lblOgrenciAdi.Text = "___";
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(354, 66);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(36, 20);
            lblNumara.TabIndex = 3;
            lblNumara.Text = "No :";
            // 
            // lblOgrenciNo
            // 
            lblOgrenciNo.AutoSize = true;
            lblOgrenciNo.Location = new Point(399, 64);
            lblOgrenciNo.Name = "lblOgrenciNo";
            lblOgrenciNo.Size = new Size(27, 20);
            lblOgrenciNo.TabIndex = 4;
            lblOgrenciNo.Text = "___";
            // 
            // lblDers
            // 
            lblDers.AutoSize = true;
            lblDers.Location = new Point(40, 110);
            lblDers.Name = "lblDers";
            lblDers.Size = new Size(73, 20);
            lblDers.TabIndex = 5;
            lblDers.Text = "Ders Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 146);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 7;
            label4.Text = "Vize :";
            // 
            // txtDers
            // 
            txtDers.Location = new Point(117, 107);
            txtDers.Name = "txtDers";
            txtDers.Size = new Size(125, 27);
            txtDers.TabIndex = 8;
            // 
            // txtVize
            // 
            txtVize.Location = new Point(117, 143);
            txtVize.Name = "txtVize";
            txtVize.Size = new Size(56, 27);
            txtVize.TabIndex = 9;
            // 
            // btnDersEkle
            // 
            btnDersEkle.Location = new Point(41, 264);
            btnDersEkle.Name = "btnDersEkle";
            btnDersEkle.Size = new Size(94, 29);
            btnDersEkle.TabIndex = 10;
            btnDersEkle.Text = "Ders Ekle";
            btnDersEkle.UseVisualStyleBackColor = true;
            btnDersEkle.Click += btnDersEkle_Click;
            // 
            // btnDersSil
            // 
            btnDersSil.Location = new Point(176, 264);
            btnDersSil.Name = "btnDersSil";
            btnDersSil.Size = new Size(94, 29);
            btnDersSil.TabIndex = 11;
            btnDersSil.Text = "Ders Sil";
            btnDersSil.UseVisualStyleBackColor = true;
            btnDersSil.Click += btnDersSil_Click;
            // 
            // dgvDersler
            // 
            dgvDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDersler.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column4 });
            dgvDersler.Location = new Point(40, 337);
            dgvDersler.Name = "dgvDersler";
            dgvDersler.RowHeadersWidth = 51;
            dgvDersler.Size = new Size(641, 117);
            dgvDersler.TabIndex = 12;
            // 
            // Column1
            // 
            Column1.HeaderText = "Ders Adı";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Vize";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Final";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Akts";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ortalama";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // lblOrtalama
            // 
            lblOrtalama.AutoSize = true;
            lblOrtalama.Location = new Point(196, 467);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(78, 20);
            lblOrtalama.TabIndex = 13;
            lblOrtalama.Text = "Ortalama :";
            // 
            // lblGenelOrtalama
            // 
            lblGenelOrtalama.AutoSize = true;
            lblGenelOrtalama.Location = new Point(282, 467);
            lblGenelOrtalama.Name = "lblGenelOrtalama";
            lblGenelOrtalama.Size = new Size(28, 20);
            lblGenelOrtalama.TabIndex = 14;
            lblGenelOrtalama.Text = "0.0";
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(117, 178);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(56, 27);
            txtFinal.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 181);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 15;
            label2.Text = "Final :";
            // 
            // txtAkts
            // 
            txtAkts.Location = new Point(117, 216);
            txtAkts.Name = "txtAkts";
            txtAkts.Size = new Size(56, 27);
            txtAkts.TabIndex = 18;
            // 
            // lblAkts
            // 
            lblAkts.AutoSize = true;
            lblAkts.Location = new Point(40, 219);
            lblAkts.Name = "lblAkts";
            lblAkts.Size = new Size(78, 20);
            lblAkts.TabIndex = 17;
            lblAkts.Text = "Akts girin :";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 501);
            Controls.Add(txtAkts);
            Controls.Add(lblAkts);
            Controls.Add(txtFinal);
            Controls.Add(label2);
            Controls.Add(lblGenelOrtalama);
            Controls.Add(lblOrtalama);
            Controls.Add(dgvDersler);
            Controls.Add(btnDersSil);
            Controls.Add(btnDersEkle);
            Controls.Add(txtVize);
            Controls.Add(txtDers);
            Controls.Add(label4);
            Controls.Add(lblDers);
            Controls.Add(lblOgrenciNo);
            Controls.Add(lblNumara);
            Controls.Add(lblOgrenciAdi);
            Controls.Add(lblOgrenci);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvDersler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblOgrenci;
        private Label lblOgrenciAdi;
        private Label lblNumara;
        private Label lblOgrenciNo;
        private Label lblDers;
        private Label label4;
        private TextBox txtDers;
        private TextBox txtVize;
        private Button btnDersEkle;
        private Button btnDersSil;
        private DataGridView dgvDersler;
        private Label lblOrtalama;
        private Label lblGenelOrtalama;
        private TextBox txtFinal;
        private Label label2;
        private TextBox txtAkts;
        private Label lblAkts;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
    }
}