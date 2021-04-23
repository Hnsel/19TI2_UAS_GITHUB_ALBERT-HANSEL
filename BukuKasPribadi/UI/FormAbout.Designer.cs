namespace BukuKasPribadi.UI
{
    partial class FormAbout
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
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblCPY = new System.Windows.Forms.Label();
            this.btnJustify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(0, 0);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(782, 44);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Buku Kas Pribadi";
            this.lblJudul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(13, 72);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(64, 25);
            this.lblP.TabIndex = 1;
            this.lblP.Text = "label2";
            // 
            // lblCPY
            // 
            this.lblCPY.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCPY.Location = new System.Drawing.Point(0, 528);
            this.lblCPY.Name = "lblCPY";
            this.lblCPY.Size = new System.Drawing.Size(782, 25);
            this.lblCPY.TabIndex = 3;
            this.lblCPY.Text = "label2";
            this.lblCPY.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnJustify
            // 
            this.btnJustify.Image = global::BukuKasPribadi.Properties.Resources.justify;
            this.btnJustify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJustify.Location = new System.Drawing.Point(292, 471);
            this.btnJustify.Name = "btnJustify";
            this.btnJustify.Size = new System.Drawing.Size(160, 45);
            this.btnJustify.TabIndex = 2;
            this.btnJustify.Text = "Justify";
            this.btnJustify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJustify.UseVisualStyleBackColor = true;
            this.btnJustify.Click += new System.EventHandler(this.btnJustify_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.lblCPY);
            this.Controls.Add(this.btnJustify);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblJudul);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAbout";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Button btnJustify;
        private System.Windows.Forms.Label lblCPY;
    }
}