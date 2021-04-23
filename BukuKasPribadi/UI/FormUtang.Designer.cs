namespace BukuKasPribadi.UI
{
    partial class FormUtang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtang));
            this.txtJUtang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvUtang = new System.Windows.Forms.DataGridView();
            this.Nominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteUtang = new System.Windows.Forms.Button();
            this.btnUpdateUtang = new System.Windows.Forms.Button();
            this.btnResetUtang = new System.Windows.Forms.Button();
            this.btnSimpanUtang = new System.Windows.Forms.Button();
            this.dtp_utang = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKUtang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNUtang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamaUtang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJUtang
            // 
            this.txtJUtang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtJUtang.Location = new System.Drawing.Point(266, 61);
            this.txtJUtang.Name = "txtJUtang";
            this.txtJUtang.ReadOnly = true;
            this.txtJUtang.Size = new System.Drawing.Size(483, 30);
            this.txtJUtang.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(138, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 57;
            this.label4.Text = "Jam Utang :";
            // 
            // dgvUtang
            // 
            this.dgvUtang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nominal,
            this.Nama,
            this.Tanggal,
            this.Jam,
            this.Keterangan});
            this.dgvUtang.Location = new System.Drawing.Point(42, 284);
            this.dgvUtang.Name = "dgvUtang";
            this.dgvUtang.RowHeadersWidth = 51;
            this.dgvUtang.RowTemplate.Height = 24;
            this.dgvUtang.Size = new System.Drawing.Size(707, 150);
            this.dgvUtang.TabIndex = 56;
            this.dgvUtang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUtang_CellClick);
            // 
            // Nominal
            // 
            this.Nominal.HeaderText = "Nominal";
            this.Nominal.MinimumWidth = 6;
            this.Nominal.Name = "Nominal";
            this.Nominal.Width = 125;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            this.Nama.Width = 125;
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
            // btnDeleteUtang
            // 
            this.btnDeleteUtang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeleteUtang.Image = global::BukuKasPribadi.Properties.Resources.bayar;
            this.btnDeleteUtang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUtang.Location = new System.Drawing.Point(572, 219);
            this.btnDeleteUtang.Name = "btnDeleteUtang";
            this.btnDeleteUtang.Size = new System.Drawing.Size(177, 45);
            this.btnDeleteUtang.TabIndex = 55;
            this.btnDeleteUtang.Text = "Bayar / Delete";
            this.btnDeleteUtang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteUtang.UseVisualStyleBackColor = true;
            this.btnDeleteUtang.Click += new System.EventHandler(this.btnDeleteUtang_Click);
            // 
            // btnUpdateUtang
            // 
            this.btnUpdateUtang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdateUtang.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateUtang.Image")));
            this.btnUpdateUtang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUtang.Location = new System.Drawing.Point(397, 219);
            this.btnUpdateUtang.Name = "btnUpdateUtang";
            this.btnUpdateUtang.Size = new System.Drawing.Size(160, 45);
            this.btnUpdateUtang.TabIndex = 54;
            this.btnUpdateUtang.Text = "Update";
            this.btnUpdateUtang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateUtang.UseVisualStyleBackColor = true;
            this.btnUpdateUtang.Click += new System.EventHandler(this.btnUpdateUtang_Click);
            // 
            // btnResetUtang
            // 
            this.btnResetUtang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnResetUtang.Image = ((System.Drawing.Image)(resources.GetObject("btnResetUtang.Image")));
            this.btnResetUtang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetUtang.Location = new System.Drawing.Point(219, 219);
            this.btnResetUtang.Name = "btnResetUtang";
            this.btnResetUtang.Size = new System.Drawing.Size(160, 45);
            this.btnResetUtang.TabIndex = 53;
            this.btnResetUtang.Text = "Reset";
            this.btnResetUtang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetUtang.UseVisualStyleBackColor = true;
            this.btnResetUtang.Click += new System.EventHandler(this.btnResetUtang_Click);
            // 
            // btnSimpanUtang
            // 
            this.btnSimpanUtang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSimpanUtang.Image = ((System.Drawing.Image)(resources.GetObject("btnSimpanUtang.Image")));
            this.btnSimpanUtang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimpanUtang.Location = new System.Drawing.Point(42, 219);
            this.btnSimpanUtang.Name = "btnSimpanUtang";
            this.btnSimpanUtang.Size = new System.Drawing.Size(160, 45);
            this.btnSimpanUtang.TabIndex = 52;
            this.btnSimpanUtang.Text = "Simpan";
            this.btnSimpanUtang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSimpanUtang.UseVisualStyleBackColor = true;
            this.btnSimpanUtang.Click += new System.EventHandler(this.btnSimpanUtang_Click);
            // 
            // dtp_utang
            // 
            this.dtp_utang.Location = new System.Drawing.Point(266, 23);
            this.dtp_utang.Margin = new System.Windows.Forms.Padding(5);
            this.dtp_utang.Name = "dtp_utang";
            this.dtp_utang.Size = new System.Drawing.Size(483, 30);
            this.dtp_utang.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Tanggal Utang :";
            // 
            // txtKUtang
            // 
            this.txtKUtang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtKUtang.Location = new System.Drawing.Point(266, 169);
            this.txtKUtang.Name = "txtKUtang";
            this.txtKUtang.Size = new System.Drawing.Size(483, 30);
            this.txtKUtang.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(104, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Nominal Utang :";
            // 
            // txtNUtang
            // 
            this.txtNUtang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNUtang.Location = new System.Drawing.Point(266, 133);
            this.txtNUtang.Name = "txtNUtang";
            this.txtNUtang.Size = new System.Drawing.Size(483, 30);
            this.txtNUtang.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(73, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Keterangan Utang :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(47, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 25);
            this.label5.TabIndex = 60;
            this.label5.Text = "Nama Pemberi Utang :";
            // 
            // txtNamaUtang
            // 
            this.txtNamaUtang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNamaUtang.Location = new System.Drawing.Point(266, 97);
            this.txtNamaUtang.Name = "txtNamaUtang";
            this.txtNamaUtang.Size = new System.Drawing.Size(483, 30);
            this.txtNamaUtang.TabIndex = 59;
            // 
            // FormUtang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 460);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNamaUtang);
            this.Controls.Add(this.txtJUtang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvUtang);
            this.Controls.Add(this.btnDeleteUtang);
            this.Controls.Add(this.btnUpdateUtang);
            this.Controls.Add(this.btnResetUtang);
            this.Controls.Add(this.btnSimpanUtang);
            this.Controls.Add(this.dtp_utang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKUtang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNUtang);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormUtang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Utang";
            this.Load += new System.EventHandler(this.FormUtang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJUtang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvUtang;
        private System.Windows.Forms.Button btnDeleteUtang;
        private System.Windows.Forms.Button btnUpdateUtang;
        private System.Windows.Forms.Button btnResetUtang;
        private System.Windows.Forms.Button btnSimpanUtang;
        private System.Windows.Forms.DateTimePicker dtp_utang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKUtang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNUtang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamaUtang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keterangan;
    }
}