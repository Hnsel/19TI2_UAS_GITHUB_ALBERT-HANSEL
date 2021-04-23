namespace BukuKasPribadi.UI
{
    partial class FormPengeluaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPengeluaran));
            this.txtJPengeluaran = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPengeluaran = new System.Windows.Forms.DataGridView();
            this.Nominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeletePengeluaran = new System.Windows.Forms.Button();
            this.btnUpdatePengeluaran = new System.Windows.Forms.Button();
            this.btnResetPengeluaran = new System.Windows.Forms.Button();
            this.btnSimpanPengeluaran = new System.Windows.Forms.Button();
            this.dtp_pengeluaran = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKPengeluaran = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNPengeluaran = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengeluaran)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJPengeluaran
            // 
            this.txtJPengeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtJPengeluaran.Location = new System.Drawing.Point(265, 73);
            this.txtJPengeluaran.Name = "txtJPengeluaran";
            this.txtJPengeluaran.ReadOnly = true;
            this.txtJPengeluaran.Size = new System.Drawing.Size(483, 30);
            this.txtJPengeluaran.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(79, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Jam Pengeluaran :";
            // 
            // dgvPengeluaran
            // 
            this.dgvPengeluaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPengeluaran.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nominal,
            this.Tanggal,
            this.Jam,
            this.Keterangan});
            this.dgvPengeluaran.Location = new System.Drawing.Point(41, 284);
            this.dgvPengeluaran.Name = "dgvPengeluaran";
            this.dgvPengeluaran.RowHeadersWidth = 51;
            this.dgvPengeluaran.RowTemplate.Height = 24;
            this.dgvPengeluaran.Size = new System.Drawing.Size(707, 150);
            this.dgvPengeluaran.TabIndex = 43;
            this.dgvPengeluaran.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPengeluaran_CellClick);
            // 
            // Nominal
            // 
            this.Nominal.HeaderText = "Nominal";
            this.Nominal.MinimumWidth = 6;
            this.Nominal.Name = "Nominal";
            this.Nominal.Width = 125;
            // 
            // Tanggal
            // 
            this.Tanggal.HeaderText = "Tanggal";
            this.Tanggal.MinimumWidth = 6;
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Width = 125;
            // 
            // Jam
            // 
            this.Jam.HeaderText = "Jam";
            this.Jam.MinimumWidth = 6;
            this.Jam.Name = "Jam";
            this.Jam.Width = 125;
            // 
            // Keterangan
            // 
            this.Keterangan.HeaderText = "Keterangan";
            this.Keterangan.MinimumWidth = 6;
            this.Keterangan.Name = "Keterangan";
            this.Keterangan.Width = 125;
            // 
            // btnDeletePengeluaran
            // 
            this.btnDeletePengeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeletePengeluaran.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletePengeluaran.Image")));
            this.btnDeletePengeluaran.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePengeluaran.Location = new System.Drawing.Point(588, 218);
            this.btnDeletePengeluaran.Name = "btnDeletePengeluaran";
            this.btnDeletePengeluaran.Size = new System.Drawing.Size(160, 45);
            this.btnDeletePengeluaran.TabIndex = 42;
            this.btnDeletePengeluaran.Text = "Delete";
            this.btnDeletePengeluaran.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletePengeluaran.UseVisualStyleBackColor = true;
            this.btnDeletePengeluaran.Click += new System.EventHandler(this.btnDeletePengeluaran_Click);
            // 
            // btnUpdatePengeluaran
            // 
            this.btnUpdatePengeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdatePengeluaran.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdatePengeluaran.Image")));
            this.btnUpdatePengeluaran.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdatePengeluaran.Location = new System.Drawing.Point(405, 218);
            this.btnUpdatePengeluaran.Name = "btnUpdatePengeluaran";
            this.btnUpdatePengeluaran.Size = new System.Drawing.Size(160, 45);
            this.btnUpdatePengeluaran.TabIndex = 41;
            this.btnUpdatePengeluaran.Text = "Update";
            this.btnUpdatePengeluaran.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdatePengeluaran.UseVisualStyleBackColor = true;
            this.btnUpdatePengeluaran.Click += new System.EventHandler(this.btnUpdatePengeluaran_Click);
            // 
            // btnResetPengeluaran
            // 
            this.btnResetPengeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnResetPengeluaran.Image = ((System.Drawing.Image)(resources.GetObject("btnResetPengeluaran.Image")));
            this.btnResetPengeluaran.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetPengeluaran.Location = new System.Drawing.Point(223, 218);
            this.btnResetPengeluaran.Name = "btnResetPengeluaran";
            this.btnResetPengeluaran.Size = new System.Drawing.Size(160, 45);
            this.btnResetPengeluaran.TabIndex = 40;
            this.btnResetPengeluaran.Text = "Reset";
            this.btnResetPengeluaran.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetPengeluaran.UseVisualStyleBackColor = true;
            this.btnResetPengeluaran.Click += new System.EventHandler(this.btnResetPengeluaran_Click);
            // 
            // btnSimpanPengeluaran
            // 
            this.btnSimpanPengeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSimpanPengeluaran.Image = ((System.Drawing.Image)(resources.GetObject("btnSimpanPengeluaran.Image")));
            this.btnSimpanPengeluaran.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimpanPengeluaran.Location = new System.Drawing.Point(41, 218);
            this.btnSimpanPengeluaran.Name = "btnSimpanPengeluaran";
            this.btnSimpanPengeluaran.Size = new System.Drawing.Size(160, 45);
            this.btnSimpanPengeluaran.TabIndex = 39;
            this.btnSimpanPengeluaran.Text = "Simpan";
            this.btnSimpanPengeluaran.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSimpanPengeluaran.UseVisualStyleBackColor = true;
            this.btnSimpanPengeluaran.Click += new System.EventHandler(this.btnSimpanPengeluaran_Click);
            // 
            // dtp_pengeluaran
            // 
            this.dtp_pengeluaran.Location = new System.Drawing.Point(265, 24);
            this.dtp_pengeluaran.Margin = new System.Windows.Forms.Padding(5);
            this.dtp_pengeluaran.Name = "dtp_pengeluaran";
            this.dtp_pengeluaran.Size = new System.Drawing.Size(483, 30);
            this.dtp_pengeluaran.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tanggal Pengeluaran :";
            // 
            // txtKPengeluaran
            // 
            this.txtKPengeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtKPengeluaran.Location = new System.Drawing.Point(265, 170);
            this.txtKPengeluaran.Name = "txtKPengeluaran";
            this.txtKPengeluaran.Size = new System.Drawing.Size(483, 30);
            this.txtKPengeluaran.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(46, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nominal Pengeluaran :";
            // 
            // txtNPengeluaran
            // 
            this.txtNPengeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNPengeluaran.Location = new System.Drawing.Point(265, 121);
            this.txtNPengeluaran.Name = "txtNPengeluaran";
            this.txtNPengeluaran.Size = new System.Drawing.Size(483, 30);
            this.txtNPengeluaran.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(15, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Keterangan Pengeluaran :";
            // 
            // FormPengeluaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 460);
            this.Controls.Add(this.txtJPengeluaran);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPengeluaran);
            this.Controls.Add(this.btnDeletePengeluaran);
            this.Controls.Add(this.btnUpdatePengeluaran);
            this.Controls.Add(this.btnResetPengeluaran);
            this.Controls.Add(this.btnSimpanPengeluaran);
            this.Controls.Add(this.dtp_pengeluaran);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKPengeluaran);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNPengeluaran);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPengeluaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Pengeluaran";
            this.Load += new System.EventHandler(this.FormPengeluaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengeluaran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJPengeluaran;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPengeluaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keterangan;
        private System.Windows.Forms.Button btnDeletePengeluaran;
        private System.Windows.Forms.Button btnUpdatePengeluaran;
        private System.Windows.Forms.Button btnResetPengeluaran;
        private System.Windows.Forms.Button btnSimpanPengeluaran;
        private System.Windows.Forms.DateTimePicker dtp_pengeluaran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKPengeluaran;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNPengeluaran;
        private System.Windows.Forms.Label label2;
    }
}