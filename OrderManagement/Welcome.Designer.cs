namespace OrderManagement
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            btnSiparisVer = new Button();
            label1 = new Label();
            btnUyeOl = new Button();
            btnGirisYap = new Button();
            SuspendLayout();
            // 
            // btnSiparisVer
            // 
            btnSiparisVer.BackColor = SystemColors.ActiveCaption;
            btnSiparisVer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSiparisVer.Location = new Point(278, 157);
            btnSiparisVer.Name = "btnSiparisVer";
            btnSiparisVer.Size = new Size(208, 48);
            btnSiparisVer.TabIndex = 1;
            btnSiparisVer.Text = "Sipariş Ver";
            btnSiparisVer.UseVisualStyleBackColor = false;
            btnSiparisVer.Click += btnSiparisVer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(233, 95);
            label1.Name = "label1";
            label1.Size = new Size(325, 21);
            label1.TabIndex = 2;
            label1.Text = "BİMOSA SİPARİŞ PANELİNE HOŞGELDİNİZ";
            // 
            // btnUyeOl
            // 
            btnUyeOl.BackColor = SystemColors.ActiveCaption;
            btnUyeOl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUyeOl.Location = new Point(278, 229);
            btnUyeOl.Name = "btnUyeOl";
            btnUyeOl.Size = new Size(208, 48);
            btnUyeOl.TabIndex = 3;
            btnUyeOl.Text = "Üye Ol";
            btnUyeOl.UseVisualStyleBackColor = false;
            btnUyeOl.Click += btnUyeGiris_Click;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = SystemColors.ActiveCaption;
            btnGirisYap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGirisYap.Location = new Point(278, 302);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(208, 48);
            btnGirisYap.TabIndex = 4;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // frmWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 423);
            Controls.Add(btnGirisYap);
            Controls.Add(btnUyeOl);
            Controls.Add(label1);
            Controls.Add(btnSiparisVer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmWelcome";
            Text = "Bimosa Sipariş Yönetim Sistemi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSiparisVer;
        private Label label1;
        private Button btnUyeOl;
        private Button btnGirisYap;
    }
}
