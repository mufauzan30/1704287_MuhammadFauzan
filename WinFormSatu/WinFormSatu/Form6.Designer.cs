namespace WinFormSatu
{
    partial class Form6
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
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(69, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menentukan Kuadran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(60, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(365, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(28, 166);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 55);
            this.txtX.TabIndex = 3;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(328, 166);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 55);
            this.txtY.TabIndex = 4;
            // 
            // btnHitung
            // 
            this.btnHitung.BackColor = System.Drawing.Color.White;
            this.btnHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnHitung.Location = new System.Drawing.Point(182, 348);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(100, 42);
            this.btnHitung.TabIndex = 5;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = false;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(118, 252);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(221, 55);
            this.txtHasil.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnReset.Location = new System.Drawing.Point(182, 419);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 42);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(466, 527);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnReset;
    }
}