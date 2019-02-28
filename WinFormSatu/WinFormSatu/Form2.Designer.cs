namespace WinFormSatu
{
    partial class Form2
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
            this.btnUkt = new System.Windows.Forms.Button();
            this.btnTutup = new System.Windows.Forms.Button();
            this.btnKonversiMassa = new System.Windows.Forms.Button();
            this.btnKonversiPanjang = new System.Windows.Forms.Button();
            this.btnKuadran = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUkt
            // 
            this.btnUkt.BackColor = System.Drawing.Color.MintCream;
            this.btnUkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnUkt.Location = new System.Drawing.Point(26, 28);
            this.btnUkt.Name = "btnUkt";
            this.btnUkt.Size = new System.Drawing.Size(225, 168);
            this.btnUkt.TabIndex = 0;
            this.btnUkt.Text = "Hitung UKT";
            this.btnUkt.UseVisualStyleBackColor = false;
            this.btnUkt.Click += new System.EventHandler(this.btnUkt_Click);
            // 
            // btnTutup
            // 
            this.btnTutup.BackColor = System.Drawing.Color.MintCream;
            this.btnTutup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTutup.Location = new System.Drawing.Point(642, 166);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(117, 104);
            this.btnTutup.TabIndex = 1;
            this.btnTutup.Text = "Tutup Aplikasi";
            this.btnTutup.UseVisualStyleBackColor = false;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // btnKonversiMassa
            // 
            this.btnKonversiMassa.BackColor = System.Drawing.Color.MintCream;
            this.btnKonversiMassa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnKonversiMassa.Location = new System.Drawing.Point(327, 28);
            this.btnKonversiMassa.Name = "btnKonversiMassa";
            this.btnKonversiMassa.Size = new System.Drawing.Size(225, 168);
            this.btnKonversiMassa.TabIndex = 2;
            this.btnKonversiMassa.Text = "Konversi Massa";
            this.btnKonversiMassa.UseVisualStyleBackColor = false;
            this.btnKonversiMassa.Click += new System.EventHandler(this.btnKonversiMassa_Click);
            // 
            // btnKonversiPanjang
            // 
            this.btnKonversiPanjang.BackColor = System.Drawing.Color.MintCream;
            this.btnKonversiPanjang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnKonversiPanjang.Location = new System.Drawing.Point(26, 258);
            this.btnKonversiPanjang.Name = "btnKonversiPanjang";
            this.btnKonversiPanjang.Size = new System.Drawing.Size(225, 168);
            this.btnKonversiPanjang.TabIndex = 3;
            this.btnKonversiPanjang.Text = "Konversi Panjang";
            this.btnKonversiPanjang.UseVisualStyleBackColor = false;
            this.btnKonversiPanjang.Click += new System.EventHandler(this.btnKonversiPanjang_Click);
            // 
            // btnKuadran
            // 
            this.btnKuadran.BackColor = System.Drawing.Color.MintCream;
            this.btnKuadran.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnKuadran.Location = new System.Drawing.Point(327, 258);
            this.btnKuadran.Name = "btnKuadran";
            this.btnKuadran.Size = new System.Drawing.Size(225, 168);
            this.btnKuadran.TabIndex = 4;
            this.btnKuadran.Text = "Menentukan Kuadran";
            this.btnKuadran.UseVisualStyleBackColor = false;
            this.btnKuadran.Click += new System.EventHandler(this.btnKuadran_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKuadran);
            this.Controls.Add(this.btnKonversiPanjang);
            this.Controls.Add(this.btnKonversiMassa);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.btnUkt);
            this.Name = "Form2";
            this.Text = "Aplikasi 2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUkt;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Button btnKonversiMassa;
        private System.Windows.Forms.Button btnKonversiPanjang;
        private System.Windows.Forms.Button btnKuadran;
    }
}