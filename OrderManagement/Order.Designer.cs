namespace OrderManagement
{
    partial class frmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            label1 = new Label();
            label2 = new Label();
            siparisTeslimTarihi = new MonthCalendar();
            cbxOrders = new ComboBox();
            btnSiparisVer = new Button();
            label3 = new Label();
            txtSiparisTeslimAdresi = new TextBox();
            label4 = new Label();
            txtSiparisAdet = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(266, 69);
            label1.Name = "label1";
            label1.Size = new Size(96, 30);
            label1.TabIndex = 0;
            label1.Text = "Sipariş : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(33, 323);
            label2.Name = "label2";
            label2.Size = new Size(329, 30);
            label2.TabIndex = 4;
            label2.Text = "Siparişin Teslim Edileceği Tarih : ";
            // 
            // siparisTeslimTarihi
            // 
            siparisTeslimTarihi.Location = new Point(383, 314);
            siparisTeslimTarihi.Name = "siparisTeslimTarihi";
            siparisTeslimTarihi.TabIndex = 6;
            // 
            // cbxOrders
            // 
            cbxOrders.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cbxOrders.FormattingEnabled = true;
            cbxOrders.Location = new Point(383, 69);
            cbxOrders.Name = "cbxOrders";
            cbxOrders.Size = new Size(227, 29);
            cbxOrders.TabIndex = 7;
            // 
            // btnSiparisVer
            // 
            btnSiparisVer.BackColor = SystemColors.ActiveCaption;
            btnSiparisVer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSiparisVer.Location = new Point(389, 514);
            btnSiparisVer.Name = "btnSiparisVer";
            btnSiparisVer.Size = new Size(221, 37);
            btnSiparisVer.TabIndex = 8;
            btnSiparisVer.Text = "Sipariş Ver";
            btnSiparisVer.UseVisualStyleBackColor = false;
            btnSiparisVer.Click += btnSiparisVer_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(25, 178);
            label3.Name = "label3";
            label3.Size = new Size(337, 30);
            label3.TabIndex = 4;
            label3.Text = "Siparişin Teslim Edileceği Adres : ";
            // 
            // txtSiparisTeslimAdresi
            // 
            txtSiparisTeslimAdresi.Location = new Point(378, 175);
            txtSiparisTeslimAdresi.Multiline = true;
            txtSiparisTeslimAdresi.Name = "txtSiparisTeslimAdresi";
            txtSiparisTeslimAdresi.Size = new Size(232, 115);
            txtSiparisTeslimAdresi.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(630, 69);
            label4.Name = "label4";
            label4.Size = new Size(78, 30);
            label4.TabIndex = 0;
            label4.Text = "Adet : ";
            // 
            // txtSiparisAdet
            // 
            txtSiparisAdet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSiparisAdet.Location = new Point(723, 69);
            txtSiparisAdet.Mask = "000000";
            txtSiparisAdet.Name = "txtSiparisAdet";
            txtSiparisAdet.Size = new Size(100, 29);
            txtSiparisAdet.TabIndex = 11;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 637);
            Controls.Add(txtSiparisAdet);
            Controls.Add(txtSiparisTeslimAdresi);
            Controls.Add(btnSiparisVer);
            Controls.Add(cbxOrders);
            Controls.Add(siparisTeslimTarihi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmOrder";
            Text = "Sipariş Ver";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSiparis;
        private Label label2;
        private Button button1;
        private MonthCalendar siparisTeslimTarihi;
        private ComboBox cbxOrders;
        private Button btnSiparisVer;
        private Label label3;
        private TextBox txtSiparisTeslimAdresi;
        private Label label4;
        private MaskedTextBox txtSiparisAdet;
    }
}