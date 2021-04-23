namespace BukuKasPribadi.UI
{
    partial class FormKeuangan
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtbTotal = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTPemasukkan = new System.Windows.Forms.TextBox();
            this.txtTPengeluaran = new System.Windows.Forms.TextBox();
            this.txtTPiutang = new System.Windows.Forms.TextBox();
            this.txtTUtang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Uang :";
            // 
            // rtbTotal
            // 
            this.rtbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTotal.Location = new System.Drawing.Point(82, 271);
            this.rtbTotal.Name = "rtbTotal";
            this.rtbTotal.ReadOnly = true;
            this.rtbTotal.Size = new System.Drawing.Size(605, 96);
            this.rtbTotal.TabIndex = 1;
            this.rtbTotal.Text = "";
            this.rtbTotal.Click += new System.EventHandler(this.rtbTotal_Click);
            this.rtbTotal.MouseEnter += new System.EventHandler(this.rtbTotal_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Pemasukkan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Pengeluaran";
            // 
            // txtTPemasukkan
            // 
            this.txtTPemasukkan.Location = new System.Drawing.Point(82, 66);
            this.txtTPemasukkan.Name = "txtTPemasukkan";
            this.txtTPemasukkan.ReadOnly = true;
            this.txtTPemasukkan.Size = new System.Drawing.Size(245, 30);
            this.txtTPemasukkan.TabIndex = 5;
            this.txtTPemasukkan.Click += new System.EventHandler(this.txtTPemasukkan_Click);
            this.txtTPemasukkan.MouseEnter += new System.EventHandler(this.txtTPemasukkan_MouseEnter);
            // 
            // txtTPengeluaran
            // 
            this.txtTPengeluaran.Location = new System.Drawing.Point(442, 66);
            this.txtTPengeluaran.Name = "txtTPengeluaran";
            this.txtTPengeluaran.ReadOnly = true;
            this.txtTPengeluaran.Size = new System.Drawing.Size(245, 30);
            this.txtTPengeluaran.TabIndex = 6;
            this.txtTPengeluaran.Click += new System.EventHandler(this.txtTPengeluaran_Click);
            this.txtTPengeluaran.MouseEnter += new System.EventHandler(this.txtTPengeluaran_MouseEnter);
            // 
            // txtTPiutang
            // 
            this.txtTPiutang.Location = new System.Drawing.Point(442, 168);
            this.txtTPiutang.Name = "txtTPiutang";
            this.txtTPiutang.ReadOnly = true;
            this.txtTPiutang.Size = new System.Drawing.Size(245, 30);
            this.txtTPiutang.TabIndex = 10;
            this.txtTPiutang.Click += new System.EventHandler(this.txtTPiutang_Click);
            this.txtTPiutang.MouseEnter += new System.EventHandler(this.txtTPiutang_MouseEnter);
            // 
            // txtTUtang
            // 
            this.txtTUtang.Location = new System.Drawing.Point(82, 168);
            this.txtTUtang.Name = "txtTUtang";
            this.txtTUtang.ReadOnly = true;
            this.txtTUtang.Size = new System.Drawing.Size(245, 30);
            this.txtTUtang.TabIndex = 9;
            this.txtTUtang.Click += new System.EventHandler(this.txtTUtang_Click);
            this.txtTUtang.MouseEnter += new System.EventHandler(this.txtTUtang_MouseEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Piutang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Utang";
            // 
            // FormKeuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 460);
            this.Controls.Add(this.txtTPiutang);
            this.Controls.Add(this.txtTUtang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTPengeluaran);
            this.Controls.Add(this.txtTPemasukkan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbTotal);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormKeuangan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKeuangan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTPemasukkan;
        private System.Windows.Forms.TextBox txtTPengeluaran;
        private System.Windows.Forms.TextBox txtTPiutang;
        private System.Windows.Forms.TextBox txtTUtang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}