namespace OrderManagement
{
    partial class frmUyeOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUyeOl));
            lblMusteriAd = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtYeniUyeMusteriAd = new TextBox();
            txtYeniUyeMusteriSoyad = new TextBox();
            txtYenUyeMusteriKullaniciAdi = new TextBox();
            txtYeniUyeMusteriSifre = new TextBox();
            btnYeniMusteriUye = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            txtYeniUyeCompanyName = new TextBox();
            txtYeniUyePhoneNumber = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblMusteriAd
            // 
            lblMusteriAd.AutoSize = true;
            lblMusteriAd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMusteriAd.Location = new Point(185, 65);
            lblMusteriAd.Name = "lblMusteriAd";
            lblMusteriAd.Size = new Size(53, 30);
            lblMusteriAd.TabIndex = 0;
            lblMusteriAd.Text = "Ad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(156, 120);
            label1.Name = "label1";
            label1.Size = new Size(91, 30);
            label1.TabIndex = 1;
            label1.Text = "Soyad : ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(106, 171);
            label2.Name = "label2";
            label2.Size = new Size(156, 30);
            label2.TabIndex = 2;
            label2.Text = "Kullanıcı Adı : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(162, 224);
            label3.Name = "label3";
            label3.Size = new Size(76, 30);
            label3.TabIndex = 3;
            label3.Text = "Şifre : ";
            // 
            // txtYeniUyeMusteriAd
            // 
            txtYeniUyeMusteriAd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtYeniUyeMusteriAd.Location = new Point(305, 66);
            txtYeniUyeMusteriAd.Name = "txtYeniUyeMusteriAd";
            txtYeniUyeMusteriAd.Size = new Size(240, 29);
            txtYeniUyeMusteriAd.TabIndex = 4;
            // 
            // txtYeniUyeMusteriSoyad
            // 
            txtYeniUyeMusteriSoyad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtYeniUyeMusteriSoyad.Location = new Point(305, 124);
            txtYeniUyeMusteriSoyad.Name = "txtYeniUyeMusteriSoyad";
            txtYeniUyeMusteriSoyad.Size = new Size(240, 29);
            txtYeniUyeMusteriSoyad.TabIndex = 5;
            // 
            // txtYenUyeMusteriKullaniciAdi
            // 
            txtYenUyeMusteriKullaniciAdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtYenUyeMusteriKullaniciAdi.Location = new Point(305, 172);
            txtYenUyeMusteriKullaniciAdi.Name = "txtYenUyeMusteriKullaniciAdi";
            txtYenUyeMusteriKullaniciAdi.Size = new Size(240, 29);
            txtYenUyeMusteriKullaniciAdi.TabIndex = 6;
            // 
            // txtYeniUyeMusteriSifre
            // 
            txtYeniUyeMusteriSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtYeniUyeMusteriSifre.Location = new Point(305, 224);
            txtYeniUyeMusteriSifre.Name = "txtYeniUyeMusteriSifre";
            txtYeniUyeMusteriSifre.Size = new Size(240, 29);
            txtYeniUyeMusteriSifre.TabIndex = 7;
            txtYeniUyeMusteriSifre.UseSystemPasswordChar = true;
            // 
            // btnYeniMusteriUye
            // 
            btnYeniMusteriUye.BackColor = SystemColors.ActiveCaption;
            btnYeniMusteriUye.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYeniMusteriUye.Location = new Point(305, 389);
            btnYeniMusteriUye.Name = "btnYeniMusteriUye";
            btnYeniMusteriUye.Size = new Size(240, 35);
            btnYeniMusteriUye.TabIndex = 8;
            btnYeniMusteriUye.Text = "Üye Ol";
            btnYeniMusteriUye.UseVisualStyleBackColor = false;
            btnYeniMusteriUye.Click += btnYeniMusteriUye1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(59, 284);
            label4.Name = "label4";
            label4.Size = new Size(203, 30);
            label4.TabIndex = 9;
            label4.Text = "Telefon Numarası : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(59, 338);
            label5.Name = "label5";
            label5.Size = new Size(196, 30);
            label5.TabIndex = 9;
            label5.Text = "Şirket(Opsiyonel) :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(305, 338);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 29);
            textBox1.TabIndex = 7;
            // 
            // txtYeniUyeCompanyName
            // 
            txtYeniUyeCompanyName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtYeniUyeCompanyName.Location = new Point(305, 338);
            txtYeniUyeCompanyName.Name = "txtYeniUyeCompanyName";
            txtYeniUyeCompanyName.Size = new Size(240, 29);
            txtYeniUyeCompanyName.TabIndex = 7;
            // 
            // txtYeniUyePhoneNumber
            // 
            txtYeniUyePhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtYeniUyePhoneNumber.Location = new Point(305, 288);
            txtYeniUyePhoneNumber.Name = "txtYeniUyePhoneNumber";
            txtYeniUyePhoneNumber.Size = new Size(240, 29);
            txtYeniUyePhoneNumber.TabIndex = 10;
            // 
            // frmUyeOl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 481);
            Controls.Add(txtYeniUyePhoneNumber);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnYeniMusteriUye);
            Controls.Add(txtYeniUyeCompanyName);
            Controls.Add(textBox1);
            Controls.Add(txtYeniUyeMusteriSifre);
            Controls.Add(txtYenUyeMusteriKullaniciAdi);
            Controls.Add(txtYeniUyeMusteriSoyad);
            Controls.Add(txtYeniUyeMusteriAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblMusteriAd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUyeOl";
            Text = "Müşteri Üye Olma Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMusteriAd;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtYeniUyeMusteriAd;
        private TextBox txtYeniUyeMusteriSoyad;
        private TextBox txtYenUyeMusteriKullaniciAdi;
        private TextBox txtYeniUyeMusteriSifre;
        private Button btnYeniMusteriUye;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox txtYeniUyeCompanyName;
        private MaskedTextBox txtYeniUyePhoneNumber;
    }
}