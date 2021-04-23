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
using BukuKasPribadi.Model;

namespace BukuKasPribadi.UI
{
    public partial class FormPengeluaran : Form
    {
        private const string connectString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:/Pengembangan Piranti Lunak/BukuKasPribadi/Buku_Kas_Pribadi.accdb; Persist Security Info=False;";

        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();

        public string Nominal_pengeluaran { get; private set; }

        public FormPengeluaran()
        {
            InitializeComponent();
        }

        private void populate(Pengeluaran obj)
        {
            dgvPengeluaran.Rows.Add(obj.Nominal_pengeluaran, obj.Tanggal_pengeluaran, obj.Jam_pengeluaran, obj.Keterangan_pengeluaran);
        }

        void loadDataPengeluaran(string Nominal_pengeluran)
        {
            dgvPengeluaran.Rows.Clear();
            try
            {
                String sql = "SELECT * FROM Pengeluaran where Nominal_Pengeluaran like '%" + Nominal_pengeluaran + "%'";
                cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    Pengeluaran obj = new Pengeluaran();
                    obj.Nominal_pengeluaran = Int32.Parse(row[1].ToString());
                    obj.Tanggal_pengeluaran = DateTime.Parse(row[2].ToString());
                    obj.Jam_pengeluaran = row[3].ToString();
                    obj.Keterangan_pengeluaran = row[4].ToString();
                    populate(obj);
                }
                dbConn.Close(); //CLEAR DATATABLE
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.Close();
            }
        }

        private void simpan(Pengeluaran obj)
        {
            const string sql = "insert into Pengeluaran(Nominal_Pengeluaran, Tanggal, Jam, Keterangan ) values(@n_pengeluaran, @t_pengeluaran, @j_pengeluaran, @k_pengeluaran)";
            cmd = new OleDbCommand(sql, dbConn);
            cmd.Parameters.AddWithValue("@n_pengeluaran", obj.Nominal_pengeluaran);
            cmd.Parameters.AddWithValue("@t_pengeluaran", obj.Tanggal_pengeluaran);
            cmd.Parameters.AddWithValue("@j_pengeluaran", obj.Jam_pengeluaran);
            cmd.Parameters.AddWithValue("@k_pengeluaran", obj.Keterangan_pengeluaran);

            try
            {
                dbConn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Berhasil Simpan Data ke Database");
                }
                dbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.Close();
            }
        }

        private void update(Pengeluaran obj)
        {
            string sql = "update Pengeluaran set Nominal_Pengeluaran='" + obj.Nominal_pengeluaran + "', Tanggal='" + obj.Tanggal_pengeluaran + "', Jam='" + obj.Jam_pengeluaran + "' where Keterangan='" + obj.Keterangan_pengeluaran + "'";
            cmd = new OleDbCommand(sql, dbConn);

            try
            {
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd) { UpdateCommand = dbConn.CreateCommand() };

                adapter.UpdateCommand.CommandText = sql;
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Berhasil ubah Data ke Database");
                }
                dbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.Close();
            }
        }
        private void delete(Pengeluaran obj)
        {
            string sql = "delete from Pengeluaran where Keterangan='" + obj.Keterangan_pengeluaran + "'";
            cmd = new OleDbCommand(sql, dbConn);

            try
            {
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd) { DeleteCommand = dbConn.CreateCommand() };

                adapter.DeleteCommand.CommandText = sql;
                if (adapter.DeleteCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Berhasil delete data ke database");
                }
                dbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConn.Close();
            }
        }

        private void btnSimpanPengeluaran_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Kamu ingin menyimpan data ?", "Simpan Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            int temp;
            if (dr == DialogResult.Yes)
            {
                try
                {
                    int nominal = Int32.Parse(txtNPengeluaran.Text.Trim());
                    txtJPengeluaran.Text = DateTime.Now.ToLongTimeString();
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvPengeluaran);
                    row.Cells[0].Value = txtNPengeluaran.Text.Trim();
                    row.Cells[1].Value = dtp_pengeluaran.Text.Trim();
                    row.Cells[2].Value = txtJPengeluaran.Text.Trim();
                    row.Cells[3].Value = txtKPengeluaran.Text.Trim();
                    dgvPengeluaran.Rows.Add(row);

                    Pengeluaran obj = new Pengeluaran();
                    obj.Nominal_pengeluaran = Int32.Parse(txtNPengeluaran.Text.Trim());
                    obj.Tanggal_pengeluaran = DateTime.Parse(dtp_pengeluaran.Text.Trim());
                    obj.Jam_pengeluaran = txtJPengeluaran.Text.Trim();
                    obj.Keterangan_pengeluaran = txtKPengeluaran.Text.Trim();
                    simpan(obj); //simpan data ke dalam database

                    MessageBox.Show("Data berhasil di simpan");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Anda harus memasukkan angka pada nominal");
                }
            }
        }

        private void btnResetPengeluaran_Click(object sender, EventArgs e)
        {
            txtNPengeluaran.Text = dtp_pengeluaran.Text = txtKPengeluaran.Text = String.Empty;
        }

        private void btnUpdatePengeluaran_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah kamu ingin mengupdate data?", "Update data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            int temp;
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Pengeluaran obj = new Pengeluaran();
                    obj.Nominal_pengeluaran = Int32.Parse(txtNPengeluaran.Text.Trim());
                    obj.Tanggal_pengeluaran = DateTime.Parse(dtp_pengeluaran.Text.Trim());
                    obj.Jam_pengeluaran = txtJPengeluaran.Text.Trim();
                    obj.Keterangan_pengeluaran = txtKPengeluaran.Text.Trim();
                    update(obj); //update data ke dalam database
                    loadDataPengeluaran("");

                    MessageBox.Show("Data berhasil diupdate");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Anda harus memasukkan angka pada harga");
                }
            }
        }

        private void btnDeletePengeluaran_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah kamu ingin menghapus data?", "Delete data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            int temp;
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Pengeluaran obj = new Pengeluaran();
                    obj.Nominal_pengeluaran = Int32.Parse(txtNPengeluaran.Text.Trim());
                    obj.Tanggal_pengeluaran = DateTime.Parse(dtp_pengeluaran.Text.Trim());
                    obj.Jam_pengeluaran = txtJPengeluaran.Text.Trim();
                    obj.Keterangan_pengeluaran = txtKPengeluaran.Text.Trim();
                    delete(obj); // delete data ke dalam database
                    loadDataPengeluaran("");
                    MessageBox.Show("Data berhasil di hapus");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Anda harus memilih data yang ingin dihapus");
                }
            }
        }

        private void FormPengeluaran_Load(object sender, EventArgs e)
        {
            loadDataPengeluaran("");
        }

        private void dgvPengeluaran_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = dgvPengeluaran.Rows[e.RowIndex];
            txtNPengeluaran.Text = baris.Cells[0].Value.ToString();
            dtp_pengeluaran.Text = baris.Cells[1].Value.ToString();
            txtJPengeluaran.Text = baris.Cells[2].Value.ToString();
            txtKPengeluaran.Text = baris.Cells[3].Value.ToString();
        }
    }
}
