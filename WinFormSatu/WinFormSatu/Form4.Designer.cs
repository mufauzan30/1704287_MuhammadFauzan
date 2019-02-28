namespace WinFormSatu
{
    partial class Form4
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
            this.btnKonversi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKilogram = new System.Windows.Forms.TextBox();
            this.txtGram = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKonversi
            // 
            this.btnKonversi.Location = new System.Drawing.Point(156, 252);
            this.btnKonversi.Name = "btnKonversi";
            this.btnKonversi.Size = new System.Drawing.Size(75, 23);
            this.btnKonversi.TabIndex = 0;
            this.btnKonversi.Text = "Konversi";
            this.btnKonversi.UseVisualStyleBackColor = true;
            this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Konversi Massa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtKilogram
            // 
            this.txtKilogram.Location = new System.Drawing.Point(23, 181);
            this.txtKilogram.Name = "txtKilogram";
            this.txtKilogram.Size = new System.Drawing.Size(100, 22);
            this.txtKilogram.TabIndex = 2;
            // 
            // txtGram
            // 
            this.txtGram.Location = new System.Drawing.Point(243, 181);
            this.txtGram.Name = "txtGram";
            this.txtGram.Size = new System.Drawing.Size(100, 22);
            this.txtGram.TabIndex = 3;
            this.txtGram.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kilogram";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gram";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(156, 324);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(390, 416);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGram);
            this.Controls.Add(this.txtKilogram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKonversi);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKonversi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKilogram;
        private System.Windows.Forms.TextBox txtGram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
    }
}