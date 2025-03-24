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
            var customerList = context.Users.Where(u => u.Role == "Musteri").ToList();
            var customerListNoOrders = context.Users.Where(user => !context.Orders.Any(order => order.CustomerName == user.UserName) && user.UserName != "Bimosa").ToList();
            dgvOrders.AutoGenerateColumns = false;
            dgvCustmers.AutoGenerateColumns = false;
            dgvCustomersNoOrder.AutoGenerateColumns = false;

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
            dgvCustmers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FirstName",
                HeaderText = "Ad",
                Name = "FirstName"
            });
            dgvCustmers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LastName",
                HeaderText = "Soyad",
                Name = "LastName"
            });
            dgvCustmers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PhoneNumber",
                HeaderText = "Telefon",
                Name = "PhoneNumber"
            });
            dgvCustmers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CompanyName",
                HeaderText = "Şirket",
                Name = "CompanyName"
            });

            dgvCustomersNoOrder.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FirstName",
                HeaderText = "Ad",
                Name = "FirstName"
            });
            dgvCustomersNoOrder.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LastName",
                HeaderText = "Soyad",
                Name = "LastName"
            });
            dgvOrders.DataSource = siparisList;
            dgvCustmers.DataSource = customerList;
            dgvCustomersNoOrder.DataSource = customerListNoOrders;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustmers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomersNoOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
