using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            // Giriş yapan kişi müşteriyse farklı adminse farklı.
            ApplicationDbContext context = new ApplicationDbContext();
            Models.Entities.User user = new Models.Entities.User();
            if (String.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz !");
                return;
            }
            if (String.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Şifre boş bırakılamaz !");
                return;
            }
            user.UserName = txtKullaniciAdi.Text;
            user.Password = txtSifre.Text;
            var controlUser = context.Users.FirstOrDefault(u => u.UserName == user.UserName && u.Password == user.Password);
            if (controlUser != null) {
                if (controlUser.Role == "Musteri")
                {
                    frmOrder frmOrder = new frmOrder();
                    frmOrder.SetCustomer(txtKullaniciAdi.Text);
                    frmOrder.ShowDialog();
                }
                if (controlUser.Role == "Admin")
                {
                    frmAdminPage frmAdminPage = new frmAdminPage();
                    frmAdminPage.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı...");
                return;
            }
            
        }
    }
}
