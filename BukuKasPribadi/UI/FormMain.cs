using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BukuKasPribadi.UI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pemasukkanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPemasukkan fku = new FormPemasukkan();
            fku.Show();
        }

        private void pengeluaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPengeluaran fku = new FormPengeluaran();
            fku.Show();
        }

        private void hutangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtang fku = new FormUtang();
            fku.Show();
        }

        private void piutangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPiutang fku = new FormPiutang();
            fku.Show();
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKeuangan fku = new FormKeuangan();
            fku.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout fku = new FormAbout();
            fku.Show();
        }
    }
}
