namespace math_sınıfı
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.lblUst = new System.Windows.Forms.Label();
            this.lblKok = new System.Windows.Forms.Label();
            this.lblYukariYuvarla = new System.Windows.Forms.Label();
            this.lblAsagiYuvarla = new System.Windows.Forms.Label();
            this.lblMutlak = new System.Windows.Forms.Label();
            this.lblYuvarla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(24, 69);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(130, 27);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(180, 69);
            this.txtSayi.Multiline = true;
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(115, 27);
            this.txtSayi.TabIndex = 1;
            // 
            // lblUst
            // 
            this.lblUst.AutoSize = true;
            this.lblUst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUst.Location = new System.Drawing.Point(21, 147);
            this.lblUst.Name = "lblUst";
            this.lblUst.Size = new System.Drawing.Size(64, 15);
            this.lblUst.TabIndex = 2;
            this.lblUst.Text = "Üst Alma";
            // 
            // lblKok
            // 
            this.lblKok.AutoSize = true;
            this.lblKok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKok.Location = new System.Drawing.Point(21, 196);
            this.lblKok.Name = "lblKok";
            this.lblKok.Size = new System.Drawing.Size(65, 15);
            this.lblKok.TabIndex = 3;
            this.lblKok.Text = "Kare Kök";
            // 
            // lblYukariYuvarla
            // 
            this.lblYukariYuvarla.AutoSize = true;
            this.lblYukariYuvarla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYukariYuvarla.Location = new System.Drawing.Point(21, 284);
            this.lblYukariYuvarla.Name = "lblYukariYuvarla";
            this.lblYukariYuvarla.Size = new System.Drawing.Size(98, 15);
            this.lblYukariYuvarla.TabIndex = 4;
            this.lblYukariYuvarla.Text = "Yukarı Yuvarla";
            // 
            // lblAsagiYuvarla
            // 
            this.lblAsagiYuvarla.AutoSize = true;
            this.lblAsagiYuvarla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAsagiYuvarla.Location = new System.Drawing.Point(21, 329);
            this.lblAsagiYuvarla.Name = "lblAsagiYuvarla";
            this.lblAsagiYuvarla.Size = new System.Drawing.Size(93, 15);
            this.lblAsagiYuvarla.TabIndex = 5;
            this.lblAsagiYuvarla.Text = "Aşağı Yuvarla";
            // 
            // lblMutlak
            // 
            this.lblMutlak.AutoSize = true;
            this.lblMutlak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMutlak.Location = new System.Drawing.Point(21, 381);
            this.lblMutlak.Name = "lblMutlak";
            this.lblMutlak.Size = new System.Drawing.Size(50, 15);
            this.lblMutlak.TabIndex = 6;
            this.lblMutlak.Text = "Mutlak";
            this.lblMutlak.Click += new System.EventHandler(this.lblMutlak_Click);
            // 
            // lblYuvarla
            // 
            this.lblYuvarla.AutoSize = true;
            this.lblYuvarla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYuvarla.Location = new System.Drawing.Point(21, 242);
            this.lblYuvarla.Name = "lblYuvarla";
            this.lblYuvarla.Size = new System.Drawing.Size(54, 15);
            this.lblYuvarla.TabIndex = 7;
            this.lblYuvarla.Text = "Yuvarla";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 437);
            this.Controls.Add(this.lblYuvarla);
            this.Controls.Add(this.lblMutlak);
            this.Controls.Add(this.lblAsagiYuvarla);
            this.Controls.Add(this.lblYukariYuvarla);
            this.Controls.Add(this.lblKok);
            this.Controls.Add(this.lblUst);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Label lblUst;
        private System.Windows.Forms.Label lblKok;
        private System.Windows.Forms.Label lblYukariYuvarla;
        private System.Windows.Forms.Label lblAsagiYuvarla;
        private System.Windows.Forms.Label lblMutlak;
        private System.Windows.Forms.Label lblYuvarla;
    }
}

