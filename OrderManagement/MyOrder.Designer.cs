namespace OrderManagement
{
    partial class MyOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyOrder));
            dgvMyOrder = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMyOrder).BeginInit();
            SuspendLayout();
            // 
            // dgvMyOrder
            // 
            dgvMyOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyOrder.Location = new Point(60, 97);
            dgvMyOrder.Name = "dgvMyOrder";
            dgvMyOrder.Size = new Size(449, 300);
            dgvMyOrder.TabIndex = 0;
            // 
            // MyOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 453);
            Controls.Add(dgvMyOrder);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MyOrder";
            Text = "Siparişlerim ";
            ((System.ComponentModel.ISupportInitialize)dgvMyOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMyOrder;
    }
}