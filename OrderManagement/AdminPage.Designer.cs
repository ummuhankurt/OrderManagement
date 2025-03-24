namespace OrderManagement
{
    partial class frmAdminPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminPage));
            lblAdminPage = new Label();
            dgvOrders = new DataGridView();
            applicationDbContextBindingSource = new BindingSource(components);
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dgvCustmers = new DataGridView();
            lblCustomer = new Label();
            dgvCustomersNoOrder = new DataGridView();
            lblCustmersNoOrder = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)applicationDbContextBindingSource).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustmers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomersNoOrder).BeginInit();
            SuspendLayout();
            // 
            // lblAdminPage
            // 
            lblAdminPage.AutoSize = true;
            lblAdminPage.BackColor = SystemColors.Control;
            lblAdminPage.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdminPage.Location = new Point(329, 53);
            lblAdminPage.Name = "lblAdminPage";
            lblAdminPage.Size = new Size(0, 32);
            lblAdminPage.TabIndex = 0;
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(3, 0);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.Size = new Size(1050, 372);
            dgvOrders.TabIndex = 1;
            // 
            // applicationDbContextBindingSource
            // 
            applicationDbContextBindingSource.DataSource = typeof(Context.ApplicationDbContext);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(584, 25);
            label1.Name = "label1";
            label1.Size = new Size(91, 30);
            label1.TabIndex = 2;
            label1.Text = "BIMOSA";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(57, 58);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1061, 400);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvOrders);
            tabPage1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1053, 372);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Siparişler";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblCustmersNoOrder);
            tabPage2.Controls.Add(lblCustomer);
            tabPage2.Controls.Add(dgvCustomersNoOrder);
            tabPage2.Controls.Add(dgvCustmers);
            tabPage2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1053, 372);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Müşteriler";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCustmers
            // 
            dgvCustmers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustmers.Location = new Point(19, 61);
            dgvCustmers.Name = "dgvCustmers";
            dgvCustmers.Size = new Size(474, 276);
            dgvCustmers.TabIndex = 0;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(234, 18);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(98, 25);
            lblCustomer.TabIndex = 1;
            lblCustomer.Text = "Müşteriler";
            // 
            // dgvCustomersNoOrder
            // 
            dgvCustomersNoOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomersNoOrder.Location = new Point(536, 61);
            dgvCustomersNoOrder.Name = "dgvCustomersNoOrder";
            dgvCustomersNoOrder.Size = new Size(474, 276);
            dgvCustomersNoOrder.TabIndex = 0;
            // 
            // lblCustmersNoOrder
            // 
            lblCustmersNoOrder.AutoSize = true;
            lblCustmersNoOrder.Location = new Point(556, 18);
            lblCustmersNoOrder.Name = "lblCustmersNoOrder";
            lblCustmersNoOrder.Size = new Size(431, 25);
            lblCustmersNoOrder.TabIndex = 1;
            lblCustmersNoOrder.Text = "Sistemde Kayıtlı Olup Sipariş Vermeyen Müşteriler";
            // 
            // frmAdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 514);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(lblAdminPage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAdminPage";
            Text = "Yönetici Paneli";
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)applicationDbContextBindingSource).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustmers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomersNoOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdminPage;
        private DataGridView dgvOrders;
        private BindingSource applicationDbContextBindingSource;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvCustmers;
        private Label lblCustmersNoOrder;
        private Label lblCustomer;
        private DataGridView dgvCustomersNoOrder;
    }
}