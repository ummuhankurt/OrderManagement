using Microsoft.IdentityModel.Tokens;
using OrderManagement.Context;
using OrderManagement.Models.Entities;
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
    public partial class frmOrder : Form
    {
        Order order = new Order();
        string customerName = "";
        public frmOrder()
        {
            InitializeComponent();
            ApplicationDbContext context = new ApplicationDbContext();
            var products = context.Products.ToList();
            cbxOrders.DataSource = products;
            cbxOrders.DisplayMember = "Name";
            cbxOrders.ValueMember = "Id";
            

        }

        public void SetCustomer(string name)
        {
            customerName = name;
        }
        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            try
            {
                if (String.IsNullOrEmpty(cbxOrders.Text))
                {
                    MessageBox.Show("Ürün seçimi yapınız !");
                    return;
                }
                if (String.IsNullOrEmpty(siparisTeslimTarihi.SelectionEnd.Date.ToString()))
                {
                    MessageBox.Show("Teslim tarihi boş bırakılamaz !");
                    return;
                }
                if(String.IsNullOrEmpty(txtSiparisTeslimAdresi.Text))
                {
                    MessageBox.Show("Teslimat adresi boş bırakılamaz !");
                    return;
                }
                if (String.IsNullOrEmpty(txtSiparisAdet.Text))
                {
                    MessageBox.Show("Sipariş adedi boş bırakılamaz !");
                    return;
                }
                order.ProductName = cbxOrders.Text;
                order.EndDate = siparisTeslimTarihi.SelectionEnd.Date;
                order.Adress = txtSiparisTeslimAdresi.Text;
                order.CreatedDate = DateTime.Now;
                order.Piece = Convert.ToInt32(txtSiparisAdet.Text);
                order.CustomerName = customerName;
;
                var result = context.Orders.Add(order);
                context.SaveChanges();
                if ((result.State == Microsoft.EntityFrameworkCore.EntityState.Unchanged) || result.State == Microsoft.EntityFrameworkCore.EntityState.Added)
                {
                    MessageBox.Show("Siparişiniz alınmıştır.");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen tüm alanları doldurduğunuzdan emin olun !");
            }
           

        }
       
    }
}
