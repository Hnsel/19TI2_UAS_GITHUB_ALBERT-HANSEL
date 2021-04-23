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

namespace BukuKasPribadi
{
    public partial class FormPemasukkan : Form
    {
        private const string connectString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:/Pengembangan Piranti Lunak/BukuKasPribadi/Buku_Kas_Pribadi.accdb; Persist Security Info=False;";

        readonly OleDbConnection dbConn = new OleDbConnection(connectString);
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        readonly DataTable dt = new DataTable();

        public FormPemasukkan()
        {
            InitializeComponent();
        }

        private void simpan(Pemasukkan obj)
        {
            const string sql = "insert into Pemasukkan(Nominal_Pemasukkan, Tanggal, Jam, Keterangan ) values(@n_pemasukkan, @t_pemasukkan, @j_pemasukkan, @k_pemasukkan)";
            cmd = new OleDbCommand(sql, dbConn);
            cmd.Parameters.AddWithValue("@n_pemasukkan", obj.Nominal_pemasukkan);
            cmd.Parameters.AddWithValue("@t_pemasukkan", obj.Tanggal_pemasukkan);
            cmd.Parameters.AddWithValue("@j_pemasukkan", obj.Jam_pemasukkan);
            cmd.Parameters.AddWithValue("@k_pemasukkan", obj.Keterangan_pemasukkan);

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
        private void update(Pemasukkan obj)
        {
            string sql = "update Pemasukkan set Nominal_Pemasukkan='" + obj.Nominal_pemasukkan + "', Tanggal='" + obj.Tanggal_pemasukkan + "', Jam='" + obj.Jam_pemasukkan + "' where Keterangan='" + obj.Keterangan_pemasukkan + "'";
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
        private void delete(Pemasukkan obj)
        {
            string sql = "delete from Pemasukkan where Keterangan='" + obj.Keterangan_pemasukkan + "'";
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
        private void populate(Pemasukkan obj)
        {
            dgvPemasukkan.Rows.Add(obj.Nominal_pemasukkan, obj.Tanggal_pemasukkan, obj.Jam_pemasukkan, obj.Keterangan_pemasukkan);
        }

        void loadDataPemasukkan(string Nominal_pemasukkan)
        {
            dgvPemasukkan.Rows.Clear();
            try
            {
                String sql = "SELECT * FROM Pemasukkan where Nominal_Pemasukkan like '%" + Nominal_pemasukkan + "%'";
                cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    Pemasukkan obj = new Pemasukkan();
                    obj.Nominal_pemasukkan = Int32.Parse(row[1].ToString());
                    obj.Tanggal_pemasukkan = DateTime.Parse(row[2].ToString());
                    obj.Jam_pemasukkan = row[3].ToString();
                    obj.Keterangan_pemasukkan = row[4].ToString();
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

        private void btnSimpanPemasukkan_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Kamu ingin menyimpan data ?", "Simpan Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            int temp;
            if (dr == DialogResult.Yes)
            {
                try
                {
                    int nominal = Int32.Parse(txtNPemasukkan.Text.Trim());
                    txtJPemasukkan.Text = DateTime.Now.ToLongTimeString();
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvPemasukkan);
                    row.Cells[0].Value = txtNPemasukkan.Text.Trim();
                    row.Cells[1].Value = dtp_pemasukkan.Text.Trim();
                    row.Cells[2].Value = txtJPemasukkan.Text.Trim();
                    row.Cells[3].Value = txtKPemasukkan.Text.Trim();
                    dgvPemasukkan.Rows.Add(row);

                    Pemasukkan obj = new Pemasukkan();
                    obj.Nominal_pemasukkan = Int32.Parse(txtNPemasukkan.Text.Trim());
                    obj.Tanggal_pemasukkan = DateTime.Parse(dtp_pemasukkan.Text.Trim());
                    obj.Jam_pemasukkan = txtJPemasukkan.Text.Trim();
                    obj.Keterangan_pemasukkan = txtKPemasukkan.Text.Trim();
                    simpan(obj); //simpan data ke dalam database

                    MessageBox.Show("Data berhasil di simpan");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Anda harus memasukkan angka pada nominal");
                }
            }
        }

        private void FormPemasukkan_Load(object sender, EventArgs e)
        {
            loadDataPemasukkan("");
        }

        private void btnUpdatePemasukkan_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah kamu ingin mengupdate data?", "Update data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            int temp;
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Pemasukkan obj = new Pemasukkan();
                    obj.Nominal_pemasukkan = Int32.Parse(txtNPemasukkan.Text.Trim());
                    obj.Tanggal_pemasukkan = DateTime.Parse(dtp_pemasukkan.Text.Trim());
                    obj.Jam_pemasukkan = txtJPemasukkan.Text.Trim();
                    obj.Keterangan_pemasukkan = txtKPemasukkan.Text.Trim();
                    update(obj); //update data ke dalam database
                    loadDataPemasukkan("");

                    MessageBox.Show("Data berhasil diupdate");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Anda harus memasukkan angka pada harga");
                }
            }
        }
        private void dgvPemasukkan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow baris = dgvPemasukkan.Rows[e.RowIndex];
            txtNPemasukkan.Text = baris.Cells[0].Value.ToString();
            dtp_pemasukkan.Text = baris.Cells[1].Value.ToString();
            txtJPemasukkan.Text = baris.Cells[2].Value.ToString();
            txtKPemasukkan.Text = baris.Cells[3].Value.ToString();
        }

        private void btnResetPemasukkan_Click(object sender, EventArgs e)
        {
            txtNPemasukkan.Text = dtp_pemasukkan.Text = txtKPemasukkan.Text = String.Empty;
        }

        private void btnDeletePemasukkan_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah kamu ingin menghapus data?", "Delete data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            int temp;
            if (dr == DialogResult.Yes)
            {
                try
                {
                    Pemasukkan obj = new Pemasukkan();
                    obj.Nominal_pemasukkan = Int32.Parse(txtNPemasukkan.Text.Trim());
                    obj.Tanggal_pemasukkan = DateTime.Parse(dtp_pemasukkan.Text.Trim());
                    obj.Jam_pemasukkan = txtJPemasukkan.Text.Trim();
                    obj.Keterangan_pemasukkan = txtKPemasukkan.Text.Trim();
                    delete(obj); // delete data ke dalam database
                    loadDataPemasukkan("");
                    MessageBox.Show("Data berhasil di hapus");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Anda harus memilih data yang ingin dihapus");
                }
            }
        }
    }
}
