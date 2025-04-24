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
    public partial class MyOrder : Form
    {
        public MyOrder(string customerName)
        {
            InitializeComponent();
            ApplicationDbContext context = new ApplicationDbContext();
            var siparisList = context.Orders.Where(o => o.CustomerName == customerName).ToList();
            dgvMyOrder.AutoGenerateColumns = false;
            dgvMyOrder.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Ürün Adı",
                Name = "ProductName"
            });
            dgvMyOrder.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Piece",
                HeaderText = "Sipariş Adedi",
                Name = "Piece"
            });
           
            dgvMyOrder.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Adress",
                HeaderText = "Adres",
                Name = "Adress"
            });
            dgvMyOrder.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedDate",
                HeaderText = "Siparişi Verdiğiniz Tarih",
                Name = "CreatedDate"
            });
            dgvMyOrder.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EndDate",
                HeaderText = "Siparişin son teslim tarihi",
                Name = "EndDate"
            });
            dgvMyOrder.DataSource = siparisList;
            dgvMyOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
