namespace BukuKasPribadi
{
    partial class FormPemasukkan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPemasukkan));
            this.txtJPemasukkan = new System.Windows.Forms.TextBox();
            this.Keterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPemasukkan = new System.Windows.Forms.DataGridView();
            this.btnDeletePemasukkan = new System.Windows.Forms.Button();
            this.btnUpdatePemasukkan = new System.Windows.Forms.Button();
            this.btnResetPemasukkan = new System.Windows.Forms.Button();
            this.btnSimpanPemasukkan = new System.Windows.Forms.Button();
            this.dtp_pemasukkan = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKPemasukkan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNPemasukkan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPemasukkan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJPemasukkan
            // 
            this.txtJPemasukkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtJPemasukkan.Location = new System.Drawing.Point(263, 74);
            this.txtJPemasukkan.Name = "txtJPemasukkan";
            this.txtJPemasukkan.ReadOnly = true;
            this.txtJPemasukkan.Size = new System.Drawing.Size(483, 30);
            this.txtJPemasukkan.TabIndex = 32;
            // 
            // Keterangan
            // 
            this.Keterangan.HeaderText = "Keterangan";
            this.Keterangan.MinimumWidth = 6;
            this.Keterangan.Name = "Keterangan";
            this.Keterangan.Width = 125;
            // 
            // Jam
            // 
            this.Jam.HeaderText = "Jam";
            this.Jam.MinimumWidth = 6;
            this.Jam.Name = "Jam";
            this.Jam.Width = 125;
            // 
            // Tanggal
            // 
            this.Tanggal.HeaderText = "Tanggal";
            this.Tanggal.MinimumWidth = 6;
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Width = 125;
            // 
            // Nominal
            // 
            this.Nominal.HeaderText = "Nominal";
            this.Nominal.MinimumWidth = 6;
            this.Nominal.Name = "Nominal";
            this.Nominal.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(77, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Jam Pemasukkan :";
            // 
            // dgvPemasukkan
            // 
            this.dgvPemasukkan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPemasukkan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nominal,
            this.Tanggal,
            this.Jam,
            this.Keterangan});
            this.dgvPemasukkan.Location = new System.Drawing.Point(39, 285);
            this.dgvPemasukkan.Name = "dgvPemasukkan";
            this.dgvPemasukkan.RowHeadersWidth = 51;
            this.dgvPemasukkan.RowTemplate.Height = 24;
            this.dgvPemasukkan.Size = new System.Drawing.Size(707, 150);
            this.dgvPemasukkan.TabIndex = 30;
            this.dgvPemasukkan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPemasukkan_CellClick);
            // 
            // btnDeletePemasukkan
            // 
            this.btnDeletePemasukkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeletePemasukkan.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletePemasukkan.Image")));
            this.btnDeletePemasukkan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePemasukkan.Location = new System.Drawing.Point(586, 219);
            this.btnDeletePemasukkan.Name = "btnDeletePemasukkan";
            this.btnDeletePemasukkan.Size = new System.Drawing.Size(160, 45);
            this.btnDeletePemasukkan.TabIndex = 29;
            this.btnDeletePemasukkan.Text = "Delete";
            this.btnDeletePemasukkan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletePemasukkan.UseVisualStyleBackColor = true;
            this.btnDeletePemasukkan.Click += new System.EventHandler(this.btnDeletePemasukkan_Click);
            // 
            // btnUpdatePemasukkan
            // 
            this.btnUpdatePemasukkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdatePemasukkan.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdatePemasukkan.Image")));
            this.btnUpdatePemasukkan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdatePemasukkan.Location = new System.Drawing.Point(403, 219);
            this.btnUpdatePemasukkan.Name = "btnUpdatePemasukkan";
            this.btnUpdatePemasukkan.Size = new System.Drawing.Size(160, 45);
            this.btnUpdatePemasukkan.TabIndex = 28;
            this.btnUpdatePemasukkan.Text = "Update";
            this.btnUpdatePemasukkan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdatePemasukkan.UseVisualStyleBackColor = true;
            this.btnUpdatePemasukkan.Click += new System.EventHandler(this.btnUpdatePemasukkan_Click);
            // 
            // btnResetPemasukkan
            // 
            this.btnResetPemasukkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnResetPemasukkan.Image = ((System.Drawing.Image)(resources.GetObject("btnResetPemasukkan.Image")));
            this.btnResetPemasukkan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetPemasukkan.Location = new System.Drawing.Point(221, 219);
            this.btnResetPemasukkan.Name = "btnResetPemasukkan";
            this.btnResetPemasukkan.Size = new System.Drawing.Size(160, 45);
            this.btnResetPemasukkan.TabIndex = 27;
            this.btnResetPemasukkan.Text = "Reset";
            this.btnResetPemasukkan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetPemasukkan.UseVisualStyleBackColor = true;
            this.btnResetPemasukkan.Click += new System.EventHandler(this.btnResetPemasukkan_Click);
            // 
            // btnSimpanPemasukkan
            // 
            this.btnSimpanPemasukkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSimpanPemasukkan.Image = ((System.Drawing.Image)(resources.GetObject("btnSimpanPemasukkan.Image")));
            this.btnSimpanPemasukkan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimpanPemasukkan.Location = new System.Drawing.Point(39, 219);
            this.btnSimpanPemasukkan.Name = "btnSimpanPemasukkan";
            this.btnSimpanPemasukkan.Size = new System.Drawing.Size(160, 45);
            this.btnSimpanPemasukkan.TabIndex = 26;
            this.btnSimpanPemasukkan.Text = "Simpan";
            this.btnSimpanPemasukkan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSimpanPemasukkan.UseVisualStyleBackColor = true;
            this.btnSimpanPemasukkan.Click += new System.EventHandler(this.btnSimpanPemasukkan_Click);
            // 
            // dtp_pemasukkan
            // 
            this.dtp_pemasukkan.Location = new System.Drawing.Point(263, 25);
            this.dtp_pemasukkan.Margin = new System.Windows.Forms.Padding(5);
            this.dtp_pemasukkan.Name = "dtp_pemasukkan";
            this.dtp_pemasukkan.Size = new System.Drawing.Size(483, 30);
            this.dtp_pemasukkan.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tanggal Pemasukkan :";
            // 
            // txtKPemasukkan
            // 
            this.txtKPemasukkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtKPemasukkan.Location = new System.Drawing.Point(263, 171);
            this.txtKPemasukkan.Name = "txtKPemasukkan";
            this.txtKPemasukkan.Size = new System.Drawing.Size(483, 30);
            this.txtKPemasukkan.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(44, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nominal Pemasukkan :";
            // 
            // txtNPemasukkan
            // 
            this.txtNPemasukkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNPemasukkan.Location = new System.Drawing.Point(263, 122);
            this.txtNPemasukkan.Name = "txtNPemasukkan";
            this.txtNPemasukkan.Size = new System.Drawing.Size(483, 30);
            this.txtNPemasukkan.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(13, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Keterangan Pemasukkan :";
            // 
            // FormPemasukkan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 460);
            this.Controls.Add(this.txtJPemasukkan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPemasukkan);
            this.Controls.Add(this.btnDeletePemasukkan);
            this.Controls.Add(this.btnUpdatePemasukkan);
            this.Controls.Add(this.btnResetPemasukkan);
            this.Controls.Add(this.btnSimpanPemasukkan);
            this.Controls.Add(this.dtp_pemasukkan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKPemasukkan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNPemasukkan);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPemasukkan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Pemasukkan";
            this.Load += new System.EventHandler(this.FormPemasukkan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPemasukkan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJPemasukkan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keterangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nominal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPemasukkan;
        private System.Windows.Forms.Button btnDeletePemasukkan;
        private System.Windows.Forms.Button btnUpdatePemasukkan;
        private System.Windows.Forms.Button btnResetPemasukkan;
        private System.Windows.Forms.Button btnSimpanPemasukkan;
        private System.Windows.Forms.DateTimePicker dtp_pemasukkan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKPemasukkan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNPemasukkan;
        private System.Windows.Forms.Label label2;
    }
}