namespace BukuKasPribadi.UI
{
    partial class FormPiutang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPiutang));
            this.Keterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamaPengutang = new System.Windows.Forms.TextBox();
            this.Jam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtJPiutang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPiutang = new System.Windows.Forms.DataGridView();
            this.dtp_piutang = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKPiutang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNPiutang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeletePiutang = new System.Windows.Forms.Button();
            this.btnUpdatePiutang = new System.Windows.Forms.Button();
            this.btnResetPiutang = new System.Windows.Forms.Button();
            this.btnSimpanPiUtang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiutang)).BeginInit();
            this.SuspendLayout();
            // 
            // Keterangan
            // 
            this.Keterangan.HeaderText = "Keterangan";
            this.Keterangan.MinimumWidth = 6;
            this.Keterangan.Name = "Keterangan";
            this.Keterangan.Width = 125;
            // 
            // Tanggal
            // 
            this.Tanggal.HeaderText = "Tanggal";
            this.Tanggal.MinimumWidth = 6;
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Width = 125;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            this.Nama.Width = 125;
            // 
            // Nominal
            // 
            this.Nominal.HeaderText = "Nominal";
            this.Nominal.MinimumWidth = 6;
            this.Nominal.Name = "Nominal";
            this.Nominal.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(76, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 75;
            this.label5.Text = "Nama Pengutang :";
            // 
            // txtNamaPengutang
            // 
            this.txtNamaPengutang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNamaPengutang.Location = new System.Drawing.Point(262, 99);
            this.txtNamaPengutang.Name = "txtNamaPengutang";
            this.txtNamaPengutang.Size = new System.Drawing.Size(483, 30);
            this.txtNamaPengutang.TabIndex = 74;
            // 
            // Jam
            // 
            this.Jam.HeaderText = "Jam";
            this.Jam.MinimumWidth = 6;
            this.Jam.Name = "Jam";
            this.Jam.Width = 125;
            // 
            // txtJPiutang
            // 
            this.txtJPiutang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtJPiutang.Location = new System.Drawing.Point(262, 63);
            this.txtJPiutang.Name = "txtJPiutang";
            this.txtJPiutang.ReadOnly = true;
            this.txtJPiutang.Size = new System.Drawing.Size(483, 30);
            this.txtJPiutang.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(119, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 72;
            this.label4.Text = "Jam Piutang :";
            // 
            // dgvPiutang
            // 
            this.dgvPiutang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPiutang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nominal,
            this.Nama,
            this.Tanggal,
            this.Jam,
            this.Keterangan});
            this.dgvPiutang.Location = new System.Drawing.Point(38, 285);
            this.dgvPiutang.Name = "dgvPiutang";
            this.dgvPiutang.RowHeadersWidth = 51;
            this.dgvPiutang.RowTemplate.Height = 24;
            this.dgvPiutang.Size = new System.Drawing.Size(707, 150);
            this.dgvPiutang.TabIndex = 71;
            this.dgvPiutang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPiutang_CellClick);
            // 
            // dtp_piutang
            // 
            this.dtp_piutang.Location = new System.Drawing.Point(262, 25);
            this.dtp_piutang.Margin = new System.Windows.Forms.Padding(5);
            this.dtp_piutang.Name = "dtp_piutang";
            this.dtp_piutang.Size = new System.Drawing.Size(483, 30);
            this.dtp_piutang.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 65;
            this.label1.Text = "Tanggal Piutang :";
            // 
            // txtKPiutang
            // 
            this.txtKPiutang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtKPiutang.Location = new System.Drawing.Point(262, 171);
            this.txtKPiutang.Name = "txtKPiutang";
            this.txtKPiutang.Size = new System.Drawing.Size(483, 30);
            this.txtKPiutang.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(87, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 63;
            this.label3.Text = "Nominal Piutang :";
            // 
            // txtNPiutang
            // 
            this.txtNPiutang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNPiutang.Location = new System.Drawing.Point(262, 135);
            this.txtNPiutang.Name = "txtNPiutang";
            this.txtNPiutang.Size = new System.Drawing.Size(483, 30);
            this.txtNPiutang.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(55, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Keterangan Piutang :";
            // 
            // btnDeletePiutang
            // 
            this.btnDeletePiutang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeletePiutang.Image = global::BukuKasPribadi.Properties.Resources.bayar;
            this.btnDeletePiutang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePiutang.Location = new System.Drawing.Point(568, 218);
            this.btnDeletePiutang.Name = "btnDeletePiutang";
            this.btnDeletePiutang.Size = new System.Drawing.Size(177, 45);
            this.btnDeletePiutang.TabIndex = 79;
            this.btnDeletePiutang.Text = "Bayar / Delete";
            this.btnDeletePiutang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletePiutang.UseVisualStyleBackColor = true;
            this.btnDeletePiutang.Click += new System.EventHandler(this.btnDeletePiutang_Click);
            // 
            // btnUpdatePiutang
            // 
            this.btnUpdatePiutang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdatePiutang.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdatePiutang.Image")));
            this.btnUpdatePiutang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdatePiutang.Location = new System.Drawing.Point(393, 218);
            this.btnUpdatePiutang.Name = "btnUpdatePiutang";
            this.btnUpdatePiutang.Size = new System.Drawing.Size(160, 45);
            this.btnUpdatePiutang.TabIndex = 78;
            this.btnUpdatePiutang.Text = "Update";
            this.btnUpdatePiutang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdatePiutang.UseVisualStyleBackColor = true;
            this.btnUpdatePiutang.Click += new System.EventHandler(this.btnUpdatePiutang_Click);
            // 
            // btnResetPiutang
            // 
            this.btnResetPiutang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnResetPiutang.Image = ((System.Drawing.Image)(resources.GetObject("btnResetPiutang.Image")));
            this.btnResetPiutang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetPiutang.Location = new System.Drawing.Point(215, 218);
            this.btnResetPiutang.Name = "btnResetPiutang";
            this.btnResetPiutang.Size = new System.Drawing.Size(160, 45);
            this.btnResetPiutang.TabIndex = 77;
            this.btnResetPiutang.Text = "Reset";
            this.btnResetPiutang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetPiutang.UseVisualStyleBackColor = true;
            this.btnResetPiutang.Click += new System.EventHandler(this.btnResetPiutang_Click);
            // 
            // btnSimpanPiUtang
            // 
            this.btnSimpanPiUtang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSimpanPiUtang.Image = ((System.Drawing.Image)(resources.GetObject("btnSimpanPiUtang.Image")));
            this.btnSimpanPiUtang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimpanPiUtang.Location = new System.Drawing.Point(38, 218);
            this.btnSimpanPiUtang.Name = "btnSimpanPiUtang";
            this.btnSimpanPiUtang.Size = new System.Drawing.Size(160, 45);
            this.btnSimpanPiUtang.TabIndex = 76;
            this.btnSimpanPiUtang.Text = "Simpan";
            this.btnSimpanPiUtang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSimpanPiUtang.UseVisualStyleBackColor = true;
            this.btnSimpanPiUtang.Click += new System.EventHandler(this.btnSimpanPiUtang_Click);
            // 
            // FormPiutang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 460);
            this.Controls.Add(this.btnDeletePiutang);
            this.Controls.Add(this.btnUpdatePiutang);
            this.Controls.Add(this.btnResetPiutang);
            this.Controls.Add(this.btnSimpanPiUtang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNamaPengutang);
            this.Controls.Add(this.txtJPiutang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPiutang);
            this.Controls.Add(this.dtp_piutang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKPiutang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNPiutang);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPiutang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Piutang";
            this.Load += new System.EventHandler(this.FormPiutang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPiutang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Keterangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nominal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamaPengutang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jam;
        private System.Windows.Forms.TextBox txtJPiutang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPiutang;
        private System.Windows.Forms.DateTimePicker dtp_piutang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKPiutang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNPiutang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeletePiutang;
        private System.Windows.Forms.Button btnUpdatePiutang;
        private System.Windows.Forms.Button btnResetPiutang;
        private System.Windows.Forms.Button btnSimpanPiUtang;
    }
}