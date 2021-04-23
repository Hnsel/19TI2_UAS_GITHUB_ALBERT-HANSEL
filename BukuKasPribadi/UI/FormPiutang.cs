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
    public partial class FormPiutang : Form
    {
        private const string connectString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:/Pengembangan Piranti Lunak/BukuKasPribadi/Buku_Kas_Pribadi.accdb; Persist Security Info=False;";

        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();

        public FormPiutang()
        {
            InitializeComponent();
        }
        private void populate(Piutang obj)
        {
            dgvPiutang.Rows.Add(obj.Nominal_piutang, obj.Nama_piutang, obj.Tanggal_piutang, obj.Jam_piutang, obj.Keterangan_piutang);
        }
        void loadDataPiutang(string Nominal_piutang)
        {
            dgvPiutang.Rows.Clear();
            try
            {
                String sql = "SELECT * FROM Piutang where Nominal_Piutang like '%" + Nominal_piutang + "%'";
                cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    Piutang obj = new Piutang();
                    obj.Nominal_piutang = Int32.Parse(row[1].ToString());
                    obj.Nama_piutang = row[2].ToString();
                    obj.Tanggal_piutang = DateTime.Parse(row[3].ToString());
                    obj.Jam_piutang = row[4].ToString();
                    obj.Keterangan_piutang = row[5].ToString();
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
        private void simpan(Piutang obj)
        {
            const string sql = "insert into Piutang(Nominal_Piutang, Nama_Pengutang, Tanggal, Jam, Keterangan ) values(@n_piutang, @np_piutang, @t_piutang, @j_piutang, @k_piutang)";
            cmd = new OleDbCommand(sql, dbConn);
            cmd.Parameters.AddWithValue("@n_piutang", obj.Nominal_piutang);
            cmd.Parameters.AddWithValue("@np_piutang", obj.Nama_piutang);
            cmd.Parameters.AddWithValue("@t_piutang", obj.Tanggal_piutang);
            cmd.Parameters.AddWithValue("@j_piutang", obj.Jam_piutang);
            cmd.Parameters.AddWithValue("@k_piutang", obj.Keterangan_piutang);

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
        private void update(Piutang obj)
        {
            string sql = "update Piutang set Nominal_Piutang='" + obj.Nominal_piutang + "', Nama_Pengutang='" + obj.Nama_piutang + "', Tanggal='" + obj.Tanggal_piutang + "', Jam='" + obj.Jam_piutang + "' where Keterangan='" + obj.Keterangan_piutang + "'";
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
        private void delete(Piutang obj)
        {
            string sql = "delete from Piutang where Keterangan='" + obj.Keterangan_piutang + "'";
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

        private void btnSimpanPiUtang_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Kamu ingin menyimpan data ?", "Simpan Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            int temp;
            if (dr == DialogResult.Yes)
            {
                try
                {
                    int nominal = Int32.Parse(txtNPiutang.Text.Trim());
                    txtJPiutang.Text = DateTime.Now.ToLongTimeString();
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvPiutang);
                    row.Cells[0].Value = txtNPiutang.Text.Trim();
                    row.Cells[1].Value = txtNamaPengutang.Text.Trim();
                    row.Cells[2].Value = dtp_piutang.Text.Trim();
                    row.Cells[3].Value = txtJPiutang.Text.Trim();
                    row.Cells[4].Value = txtKPiutang.Text.Trim();
                    dgvPiutang.Rows.Add(row);

                    Piutang obj = new Piutang();
                    obj.Nominal_piutang = Int32.Parse(txtNPiutang.Text.Trim());
                    obj.Nama_piutang = txtNamaPengutang.Text.Trim();
                    obj.Tanggal_piutang = DateTime.Parse(dtp_piutang.Text.Trim());
                    obj.Jam_piutang = txtJPiutang.Text.Trim();
                    obj.Keterangan_piutang = txtKPiutang.Text.Trim();
                    simpan(obj); //simpan data ke dalam database

                    MessageBox.Show("Data berhasil di simpan");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Anda harus memasukkan angka pada nominal");
                }
            }
        }

        private void btnResetPiutang_Click(object sender, EventArgs e)
        {
            txtNPiutang.Text = txtNamaPengutang.Text = dtp_piutang.Text = txtKPiutang.Text = String.Empty;
        }

        private void btnUpdatePiutang_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah kamu ingin mengupdate data?", "Update data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            int temp;
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Piutang obj = new Piutang();
                    obj.Nominal_piutang = Int32.Parse(txtNPiutang.Text.Trim());
                    obj.Nama_piutang = txtNamaPengutang.Text.Trim();
                    obj.Tanggal_piutang = DateTime.Parse(dtp_piutang.Text.Trim());
                    obj.Jam_piutang = txtJPiutang.Text.Trim();
                    obj.Keterangan_piutang = txtKPiutang.Text.Trim();
                    update(obj); //update data ke dalam database
                    loadDataPiutang("");

                    MessageBox.Show("Data berhasil diupdate");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Anda harus memasukkan angka pada harga");
                }
            }
        }

        private void btnDeletePiutang_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah kamu ingin menghapus data?", "Delete data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            int temp;
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Piutang obj = new Piutang();
                    obj.Nominal_piutang = Int32.Parse(txtNPiutang.Text.Trim());
                    obj.Nama_piutang = txtNamaPengutang.Text.Trim();
                    obj.Tanggal_piutang = DateTime.Parse(dtp_piutang.Text.Trim());
                    obj.Jam_piutang = txtJPiutang.Text.Trim();
                    obj.Keterangan_piutang = txtKPiutang.Text.Trim();
                    delete(obj); // delete data ke dalam database
                    loadDataPiutang("");
                    MessageBox.Show("Data berhasil di hapus");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Anda harus memilih data yang ingin dihapus");
                }
            }
        }

        private void FormPiutang_Load(object sender, EventArgs e)
        {
            loadDataPiutang("");
        }

        private void dgvPiutang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = dgvPiutang.Rows[e.RowIndex];
            txtNPiutang.Text = baris.Cells[0].Value.ToString();
            txtNamaPengutang.Text = baris.Cells[1].Value.ToString();
            dtp_piutang.Text = baris.Cells[2].Value.ToString();
            txtJPiutang.Text = baris.Cells[3].Value.ToString();
            txtKPiutang.Text = baris.Cells[4].Value.ToString();
        }
    }
}
