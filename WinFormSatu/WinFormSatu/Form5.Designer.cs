namespace WinFormSatu
{
    partial class Form5
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMeter = new System.Windows.Forms.TextBox();
            this.txtCentimeter = new System.Windows.Forms.TextBox();
            this.btnKonversi = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(58, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Konversi Panjang";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(62, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(301, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Centimeter";
            // 
            // txtMeter
            // 
            this.txtMeter.Location = new System.Drawing.Point(25, 207);
            this.txtMeter.Name = "txtMeter";
            this.txtMeter.Size = new System.Drawing.Size(129, 22);
            this.txtMeter.TabIndex = 3;
            // 
            // txtCentimeter
            // 
            this.txtCentimeter.Location = new System.Drawing.Point(286, 207);
            this.txtCentimeter.Name = "txtCentimeter";
            this.txtCentimeter.Size = new System.Drawing.Size(129, 22);
            this.txtCentimeter.TabIndex = 4;
            // 
            // btnKonversi
            // 
            this.btnKonversi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnKonversi.Location = new System.Drawing.Point(177, 261);
            this.btnKonversi.Name = "btnKonversi";
            this.btnKonversi.Size = new System.Drawing.Size(100, 43);
            this.btnKonversi.TabIndex = 5;
            this.btnKonversi.Text = "Konversi";
            this.btnKonversi.UseVisualStyleBackColor = true;
            this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnReset.Location = new System.Drawing.Point(177, 329);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 31);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnKonversi);
            this.Controls.Add(this.txtCentimeter);
            this.Controls.Add(this.txtMeter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMeter;
        private System.Windows.Forms.TextBox txtCentimeter;
        private System.Windows.Forms.Button btnKonversi;
        private System.Windows.Forms.Button btnReset;
    }
}