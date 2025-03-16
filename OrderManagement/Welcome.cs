using OrderManagement.Context;

namespace OrderManagement
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void btnUyeGiris_Click(object sender, EventArgs e)
        {
            frmUyeOl uyeOlForm = new frmUyeOl();
            uyeOlForm.ShowDialog();
        }


        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            frmLogIn frmLogIn = new frmLogIn();
            frmLogIn.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            frmLogIn frmLog = new frmLogIn();
            frmLog.ShowDialog();

        }
    }
}
