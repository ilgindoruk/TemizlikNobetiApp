namespace TemizlikNobetiApp
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnYeniSinif = new Button();
            lbOgrenciler = new ListBox();
            label1 = new Label();
            cbSinif = new ComboBox();
            panel2 = new Panel();
            label3 = new Label();
            lblTarih = new Label();
            bttnSec = new Button();
            pictureBox1 = new PictureBox();
            btnYeniOgrenci = new Button();
            label2 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            lblBuhaftaSira = new Label();
            dtpTarih = new DateTimePicker();
            btnOnayla = new Button();
            lbSecilenler = new ListBox();
            btnCikar = new Button();
            btnAta = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(btnYeniSinif);
            panel1.Controls.Add(lbOgrenciler);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbSinif);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 563);
            panel1.TabIndex = 0;
            // 
            // btnYeniSinif
            // 
            btnYeniSinif.BackColor = Color.Yellow;
            btnYeniSinif.Cursor = Cursors.Hand;
            btnYeniSinif.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnYeniSinif.Location = new Point(12, 514);
            btnYeniSinif.Name = "btnYeniSinif";
            btnYeniSinif.Size = new Size(142, 38);
            btnYeniSinif.TabIndex = 3;
            btnYeniSinif.Text = "Yeni Sınıf ";
            btnYeniSinif.UseVisualStyleBackColor = false;
            btnYeniSinif.Click += btnYeniSinif_Click;
            // 
            // lbOgrenciler
            // 
            lbOgrenciler.FormattingEnabled = true;
            lbOgrenciler.ItemHeight = 15;
            lbOgrenciler.Location = new Point(12, 65);
            lbOgrenciler.Name = "lbOgrenciler";
            lbOgrenciler.Size = new Size(142, 439);
            lbOgrenciler.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 5);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 1;
            label1.Text = "Sınıflar";
            // 
            // cbSinif
            // 
            cbSinif.Cursor = Cursors.Hand;
            cbSinif.FormattingEnabled = true;
            cbSinif.Location = new Point(12, 33);
            cbSinif.Name = "cbSinif";
            cbSinif.Size = new Size(142, 23);
            cbSinif.TabIndex = 0;
            cbSinif.SelectedValueChanged += cbSinif_SelectedValueChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DeepSkyBlue;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblTarih);
            panel2.Controls.Add(bttnSec);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnYeniOgrenci);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnCikar);
            panel2.Controls.Add(btnAta);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(168, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(612, 563);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(512, 550);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 10;
            label3.Text = "Ilgın Doruk Şahin";
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(434, 82);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(0, 15);
            lblTarih.TabIndex = 9;
            // 
            // bttnSec
            // 
            bttnSec.Location = new Point(0, 520);
            bttnSec.Name = "bttnSec";
            bttnSec.Size = new Size(75, 23);
            bttnSec.TabIndex = 7;
            bttnSec.Text = "Seç";
            bttnSec.UseVisualStyleBackColor = true;
            bttnSec.Click += bttnSec_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.mop;
            pictureBox1.Location = new Point(209, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnYeniOgrenci
            // 
            btnYeniOgrenci.BackColor = Color.Yellow;
            btnYeniOgrenci.Cursor = Cursors.Hand;
            btnYeniOgrenci.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnYeniOgrenci.Location = new Point(469, 512);
            btnYeniOgrenci.Name = "btnYeniOgrenci";
            btnYeniOgrenci.Size = new Size(142, 38);
            btnYeniOgrenci.TabIndex = 4;
            btnYeniOgrenci.Text = "Yeni Öğrenci";
            btnYeniOgrenci.UseVisualStyleBackColor = false;
            btnYeniOgrenci.Click += btnYeniOgrenci_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSteelBlue;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(163, 129);
            label2.Name = "label2";
            label2.Size = new Size(246, 18);
            label2.TabIndex = 0;
            label2.Text = "Bu Hafta Temizlik Yapacaklar";
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumPurple;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(dtpTarih);
            panel3.Controls.Add(btnOnayla);
            panel3.Controls.Add(lbSecilenler);
            panel3.Location = new Point(72, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(419, 359);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblBuhaftaSira);
            panel4.Location = new Point(50, 362);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 11;
            // 
            // lblBuhaftaSira
            // 
            lblBuhaftaSira.AutoSize = true;
            lblBuhaftaSira.Location = new Point(12, 15);
            lblBuhaftaSira.Name = "lblBuhaftaSira";
            lblBuhaftaSira.Size = new Size(163, 15);
            lblBuhaftaSira.TabIndex = 8;
            lblBuhaftaSira.Text = "Bu hafta temizlik yapacaklar:  ";
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(171, 277);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(200, 23);
            dtpTarih.TabIndex = 3;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.Yellow;
            btnOnayla.Cursor = Cursors.Hand;
            btnOnayla.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOnayla.Location = new Point(0, 325);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(120, 34);
            btnOnayla.TabIndex = 2;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // lbSecilenler
            // 
            lbSecilenler.BackColor = Color.LavenderBlush;
            lbSecilenler.FormattingEnabled = true;
            lbSecilenler.ItemHeight = 15;
            lbSecilenler.Location = new Point(50, 61);
            lbSecilenler.Name = "lbSecilenler";
            lbSecilenler.Size = new Size(321, 169);
            lbSecilenler.TabIndex = 1;
            // 
            // btnCikar
            // 
            btnCikar.BackColor = Color.Yellow;
            btnCikar.Cursor = Cursors.Hand;
            btnCikar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCikar.Location = new Point(503, -1);
            btnCikar.Name = "btnCikar";
            btnCikar.Size = new Size(108, 41);
            btnCikar.TabIndex = 1;
            btnCikar.Text = "Çıkar";
            btnCikar.UseVisualStyleBackColor = false;
            btnCikar.Click += btnCikar_Click;
            // 
            // btnAta
            // 
            btnAta.BackColor = Color.Yellow;
            btnAta.Cursor = Cursors.Hand;
            btnAta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAta.Location = new Point(0, 0);
            btnAta.Name = "btnAta";
            btnAta.Size = new Size(108, 41);
            btnAta.TabIndex = 0;
            btnAta.Text = "Ata";
            btnAta.UseVisualStyleBackColor = false;
            btnAta.Click += btnAta_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 563);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbSinif;
        private ListBox lbOgrenciler;
        private Label label1;
        private Button btnYeniSinif;
        private Panel panel2;
        private Panel panel3;
        private Button btnCikar;
        private Button btnAta;
        private Label label2;
        private ListBox lbSecilenler;
        private Button btnYeniOgrenci;
        private Button btnOnayla;
        private PictureBox pictureBox1;
        private Button bttnSec;
        private Label lblBuhaftaSira;
        private DateTimePicker dtpTarih;
        private System.Windows.Forms.Timer timer1;
        private Label lblTarih;
        private Label label3;
        private Panel panel4;
    }
}