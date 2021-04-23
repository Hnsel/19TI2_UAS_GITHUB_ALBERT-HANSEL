using BukuKasPribadi.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BukuKasPribadi
{
    public partial class FormLogin : Form
    {
        Controller.LoginController cek = new Controller.LoginController();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cek.loginValidator(txtNama.Text, txtPassword.Text))
            {
                MessageBox.Show("Berhasil Login");
                FormMain fhu = new FormMain();
                fhu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Gagal Login");
            }
        }
    }
}
