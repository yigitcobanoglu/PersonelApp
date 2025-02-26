namespace PersonelApp
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
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            lbPersonel = new ListBox();
            label7 = new Label();
            label2 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            label3 = new Label();
            txtYas = new TextBox();
            label4 = new Label();
            txtTelNo = new TextBox();
            label5 = new Label();
            txtAdres = new TextBox();
            label6 = new Label();
            btnEkle = new Button();
            btnSil = new Button();
            btnYeni = new Button();
            pbYeni = new PictureBox();
            btnKaydet = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbYeni).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user_avatar;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(113, 2);
            label1.Name = "label1";
            label1.Size = new Size(230, 45);
            label1.TabIndex = 0;
            label1.Text = "Personel Takibi";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(lbPersonel);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 428);
            panel2.TabIndex = 1;
            // 
            // lbPersonel
            // 
            lbPersonel.Dock = DockStyle.Fill;
            lbPersonel.FormattingEnabled = true;
            lbPersonel.Location = new Point(0, 27);
            lbPersonel.Name = "lbPersonel";
            lbPersonel.Size = new Size(198, 401);
            lbPersonel.TabIndex = 1;
            lbPersonel.SelectedIndexChanged += lbPersonel_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.BackColor = Color.PaleTurquoise;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(198, 27);
            label7.TabIndex = 0;
            label7.Text = "Personel List.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(266, 106);
            label2.Name = "label2";
            label2.Size = new Size(43, 32);
            label2.TabIndex = 2;
            label2.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(339, 106);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(272, 33);
            txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSoyad.Location = new Point(339, 147);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(272, 33);
            txtSoyad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(244, 147);
            label3.Name = "label3";
            label3.Size = new Size(79, 32);
            label3.TabIndex = 4;
            label3.Text = "Soyad";
            // 
            // txtYas
            // 
            txtYas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtYas.Location = new Point(339, 193);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(272, 33);
            txtYas.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(244, 264);
            label4.Name = "label4";
            label4.Size = new Size(83, 32);
            label4.TabIndex = 6;
            label4.Text = "Tel No";
            // 
            // txtTelNo
            // 
            txtTelNo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTelNo.Location = new Point(339, 263);
            txtTelNo.Name = "txtTelNo";
            txtTelNo.Size = new Size(272, 33);
            txtTelNo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(262, 194);
            label5.Name = "label5";
            label5.Size = new Size(47, 32);
            label5.TabIndex = 8;
            label5.Text = "Yaş";
            // 
            // txtAdres
            // 
            txtAdres.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAdres.Location = new Point(339, 324);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(272, 98);
            txtAdres.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(244, 324);
            label6.Name = "label6";
            label6.Size = new Size(74, 32);
            label6.TabIndex = 10;
            label6.Text = "Adres";
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Lime;
            btnEkle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnEkle.Location = new Point(653, 263);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(135, 39);
            btnEkle.TabIndex = 12;
            btnEkle.Text = "Ekle/Güncelle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Red;
            btnSil.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSil.ForeColor = SystemColors.Control;
            btnSil.Location = new Point(653, 415);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(135, 43);
            btnSil.TabIndex = 13;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnYeni
            // 
            btnYeni.BackColor = Color.Yellow;
            btnYeni.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnYeni.ForeColor = SystemColors.ControlText;
            btnYeni.Location = new Point(653, 313);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(135, 43);
            btnYeni.TabIndex = 14;
            btnYeni.Text = "Yeni";
            btnYeni.UseVisualStyleBackColor = false;
            btnYeni.Click += btnYeni_Click;
            // 
            // pbYeni
            // 
            pbYeni.Image = Properties.Resources._new;
            pbYeni.Location = new Point(199, 50);
            pbYeni.Name = "pbYeni";
            pbYeni.Size = new Size(67, 50);
            pbYeni.SizeMode = PictureBoxSizeMode.CenterImage;
            pbYeni.TabIndex = 15;
            pbYeni.TabStop = false;
            pbYeni.Click += pictureBox1_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = SystemColors.ActiveCaption;
            btnKaydet.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(653, 370);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(135, 39);
            btnKaydet.TabIndex = 16;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 478);
            Controls.Add(btnKaydet);
            Controls.Add(pbYeni);
            Controls.Add(btnYeni);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtAdres);
            Controls.Add(label6);
            Controls.Add(txtTelNo);
            Controls.Add(label5);
            Controls.Add(txtYas);
            Controls.Add(label4);
            Controls.Add(txtSoyad);
            Controls.Add(label3);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbYeni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label label3;
        private TextBox txtYas;
        private Label label4;
        private TextBox txtTelNo;
        private Label label5;
        private TextBox txtAdres;
        private Label label6;
        private Label label7;
        private ListBox lbPersonel;
        private Button btnEkle;
        private Button btnSil;
        private Button btnYeni;
        private PictureBox pbYeni;
        private PictureBox pictureBox2;
        private Button btnKaydet;
    }
}
