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
    public partial class frmUyeOl : Form
    {
        public frmUyeOl()
        {
            InitializeComponent();
        }

        private void btnYeniMusteriUye1_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (String.IsNullOrEmpty(txtYeniUyeMusteriAd.Text))
            {
                MessageBox.Show("Müşteri adı boş bırakılamaz !");
                return;
            }
            if (String.IsNullOrEmpty(txtYeniUyeMusteriSoyad.Text))
            {
                MessageBox.Show("Müşteri soyadı boş bırakılamaz !");
                return;
            }

            if (String.IsNullOrEmpty(txtYenUyeMusteriKullaniciAdi.Text))
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz !");
                return;
            }
            if (String.IsNullOrEmpty(txtYeniUyeMusteriSifre.Text))
            {
                MessageBox.Show("Şifre boş bırakılamaz !");
                return;
            }

            if (String.IsNullOrEmpty(txtYeniUyePhoneNumber.Text))
            {
                MessageBox.Show("Telefon numarası boş bırakılamaz !");
                return;
            }
            user.FirstName = txtYeniUyeMusteriAd.Text;
            user.LastName = txtYeniUyeMusteriSoyad.Text;
            user.UserName = txtYenUyeMusteriKullaniciAdi.Text;
            user.Password = txtYeniUyeMusteriSifre.Text;
            user.PhoneNumber = txtYeniUyePhoneNumber.Text;
            user.Role = "Musteri";
            ApplicationDbContext context = new ApplicationDbContext();

            var ifUserExist = context.Users.FirstOrDefault(u => u.FirstName == user.FirstName && u.LastName == user.LastName && u.UserName == user.UserName && u.PhoneNumber == user.PhoneNumber);
            if (ifUserExist != null)
            {
                MessageBox.Show("Bu müşteri zaten kayıtlı. Giriş sayfasına yönlendiriliyorsunuz...");
                Task.Delay(2000);
                this.Hide();
                frmLogIn frmLogIn = new frmLogIn();
                frmLogIn.ShowDialog();

            }
            else
            {
                var result = context.Users.Add(user);
                context.SaveChanges();
                if ((result.State == Microsoft.EntityFrameworkCore.EntityState.Unchanged) || result.State == Microsoft.EntityFrameworkCore.EntityState.Added)
                {
                    MessageBox.Show("Kayıt başarılı. Giriş sayfasına yönlendiriliyorsunuz...");
                    Task.Delay(2000);

                    this.Hide();
                    frmLogIn frmLogIn = new frmLogIn();
                    frmLogIn.ShowDialog();

                }
            }
        }
    }
}
