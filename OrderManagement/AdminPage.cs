using OrderManagement.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagement
{
    public partial class frmAdminPage : Form
    {
        public frmAdminPage()
        {
            InitializeComponent();
            ApplicationDbContext context = new ApplicationDbContext();
            var siparisList = context.Orders.ToList();
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.Columns.Clear(); 

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Ürün Adı",
                Name = "ProductName"
            });

            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerName",
                HeaderText = "Müşteri",
                Name = "CustomerName"
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedDate",
                HeaderText = "Siparişin Verildiği Tarih",
                Name = "CreatedDate"
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EndDate",
                HeaderText = "Sipariş Teslim Tarihi",
                Name = "EndDate"
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Piece",
                HeaderText = "Sipariş Adedi",
                Name = "Piece"
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Adress",
                HeaderText = "Sipariş Nereye Teslim Edilecek",
                Name = "Adress"
            });
            dgvOrders.DataSource = siparisList;
        }
    }
}
