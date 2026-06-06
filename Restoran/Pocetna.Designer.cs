namespace Restoran
{
    partial class Pocetna
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
            this.tb_korisnicko_ime = new System.Windows.Forms.TextBox();
            this.tb_lozinka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_prijava = new System.Windows.Forms.Button();
            this.btn_izadji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_korisnicko_ime
            // 
            this.tb_korisnicko_ime.Location = new System.Drawing.Point(16, 65);
            this.tb_korisnicko_ime.Name = "tb_korisnicko_ime";
            this.tb_korisnicko_ime.Size = new System.Drawing.Size(119, 20);
            this.tb_korisnicko_ime.TabIndex = 0;
            this.tb_korisnicko_ime.Tag = "";
            // 
            // tb_lozinka
            // 
            this.tb_lozinka.Location = new System.Drawing.Point(16, 109);
            this.tb_lozinka.Name = "tb_lozinka";
            this.tb_lozinka.PasswordChar = '*';
            this.tb_lozinka.Size = new System.Drawing.Size(119, 20);
            this.tb_lozinka.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Korisnicko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lozinka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 4;
            this.label3.Tag = "";
            this.label3.Text = "Dobrodosli";
            // 
            // btn_prijava
            // 
            this.btn_prijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prijava.Location = new System.Drawing.Point(16, 147);
            this.btn_prijava.Name = "btn_prijava";
            this.btn_prijava.Size = new System.Drawing.Size(119, 41);
            this.btn_prijava.TabIndex = 5;
            this.btn_prijava.Text = "Prijavi se";
            this.btn_prijava.UseVisualStyleBackColor = true;
            this.btn_prijava.Click += new System.EventHandler(this.btn_prijava_Click);
            // 
            // btn_izadji
            // 
            this.btn_izadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izadji.Location = new System.Drawing.Point(16, 194);
            this.btn_izadji.Name = "btn_izadji";
            this.btn_izadji.Size = new System.Drawing.Size(119, 41);
            this.btn_izadji.TabIndex = 6;
            this.btn_izadji.Text = "Izadji";
            this.btn_izadji.UseVisualStyleBackColor = true;
            this.btn_izadji.Click += new System.EventHandler(this.btn_izadji_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 250);
            this.Controls.Add(this.btn_izadji);
            this.Controls.Add(this.btn_prijava);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_lozinka);
            this.Controls.Add(this.tb_korisnicko_ime);
            this.Name = "Form1";
            this.Text = "Pocetna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_korisnicko_ime;
        private System.Windows.Forms.TextBox tb_lozinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_prijava;
        private System.Windows.Forms.Button btn_izadji;
    }
}

