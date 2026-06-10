namespace Restoran
{
    partial class Izmeni
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
            this.cb_naziv_priloga = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nud_kolicina = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sacuvaj_stavku = new System.Windows.Forms.Button();
            this.btn_odjavi_se = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_kolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_naziv_priloga
            // 
            this.cb_naziv_priloga.FormattingEnabled = true;
            this.cb_naziv_priloga.Location = new System.Drawing.Point(13, 41);
            this.cb_naziv_priloga.Margin = new System.Windows.Forms.Padding(4);
            this.cb_naziv_priloga.Name = "cb_naziv_priloga";
            this.cb_naziv_priloga.Size = new System.Drawing.Size(163, 24);
            this.cb_naziv_priloga.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 17);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Lista dostupnih priloga za jelo: ";
            // 
            // nud_kolicina
            // 
            this.nud_kolicina.Location = new System.Drawing.Point(13, 115);
            this.nud_kolicina.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_kolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_kolicina.Name = "nud_kolicina";
            this.nud_kolicina.Size = new System.Drawing.Size(120, 22);
            this.nud_kolicina.TabIndex = 30;
            this.nud_kolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Broj jela";
            // 
            // btn_sacuvaj_stavku
            // 
            this.btn_sacuvaj_stavku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sacuvaj_stavku.Location = new System.Drawing.Point(369, 13);
            this.btn_sacuvaj_stavku.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sacuvaj_stavku.Name = "btn_sacuvaj_stavku";
            this.btn_sacuvaj_stavku.Size = new System.Drawing.Size(175, 70);
            this.btn_sacuvaj_stavku.TabIndex = 32;
            this.btn_sacuvaj_stavku.Text = "Sacuvaj izmene";
            this.btn_sacuvaj_stavku.UseVisualStyleBackColor = true;
            this.btn_sacuvaj_stavku.Click += new System.EventHandler(this.btn_sacuvaj_stavku_Click);
            // 
            // btn_odjavi_se
            // 
            this.btn_odjavi_se.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_odjavi_se.Location = new System.Drawing.Point(369, 91);
            this.btn_odjavi_se.Margin = new System.Windows.Forms.Padding(4);
            this.btn_odjavi_se.Name = "btn_odjavi_se";
            this.btn_odjavi_se.Size = new System.Drawing.Size(175, 70);
            this.btn_odjavi_se.TabIndex = 33;
            this.btn_odjavi_se.Text = "Izadji";
            this.btn_odjavi_se.UseVisualStyleBackColor = true;
            this.btn_odjavi_se.Click += new System.EventHandler(this.btn_odjavi_se_Click);
            // 
            // Izmeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 176);
            this.Controls.Add(this.btn_odjavi_se);
            this.Controls.Add(this.btn_sacuvaj_stavku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_kolicina);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_naziv_priloga);
            this.Name = "Izmeni";
            this.Text = "Izmeni";
            this.Load += new System.EventHandler(this.Izmeni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_kolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_naziv_priloga;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nud_kolicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sacuvaj_stavku;
        private System.Windows.Forms.Button btn_odjavi_se;
    }
}