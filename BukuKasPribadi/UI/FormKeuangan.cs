using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BukuKasPribadi.UI
{
    public partial class FormKeuangan : Form
    {

        private const string connectString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:/Pengembangan Piranti Lunak/BukuKasPribadi/Buku_Kas_Pribadi.accdb; Persist Security Info=False;";

        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();

        public FormKeuangan()
        {
            InitializeComponent();
        }

        private void SumPemasukkan()
        {
            string query = "SELECT SUM (Nominal_Pemasukkan) FROM Pemasukkan";
            using (System.Data.IDbCommand command = new System.Data.OleDb.OleDbCommand(query, dbConn))
            {
                dbConn.Open();
                object result = command.ExecuteScalar();
                txtTPemasukkan.Text = Convert.ToString(result);
                dbConn.Close();
            }
        }

        private void SumPengeluaran()
        {
            string query = "SELECT SUM (Nominal_Pengeluaran) FROM Pengeluaran";
            using (System.Data.IDbCommand command = new System.Data.OleDb.OleDbCommand(query, dbConn))
            {
                dbConn.Open();
                object result = command.ExecuteScalar();
                txtTPengeluaran.Text = Convert.ToString(result);
                dbConn.Close();
            }
        }

        private void SumUtang()
        {
            string query = "SELECT SUM (Nominal_Utang) FROM Utang";
            using (System.Data.IDbCommand command = new System.Data.OleDb.OleDbCommand(query, dbConn))
            {
                dbConn.Open();
                object result = command.ExecuteScalar();
                txtTUtang.Text = Convert.ToString(result);
                dbConn.Close();
            }
        }

        private void SumPiutang()
        {
            string query = "SELECT SUM (Nominal_Piutang) FROM Piutang";
            using (System.Data.IDbCommand command = new System.Data.OleDb.OleDbCommand(query, dbConn))
            {
                dbConn.Open();
                object result = command.ExecuteScalar();
                txtTPiutang.Text = Convert.ToString(result);
                dbConn.Close();
            }
        }

        private void txtTPemasukkan_Click(object sender, EventArgs e)
        {
            SumPemasukkan();
        }

        private void txtTPengeluaran_Click(object sender, EventArgs e)
        {
            SumPengeluaran();
        }
        
        private void txtTUtang_Click(object sender, EventArgs e)
        {
            SumUtang();
        }

        private void txtTPiutang_Click(object sender, EventArgs e)
        {
            SumPiutang();
        }

        private void rtbTotal_Click(object sender, EventArgs e)
        {
            try
            {
                int hasil = 0;
                int hasil_pemasukkan = 0;
                if (txtTPemasukkan.Text == "")
                {
                    hasil_pemasukkan = 0;
                }
                else
                {
                    hasil_pemasukkan = Int32.Parse(txtTPemasukkan.Text);
                }

                int hasil_pengeluaran = 0;
                if (txtTPengeluaran.Text == "")
                {
                    hasil_pengeluaran = 0;
                }
                else
                {
                    hasil_pengeluaran = Int32.Parse(txtTPengeluaran.Text);
                }

                int hasil_utang = 0;
                if (txtTUtang.Text == "")
                {
                    hasil_utang = 0;
                }
                else
                {
                    hasil_utang = Int32.Parse(txtTUtang.Text);
                }

                int hasil_piutang = 0;
                if (txtTPiutang.Text == "")
                {
                    hasil_piutang = 0;
                }
                else
                {
                    hasil_piutang = Int32.Parse(txtTPiutang.Text);
                }
                hasil = hasil_pemasukkan - hasil_pengeluaran + hasil_utang - hasil_piutang;
                rtbTotal.Text = hasil.ToString();
            }

            catch(Exception)
            {
                MessageBox.Show("Anda harus mengklik inputan lainnya dulu");
            }
        }

        private void txtTPemasukkan_MouseEnter(object sender, EventArgs e)
        {
            if(txtTPemasukkan.Text == "")
            {
                txtTPemasukkan.Text = "Klik untuk menampilkan inputan";
            }
        }

        private void txtTPengeluaran_MouseEnter(object sender, EventArgs e)
        {
            if (txtTPengeluaran.Text == "")
            {
                txtTPengeluaran.Text = "Klik untuk menampilkan inputan";
            }
        }

        private void txtTUtang_MouseEnter(object sender, EventArgs e)
        {
            if (txtTUtang.Text == "")
            {
                txtTUtang.Text = "Klik untuk menampilkan inputan";
            }
        }

        private void txtTPiutang_MouseEnter(object sender, EventArgs e)
        {
            if (txtTPiutang.Text == "")
            {
                txtTPiutang.Text = "Klik untuk menampilkan inputan";
            }
        }

        private void rtbTotal_MouseEnter(object sender, EventArgs e)
        {
            if (rtbTotal.Text == "")
            {
                rtbTotal.Text = "Tunggu hingga inputan lainnya muncul lalu klik untuk menampilkan inputan";
            }
        }
    }
}
