﻿namespace OrderManagement
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
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)applicationDbContextBindingSource).BeginInit();
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
            dgvOrders.Location = new Point(74, 133);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.Size = new Size(862, 359);
            dgvOrders.TabIndex = 1;
            // 
            // applicationDbContextBindingSource
            // 
            applicationDbContextBindingSource.DataSource = typeof(Context.ApplicationDbContext);
            // 
            // frmAdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 552);
            Controls.Add(dgvOrders);
            Controls.Add(lblAdminPage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAdminPage";
            Text = "Siparişler";
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)applicationDbContextBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdminPage;
        private DataGridView dgvOrders;
        private BindingSource applicationDbContextBindingSource;
    }
}