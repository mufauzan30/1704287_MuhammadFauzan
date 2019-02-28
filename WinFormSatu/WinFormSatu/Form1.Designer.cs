namespace WinFormSatu
{
    partial class Form1
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
            this.UKT = new System.Windows.Forms.Label();
            this.Lama_kuliah = new System.Windows.Forms.Label();
            this.total_ukt = new System.Windows.Forms.Label();
            this.txtUkt = new System.Windows.Forms.TextBox();
            this.txtlamaKuliah = new System.Windows.Forms.TextBox();
            this.txtTotalUkt = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(96, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENGHITUNG UKT MAHASISWA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UKT
            // 
            this.UKT.AutoSize = true;
            this.UKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UKT.Location = new System.Drawing.Point(22, 179);
            this.UKT.Name = "UKT";
            this.UKT.Size = new System.Drawing.Size(119, 20);
            this.UKT.TabIndex = 1;
            this.UKT.Text = "UKT/Semester";
            this.UKT.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lama_kuliah
            // 
            this.Lama_kuliah.AutoSize = true;
            this.Lama_kuliah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Lama_kuliah.Location = new System.Drawing.Point(244, 179);
            this.Lama_kuliah.Name = "Lama_kuliah";
            this.Lama_kuliah.Size = new System.Drawing.Size(102, 20);
            this.Lama_kuliah.TabIndex = 2;
            this.Lama_kuliah.Text = "Lama Kuliah";
            // 
            // total_ukt
            // 
            this.total_ukt.AutoSize = true;
            this.total_ukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.total_ukt.Location = new System.Drawing.Point(471, 179);
            this.total_ukt.Name = "total_ukt";
            this.total_ukt.Size = new System.Drawing.Size(84, 20);
            this.total_ukt.TabIndex = 3;
            this.total_ukt.Text = "Total UKT";
            // 
            // txtUkt
            // 
            this.txtUkt.Location = new System.Drawing.Point(25, 213);
            this.txtUkt.Name = "txtUkt";
            this.txtUkt.Size = new System.Drawing.Size(130, 22);
            this.txtUkt.TabIndex = 4;
            // 
            // txtlamaKuliah
            // 
            this.txtlamaKuliah.Location = new System.Drawing.Point(232, 213);
            this.txtlamaKuliah.Name = "txtlamaKuliah";
            this.txtlamaKuliah.Size = new System.Drawing.Size(130, 22);
            this.txtlamaKuliah.TabIndex = 5;
            // 
            // txtTotalUkt
            // 
            this.txtTotalUkt.Location = new System.Drawing.Point(452, 213);
            this.txtTotalUkt.Name = "txtTotalUkt";
            this.txtTotalUkt.Size = new System.Drawing.Size(130, 22);
            this.txtTotalUkt.TabIndex = 6;
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(111, 292);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(75, 23);
            this.btnHitung.TabIndex = 7;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(258, 292);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(397, 292);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(75, 23);
            this.btnSelesai.TabIndex = 9;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(596, 435);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.txtTotalUkt);
            this.Controls.Add(this.txtlamaKuliah);
            this.Controls.Add(this.txtUkt);
            this.Controls.Add(this.total_ukt);
            this.Controls.Add(this.Lama_kuliah);
            this.Controls.Add(this.UKT);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UKT;
        private System.Windows.Forms.Label Lama_kuliah;
        private System.Windows.Forms.Label total_ukt;
        private System.Windows.Forms.TextBox txtUkt;
        private System.Windows.Forms.TextBox txtlamaKuliah;
        private System.Windows.Forms.TextBox txtTotalUkt;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSelesai;
    }
}

