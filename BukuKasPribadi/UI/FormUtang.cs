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
    public partial class FormUtang : Form
    {
        private const string connectString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:/Pengembangan Piranti Lunak/BukuKasPribadi/Buku_Kas_Pribadi.accdb; Persist Security Info=False;";

        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();

        public FormUtang()
        {
            InitializeComponent();
        }
        private void populate(Utang obj)
        {
            dgvUtang.Rows.Add(obj.Nominal_utang, obj.Nama_utang, obj.Tanggal_utang, obj.Jam_utang, obj.Keterangan_utang);
        }

        void loadDataUtang(string Nominal_utang)
        {
            dgvUtang.Rows.Clear();
            try
            {
                String sql = "SELECT * FROM Utang where Nominal_Utang like '%" + Nominal_utang + "%'";
                cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    Utang obj = new Utang();
                    obj.Nominal_utang = Int32.Parse(row[1].ToString());
                    obj.Nama_utang = row[2].ToString();
                    obj.Tanggal_utang = DateTime.Parse(row[3].ToString());
                    obj.Jam_utang = row[4].ToString();
                    obj.Keterangan_utang = row[5].ToString();
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

        private void simpan(Utang obj)
        {
            const string sql = "insert into Utang(Nominal_Utang, Nama_Pemberi, Tanggal, Jam, Keterangan ) values(@n_utang, @np_utang, @t_utang, @j_utang, @k_utang)";
            cmd = new OleDbCommand(sql, dbConn);
            cmd.Parameters.AddWithValue("@n_utang", obj.Nominal_utang);
            cmd.Parameters.AddWithValue("@np_utang", obj.Nama_utang);
            cmd.Parameters.AddWithValue("@t_utang", obj.Tanggal_utang);
            cmd.Parameters.AddWithValue("@j_utang", obj.Jam_utang);
            cmd.Parameters.AddWithValue("@k_utang", obj.Keterangan_utang);

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

        private void update(Utang obj)
        {
            string sql = "update Utang set Nominal_Utang='" + obj.Nominal_utang + "', Nama_Pemberi='" + obj.Nama_utang + "', Tanggal='" + obj.Tanggal_utang + "', Jam='" + obj.Jam_utang + "' where Keterangan='" + obj.Keterangan_utang + "'";
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

        private void delete(Utang obj)
        {
            string sql = "delete from Utang where Keterangan='" + obj.Keterangan_utang + "'";
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

        private void btnSimpanUtang_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Kamu ingin menyimpan data ?", "Simpan Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            int temp;
            if (dr == DialogResult.Yes)
            {
                try
                {
                    int nominal = Int32.Parse(txtNUtang.Text.Trim());
                    txtJUtang.Text = DateTime.Now.ToLongTimeString();
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvUtang);
                    row.Cells[0].Value = txtNUtang.Text.Trim();
                    row.Cells[1].Value = txtNamaUtang.Text.Trim();
                    row.Cells[2].Value = dtp_utang.Text.Trim();
                    row.Cells[3].Value = txtJUtang.Text.Trim();
                    row.Cells[4].Value = txtKUtang.Text.Trim();
                    dgvUtang.Rows.Add(row);

                    Utang obj = new Utang();
                    obj.Nominal_utang = Int32.Parse(txtNUtang.Text.Trim());
                    obj.Nama_utang = txtNamaUtang.Text.Trim();
                    obj.Tanggal_utang = DateTime.Parse(dtp_utang.Text.Trim());
                    obj.Jam_utang = txtJUtang.Text.Trim();
                    obj.Keterangan_utang = txtKUtang.Text.Trim();
                    simpan(obj); //simpan data ke dalam database

                    MessageBox.Show("Data berhasil di simpan");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Anda harus memasukkan angka pada nominal");
                }
            }
        }

        private void btnResetUtang_Click(object sender, EventArgs e)
        {
            txtNUtang.Text = txtNamaUtang.Text = dtp_utang.Text = txtKUtang.Text = String.Empty;
        }

        private void btnUpdateUtang_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah kamu ingin mengupdate data?", "Update data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            int temp;
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Utang obj = new Utang();
                    obj.Nominal_utang = Int32.Parse(txtNUtang.Text.Trim());
                    obj.Nama_utang = txtNamaUtang.Text.Trim();
                    obj.Tanggal_utang = DateTime.Parse(dtp_utang.Text.Trim());
                    obj.Jam_utang = txtJUtang.Text.Trim();
                    obj.Keterangan_utang = txtKUtang.Text.Trim();
                    update(obj); //update data ke dalam database
                    loadDataUtang("");

                    MessageBox.Show("Data berhasil diupdate");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Anda harus memasukkan angka pada harga");
                }
            }
        }

        private void btnDeleteUtang_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah kamu ingin menghapus data?", "Delete data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            int temp;
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Utang obj = new Utang();
                    obj.Nominal_utang = Int32.Parse(txtNUtang.Text.Trim());
                    obj.Nama_utang = txtNamaUtang.Text.Trim();
                    obj.Tanggal_utang = DateTime.Parse(dtp_utang.Text.Trim());
                    obj.Jam_utang = txtJUtang.Text.Trim();
                    obj.Keterangan_utang = txtKUtang.Text.Trim();
                    delete(obj); // delete data ke dalam database
                    loadDataUtang("");
                    MessageBox.Show("Data berhasil di hapus");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Anda harus memilih data yang ingin dihapus");
                }
            }
        }

        private void FormUtang_Load(object sender, EventArgs e)
        {
            loadDataUtang("");
        }

        private void dgvUtang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = dgvUtang.Rows[e.RowIndex];
            txtNUtang.Text = baris.Cells[0].Value.ToString();
            txtNamaUtang.Text = baris.Cells[1].Value.ToString();
            dtp_utang.Text = baris.Cells[2].Value.ToString();
            txtJUtang.Text = baris.Cells[3].Value.ToString();
            txtKUtang.Text = baris.Cells[4].Value.ToString();
        }
    }
}
